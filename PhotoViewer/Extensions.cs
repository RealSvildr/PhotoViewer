using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PhotoViewer {
    public static class Extensions {
        public static decimal zoom { get; private set; }
        public static decimal baseZoom { get; private set; }
        public static readonly decimal maxZoom = 16;

        private static Point mousePosition;
        private static bool defaultZoom = true;
        internal static string actualHash;

        public static void aLoad(this PictureBox image, string path) {
            string ext = path.Split('.').Last().ToLower();

            actualHash = getFileHash(path);
            MemoryStream mS = new MemoryStream();
            using (Image i = Image.FromFile(path)) {
                i.Save(mS, i.RawFormat); //imgFormat
            }
            image.Image = Image.FromStream(mS);
        }
        public static void aResize(this PictureBox image) {
            Control panel = image.Parent;

            if (zoom > maxZoom) {
                zoom = maxZoom;
            }

            if (defaultZoom) {
                zoom = baseZoom > 1 ? 1 : baseZoom;
            }

            if (zoom > baseZoom) {
                panel.Cursor = Cursors.SizeAll;
                image.Cursor = Cursors.SizeAll;
            } else {
                panel.Cursor = Cursors.Default;
                image.Cursor = Cursors.Default;
            }


            decimal panelWidth = panel.Width,
                    panelHeight = panel.Height,
                    imgWidthOld = image.Width,
                    imgHeightOld = image.Height,
                    imgWidth = image.Image.Width * zoom,
                    imgHeight = image.Image.Height * zoom,
                    posX = mousePosition.X,
                    posY = mousePosition.Y;


            image.Size = new Size((int)imgWidth, (int)imgHeight);

            // Reposition
            decimal distWidth = panelWidth - imgWidth,
                    distHeight = panelHeight - imgHeight;

            decimal tempDiff;

            if (panelWidth >= imgWidth || mousePosition == new Point(0, 0)) {
                if (distWidth > 0)
                    distWidth /= 2;
            } else {
                tempDiff = distWidth;

                distWidth = -(imgWidth * (-image.Left + posX) / imgWidthOld - posX);

                if (distWidth > 0) {
                    distWidth = 0;
                } else if (distWidth < tempDiff) {
                    distWidth = tempDiff;
                }
            }

            if (panelHeight >= imgHeight || mousePosition == new Point(0, 0)) {
                if (distHeight > 0)
                    distHeight /= 2;
            } else {
                tempDiff = distHeight;

                distHeight = -(imgHeight * (-image.Top + posY) / imgHeightOld - posY);

                if (distHeight > 0) {
                    distHeight = 0;
                } else if (distHeight < tempDiff) {
                    distHeight = tempDiff;
                }
            }

            image.Location = new Point((int)Math.Round(distWidth), (int)Math.Round(distHeight));
        }
        public static void aRotate(this PictureBox image, bool clockwise) {
            Image img = image.Image;

            if (clockwise) {
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            } else {
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }

            image.Image = img;
            image.setZoomBase();
            zoom = baseZoom;
            image.aResize();
        }
        public static void aMove(this PictureBox image, int X, int Y) {
            int panelWidth = image.Parent.Width;
            int panelHeight = image.Parent.Height;

            int imgWidth = image.Width;
            int imgHeight = image.Height;

            int posX = image.Left;
            int posY = image.Top;

            int tempDiff = 0;

            if (X > 0 && imgWidth > panelWidth) {
                tempDiff = panelWidth - imgWidth;
                posX += X - mousePosition.X;

                if (posX > 0) {
                    posX = 0;
                } else if (posX < tempDiff) {
                    posX = tempDiff;
                }

                image.Left = posX;
            }

            if (Y > 0 && imgHeight > panelHeight) {
                tempDiff = panelHeight - imgHeight;
                posY += Y - mousePosition.Y;

                if (posY > 0) {
                    posY = 0;
                } else if (posY < tempDiff) {
                    posY = tempDiff;
                }

                image.Top = posY;
            }
        }
        public static void aZoom(this PictureBox image, decimal diffZoom, Point? mousePos = null) {
            if (mousePos == null) {
                mousePos = new Point(image.Parent.Width / 2, image.Parent.Height / 2);
            }

            if (defaultZoom && diffZoom < 0) {
                return;
            }

            zoom += diffZoom;
            defaultZoom = ((baseZoom < 1 && zoom <= baseZoom) || (baseZoom >= 1 && zoom <= 1));

            mousePosition = mousePos.Value;
            image.aResize();
        }
        public static void aReset(this PictureBox image) {
            defaultZoom = true;
            image.aResize();
        }

        public static void unload(this PictureBox image) {
            Image img = image.Image;
            image.Image = global::PhotoViewer.Properties.Resources._blank;

            if (img != null) {
                img.Dispose();
            }
        }
        public static void setZoomBase(this PictureBox image) {
            decimal panelWidth = image.Parent.Width;
            decimal panelHeight = image.Parent.Height;

            decimal imgWidth = image.Image.Width;
            decimal imgHeight = image.Image.Height;

            decimal tempEscaleWidth = panelWidth / imgWidth;
            decimal tempEscaleHeight = panelHeight / imgHeight;


            baseZoom = tempEscaleWidth < tempEscaleHeight ? tempEscaleWidth : tempEscaleHeight;
        }
        public static void setMousePosition(Point position) {
            mousePosition = position;
        }

        internal static string getFileHash(string path) {
            HashAlgorithm sha1 = HashAlgorithm.Create();
            byte[] ret;

            try {
                using (Stream st = new FileStream(path, FileMode.Open, FileAccess.Read)) {
                    ret = sha1.ComputeHash(st);
                }

                return ret.ByteArrayToString();
            } catch (Exception) { }

            return null;
        }
        internal static string ByteArrayToString(this byte[] byteArray) {
            string str = "";

            foreach (byte b in byteArray) {
                str += b.ToString("X2");
            }

            return str;
        }

        #region Numerical Sort
        public static List<Img> NumericalSort(this IEnumerable<Img> listString) {
            IEnumerable<sString> sortedList = listString.Select(p => new sString() { originFile = p, sortName = nameSort(p.Name) });

            return sortedList.OrderBy(p => p.sortName).Select(p => p.originFile).ToList();
        }

        private static string nameSort(string str) {
            string nList = "0123456789";
            string newStr = string.Empty;
            int i, tempI = 0;

            for (i = 0; i < str.Length; i++) {
                if (nList.IndexOf(str[i]) == -1) {
                    newStr += str[i];
                } else {
                    int counter = 6;
                    tempI = i;

                    while (tempI < str.Length && nList.IndexOf(str[tempI]) > -1) {
                        tempI++;
                        counter--;
                    }

                    while (counter > 0) {
                        newStr += "0";
                        counter--;
                    }

                    while (i < tempI) {
                        newStr += str[i];
                        i++;
                    }
                }
            }
            return newStr;
        }

        private class sString {
            public Img originFile { get; set; }
            public string sortName { get; set; }
        }
        #endregion

    }
}