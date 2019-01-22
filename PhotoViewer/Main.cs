using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static PhotoViewer.Extensions;

namespace PhotoViewer {
    //TODO: Effects on button hover
    public partial class Main : Form {
        Thread th_checkHash;
       
        private List<Img> _imageList = new List<Img>();
        private List<string> _permittedExtensions = new List<string>();
        private int _imagePosition = 0;

        public Main(string[] dirImage) {
            this.Font = new System.Drawing.Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            this.AutoScaleMode = AutoScaleMode.None;

            InitializeComponent();
            InitializeLayout();

            generatePermittedExtensions();

            //TEST AREA
            //if (dirImage.Length == 0)
            //    dirImage = new string[1] { @"D:\Test\animais_interessantes4.jpg" };

            if (dirImage.Length > 0) {
                generateImageList(dirImage[0]);
                if (_imageList.Count == 0) {
                    errorMessage();
                    return;
                }

                loadImage();
                th_checkHash = new Thread(checkImageHash) { IsBackground = true };
                th_checkHash.Start();
            } else {
                errorMessage();
            }
        }

        #region Image Functions
        /// <summary>
        /// n == Next
        /// p == Previous
        /// d == Delete
        /// e == Error
        /// </summary>
        /// <param name="cCommand"></param>
        private void loadImage(char? cCommand = null) {
            testHarsh = false;
            if (this.InvokeRequired) {
                this.Invoke(new MethodInvoker(delegate { loadImage(cCommand); })); //, true)
                return;
            }

            try {
                if (cCommand != null) {
                    switch (cCommand) {
                        case 'n':
                            _imagePosition++;

                            if (_imagePosition > _imageList.Count - 1) {
                                _imagePosition = 0;
                            }
                            break;
                        case 'p':
                            _imagePosition--;

                            if (_imagePosition < 0) {
                                _imagePosition = _imageList.Count - 1;
                            }
                            break;
                        case 'd':
                            _imageList.RemoveAt(_imagePosition);

                            if (_imagePosition > _imageList.Count - 1) {
                                _imagePosition--;
                            }
                            break;
                    }
                }

                image.unload();

                if (_imageList.Count == 0 || cCommand == 'e') {
                    this.Text = "Photo Viewer";
                    errorMessage();
                } else {
                    this.Text = _imageList[_imagePosition].Name + " - Photo Viewer";

                    image.aLoad(_imageList[_imagePosition].FullDir);
                    image.Visible = true;

                    lbl_message.Text = "";
                    lbl_message.Visible = false;

                    image.setZoomBase();
                    image.aReset();

                    image.Refresh();
                }
            } catch (FileNotFoundException) {
                string imgDir = _imageList[_imagePosition].FullDir;
                _imageList.Clear();
                generateImageList(imgDir);

                loadImage(cCommand);
                return;
            } catch (Exception) {
                errorMessage();
            }

            testHarsh = true;
        }
        private void forward() {
            if (_imageList.Count < 2)
                return;

            loadImage('n');
            Thread.Sleep(50);
        }
        private void backward() {
            if (_imageList.Count < 2)
                return;

            loadImage('p');
            Thread.Sleep(50);
        }
        private void delete() {
            string imgDir = _imageList[_imagePosition].FullDir;
            loadImage('d');

            FileSystem.DeleteFile(
                imgDir,
                UIOption.OnlyErrorDialogs,
                RecycleOption.SendToRecycleBin
            );
        }

        private void fullscreen() {
            if (_imageList.Count > 0) {
                using (Fullscreen fs = new Fullscreen(new object[] { _imageList, _imagePosition })) {
                    Hide();
                    th_checkHash.Abort();
                    fs.ShowDialog();

                    ///////
                    Show();
                    BringToFront();
                    image.Focus();

                    if (fs.currentImage != null) {
                        _imagePosition = _imageList.IndexOf(fs.currentImage);
                        loadImage();
                    }

                    th_checkHash = new Thread(checkImageHash);
                    th_checkHash.IsBackground = true;
                    th_checkHash.Start();
                }
            }
        }

        private void generatePermittedExtensions() {
            _permittedExtensions.AddRange(new List<string> { "jpg", "png", "gif", "jpeg", "bmp", "jpe", "ico", "tif", "tiff", "jfif", "webp" });
        }
        private void generateImageList(string dirImage) {
            FileInfo fileInfo = new FileInfo(dirImage);

            DirectoryInfo dirInfo = new DirectoryInfo(fileInfo.DirectoryName);

            foreach (var file in dirInfo.GetFiles()) {
                if (file.FullName == dirImage || _permittedExtensions.Contains(file.Extension.Trim('.').ToLower())) {
                    _imageList.Add(new Img() {
                        Name = file.Name.Substring(0, file.Name.Length - file.Extension.Length),
                        Dir = file.Directory.FullName,
                        FullDir = file.FullName
                    });
                }
            }

            _imageList = _imageList.NumericalSort();
            _imagePosition = _imageList.IndexOf(_imageList.Where(p => p.FullDir == dirImage).FirstOrDefault());
        }

        private void errorMessage() {
            if (this.InvokeRequired) {
                this.Invoke(new MethodInvoker(delegate { errorMessage(); }));
                return;
            }

            writeMessage("Photo Viewer can't open this picture because either Photo Viewer doesn't support this file format, or you don't have the latest updates to Photo Viewer.");
        }
        private void writeMessage(string message) {
            image.Visible = false;
            lbl_message.Visible = true;

            lbl_message.Text = message;
            messageReposition();
        }
        private void messageReposition() {
            if (lbl_message.Visible) {
                lbl_message.MaximumSize = pnl_Image.Size;

                int distWidth = pnl_Image.Width - lbl_message.Width;
                int distHeight = pnl_Image.Height - lbl_message.Height;

                distWidth = distWidth == 0 ? 0 : distWidth / 2;
                distHeight = distHeight == 0 ? 0 : distHeight / 2;

                lbl_message.Top = distHeight;
                lbl_message.Left = distWidth;
            }
        }
        #endregion

        #region Actions
        private void pnl_Image_Resize(object sender, EventArgs e) {
            if (pnl_Image.Height > 250 && pnl_Image.Width > 350) {
                image.setZoomBase();
                image.aResize();
                messageReposition();
            }
        }

        #region Buttons
        private void btn_Zoom_Click(object sender, EventArgs e) {
            int minZoom = (int)Math.Floor(baseZoom);

            tb_zoom.Minimum = minZoom * 10;
            tb_zoom.Maximum = (int)maxZoom * 10;
            tb_zoom.Value = (int)zoom * 10;

            tb_zoom.Visible = true;
        }
        private void tb_zoom_Leave(object sender, EventArgs e) {
            tb_zoom.Visible = false;
        }
        private void tb_zoom_MouseLeave(object sender, EventArgs e) {
            tb_zoom.Visible = false;
        }
        private void tb_zoom_ValueChanged(object sender, EventArgs e) {
            image.aZoom((tb_zoom.Value - (zoom * 10)) / 10);
        }
        private void btn_normalize_Click(object sender, EventArgs e) {
            image.aReset();
        }
        private void btn_backward_Click(object sender, EventArgs e) {
            backward();
        }
        private void btn_Forward_Click(object sender, EventArgs e) {
            forward();
        }
        private void btn_fullscreen_Click(object sender, EventArgs e) {
            fullscreen();
        }
        private void btn_counterClockwise_Click(object sender, EventArgs e) {
            image.aRotate(false);
        }
        private void btn_clockwise_Click(object sender, EventArgs e) {
            image.aRotate(true);
        }
        private void btn_delete_Click(object sender, EventArgs e) {
            delete();
        }

        private void tsi_delete_Click(object sender, EventArgs e) {
            delete();
        }
        private void tsi_makecopy_Click(object sender, EventArgs e) {
            //TODO
        }
        private void tsi_copy_Click(object sender, EventArgs e) {
            //TODO
        }
        private void tsi_properties_Click(object sender, EventArgs e) {
            //TODO
        }
        private void tsi_exit_Click(object sender, EventArgs e) {
            this.Dispose();
        }
        private void tsi_print_Click(object sender, EventArgs e) {
            //TODO
        }
        private void tsi_orderprint_Click(object sender, EventArgs e) {
            //TODO
        }
        private void tsi_email_Click(object sender, EventArgs e) {
            //TODO
        }
        private void tsi_datadisc_Click(object sender, EventArgs e) {
            //TODO
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) {
            Img img = _imageList[_imagePosition];
            Process.Start("mspaint", "\"" + img.FullDir + "\"");
        }
        private void setAsDesktopToolStripMenuItem_Click(object sender, EventArgs e) {
            //TODO
        }
        private void openFileLocationToolStripMenuItem_Click(object sender, EventArgs e) {
            Img img = _imageList[_imagePosition];
            Process.Start(img.Dir);
        }
        private void rotateRightToolStripMenuItem_Click(object sender, EventArgs e) {
            image.aRotate(false);
        }
        private void rotateLeftToolStripMenuItem_Click(object sender, EventArgs e) {
            image.aRotate(true);
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            //TODO
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            delete();
        }
        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e) {
            //TODO
        }
        #endregion

        #region Mouse
        private void Form1_MouseWhell(object sender, MouseEventArgs e) {
            image.aZoom(((decimal)e.Delta / 1000) * zoom, new Point(e.X, e.Y));

        }
        private void image_MouseDown(object sender, MouseEventArgs e) {
            setMousePosition(e.Location);
        }
        private void pnl_Image_MouseDown(object sender, MouseEventArgs e) {
            setMousePosition(e.Location);
        }

        private void image_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                image.aMove(e.X, e.Y);
            }
        }
        private void pnl_Image_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                image.aMove(e.X, e.Y);
                setMousePosition(new Point(e.X, e.Y));
            }
        }
        #region Hover
        #endregion
        #endregion

        #region Keyboard
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {

            switch (keyData) {
                case Keys.Oemplus:
                case Keys.Add:
                    image.aZoom((decimal)0.1 * zoom);
                    break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    image.aZoom(-(decimal)0.1 * zoom);
                    break;
                case Keys.Up:
                    image.aZoom(baseZoom - zoom);
                    break;
                case Keys.Left:
                    backward();
                    break;
                case Keys.Right:
                    forward();
                    break;
                case Keys.Delete:
                    delete();
                    break;
                case Keys.F11:
                    fullscreen();
                    break;
                case Keys.Escape:
                    tb_zoom.Visible = false;
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
        #endregion

        #region Layout
        private void InitializeLayout() {
            glassBorder();
            hideTopBar();
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS {
            public int left;
            public int rig;
            public int top;
            public int bot;
        }

        [DllImport("DwmApi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarginset);

        private void glassBorder() {
            MARGINS margin = new MARGINS {
                top = 0,
                bot = 52
            };
            //panel1.Height = bottom;

            DwmExtendFrameIntoClientArea(this.Handle, ref margin);
        }

        private void hideTopBar() {
            toolStrip1.Hide();
            pnl_Image.Location = new Point(0, 0);
            pnl_Image.Height = this.Height - (92);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }
        #endregion
        
        private void checkImageHash() {
            while (true) {
                if (testHarsh) {
                    if (_imageList.Count == 0) {
                        errorMessage();
                        break;
                    }
                    

                    string hash = getFileHash(_imageList[_imagePosition].FullDir);

                    if (hash != null && hash != actualHash) {
                        loadImage();
                    }
                }

                Thread.Sleep(1000);
            }
        }

    }

    public class Img {
        public string Name { get; set; }
        public string Dir { get; set; }
        public string FullDir { get; set; }
    }
}
