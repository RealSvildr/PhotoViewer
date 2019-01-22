using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PhotoViewer {
    // TODO: Change ThreadTimer for Windows.Forms.Timer
    public partial class Fullscreen : Form {
        public Fullscreen(object[] args) {
            InitializeComponent();

            if (args.Length != 2)
                return;

            ImageList.AddRange((List<Img>)args[0]);
            ImagePosition = (int)args[1];

            threadForward = new Thread(execution);
            threadForward.IsBackground = true;
            threadForward.Start();
        }

        private Thread threadForward;
        private bool threadExecution = true;
        private bool jumpOne = false;
        private bool loop = true;
        private Timer threadTimer = Timer.Medium;

        public Img currentImage;
        private List<Img> ImageList = new List<Img>();
        private int ImagePosition = 0;
        private decimal maxZoom = 5;
        private decimal Zoom = 1;

        #region Image Functions
        private void loadImage() {
            if (this.InvokeRequired) {
                this.Invoke(new MethodInvoker(delegate { loadImage(); }));
                return;
            }

            Zoom = 1;

            try {
                image.unload();
                image.aLoad(ImageList[ImagePosition].FullDir);

                imageResize();

                image.Visible = true;
                lbl_message.Text = "";
                lbl_message.Visible = false;
            } catch (Exception) {
                writeMessage("Photo Viewer can't open this picture because either Photo Viewer doesn't support this file format, or you don't have the latest updates to Photo Viewer.");
            }
        }
        private void forward() {
            if (ImageList.Count < 2)
                return;

            ImagePosition++;

            if (ImagePosition > ImageList.Count - 1) {
                ImagePosition = 0;
            }

            jumpOne = true;
            loadImage();
        }
        private void backward() {
            if (ImageList.Count < 2)
                return;

            ImagePosition = ImagePosition == 0 ? ImageList.Count - 1 : ImagePosition - 1;

            jumpOne = true;
            loadImage();
        }

        private void execution() {
            Thread.Sleep(100);
            loadImage();

            while (true) {
                Thread.Sleep((int)threadTimer);

                if (threadExecution && !jumpOne && (loop || ImagePosition < ImageList.Count - 1)) {
                    forward();
                }

                jumpOne = false;
            }
        }
        private void shuffle() {
            Random rdn = new Random();
            Img tempImg = ImageList[ImagePosition];
            List<Img> tempList = new List<Img>();

            int totalList = ImageList.Count;

            for (int i = 0; i < totalList; i++) {
                int posDelete = rdn.Next(ImageList.Count);
                tempList.Add(ImageList[posDelete]);

                ImageList.RemoveAt(posDelete);
            }

            ImageList = tempList;
            ImagePosition = ImageList.IndexOf(tempImg);
        }
        private void exit() {
            currentImage = ImageList[ImagePosition];

            threadForward.Abort();
            this.Close();
        }
        private void pausePlay() {
            threadExecution = !threadExecution;

            playToolStripMenuItem.Enabled = !threadExecution;
            pauseToolStripMenuItem.Enabled = threadExecution;
        }

        private void imageResize() {
            int panelWidth = pnl_image.Width;
            int panelHeight = pnl_image.Height;

            int imgWidth = image.Image.Width;
            int imgHeight = image.Image.Height;

            decimal tempEscaleWidth = (decimal)panelWidth / (decimal)imgWidth;
            decimal tempEscaleHeight = (decimal)panelHeight / (decimal)imgHeight;

            Zoom = tempEscaleHeight < tempEscaleWidth ? tempEscaleHeight : tempEscaleWidth;

            if (Zoom > maxZoom)
                Zoom = maxZoom;


            imgWidth = (int)decimal.Floor((decimal)imgWidth * Zoom);
            imgHeight = (int)decimal.Floor((decimal)imgHeight * Zoom);

            image.Width = imgWidth;
            image.Height = imgHeight;

            //Reposition
            int distWidth = panelWidth - imgWidth;
            int distHeight = panelHeight - imgHeight;


            distWidth = distWidth == 0 ? 0 : distWidth / 2;
            distHeight = distHeight == 0 ? 0 : distHeight / 2;

            image.Location = new Point(distWidth, distHeight);
        }

        private void writeMessage(string message) {
            image.Visible = false;
            lbl_message.Visible = true;

            lbl_message.Text = message;
            messageReposition(true);
        }
        private void messageReposition(bool force = false) {
            if (lbl_message.Visible || force) {
                lbl_message.MaximumSize = pnl_image.Size;

                int distWidth = pnl_image.Width - lbl_message.Width;
                int distHeight = pnl_image.Height - lbl_message.Height;

                distWidth = distWidth == 0 ? 0 : distWidth / 2;
                distHeight = distHeight == 0 ? 0 : distHeight / 2;

                lbl_message.Top = distHeight;
                lbl_message.Left = distWidth;
            }
        }
        #endregion

        #region Buttons
        private void playToolStripMenuItem_Click(object sender, EventArgs e) {
            pausePlay();
        }
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e) {
            pausePlay();
        }
        private void nextToolStripMenuItem_Click(object sender, EventArgs e) {
            jumpOne = true;
            forward();
        }
        private void backToolStripMenuItem_Click(object sender, EventArgs e) {
            jumpOne = true;
            backward();
        }
        private void shuffleToolStripMenuItem_Click(object sender, EventArgs e) {
            shuffle();
        }
        private void loopToolStripMenuItem_Click(object sender, EventArgs e) {
            if (loop) {
                loopToolStripMenuItem.Image = global::PhotoViewer.Properties.Resources._blank;
            } else {
                loopToolStripMenuItem.Image = global::PhotoViewer.Properties.Resources.selected;
            }

            loop = !loop;
        }
        private void slideSpeedToolStripMenuItem_Click(object sender, EventArgs e) {
            if (threadTimer != Timer.Slow) {
                slideSpeedToolStripMenuItem.Image = global::PhotoViewer.Properties.Resources.selected;
                slideShowSpeedMediumToolStripMenuItem.Image = global::PhotoViewer.Properties.Resources._blank;
                slideShowSpeedFastToolStripMenuItem.Image = global::PhotoViewer.Properties.Resources._blank;

                threadTimer = Timer.Slow;
            }
        }
        private void slideShowSpeedMediumToolStripMenuItem_Click(object sender, EventArgs e) {
            if (threadTimer != Timer.Medium) {
                slideSpeedToolStripMenuItem.Image = global::PhotoViewer.Properties.Resources._blank;
                slideShowSpeedMediumToolStripMenuItem.Image = global::PhotoViewer.Properties.Resources.selected;
                slideShowSpeedFastToolStripMenuItem.Image = global::PhotoViewer.Properties.Resources._blank;

                threadTimer = Timer.Medium;
            }
        }
        private void slideShowSpeedFastToolStripMenuItem_Click(object sender, EventArgs e) {
            if (threadTimer != Timer.Fast) {
                slideSpeedToolStripMenuItem.Image = global::PhotoViewer.Properties.Resources._blank;
                slideShowSpeedMediumToolStripMenuItem.Image = global::PhotoViewer.Properties.Resources._blank;
                slideShowSpeedFastToolStripMenuItem.Image = global::PhotoViewer.Properties.Resources.selected;

                threadTimer = Timer.Fast;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            exit();
        }

        private void image_Click(object sender, EventArgs e) {
            forward();
        }
        #endregion

        #region Keyboard
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            switch (keyData) {
                case Keys.Left:
                    backward();
                    break;
                case Keys.Right:
                    forward();
                    break;
                case Keys.Space:
                    pausePlay();
                    break;
                case Keys.NumPad0:
                case Keys.NumPad1:
                case Keys.Control:
                case Keys.Alt:
                case Keys.Shift:
                case Keys.Tab:
                case Keys.Capital:
                case Keys.ShiftKey | Keys.Shift:
                case Keys.ControlKey | Keys.Control:
                case Keys.Menu | Keys.Alt:
                    break;
                default:
                    exit();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Fade In/Out
        private void Fullscreen_Load(object sender, EventArgs e) {
            Opacity = 0;

            while (Opacity < 1) {
                Opacity += 0.05;
                Thread.Sleep(15);
            }
        }

        private void Fullscreen_FormClosing(object sender, FormClosingEventArgs e) {
            Cursor.Show();

            while (Opacity > 0) {
                Opacity -= 0.05;
                Thread.Sleep(15);
            }
        }
        #endregion

        #region Mouse Hide
        private TimeSpan hiddenTime = TimeSpan.FromSeconds(1);
        private DateTime lastMouseMove = DateTime.Now;
        private bool isHidden = false;

        private void mouseMove(object sender, MouseEventArgs e) {
            lastMouseMove = DateTime.Now;

            if (isHidden) {
                Cursor.Show();
                isHidden = false;
            }
        }

        private void mouseTimer_Tick(object sender, EventArgs e) {
            if (!isHidden && DateTime.Now - lastMouseMove >= hiddenTime) {
                Cursor.Hide();
                isHidden = true;
            }
        }
        #endregion

        internal enum Timer {
            Fast = 3700,
            Medium = 5200,
            Slow = 6700
        }
    }
}