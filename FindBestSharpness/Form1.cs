using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace FindBestSharpness
{
    public partial class Form1 : Form
    {

        private string curDirectory;
        private List<String> file_list;
        private int file_index;
        private VideoCapture m_vc_capture;
        private Mat m_cur_frame;
        private const int exifOrientationID = 0x112; //274


        public event ThumbnailImageEventHandler OnImageSizeChanged;

        private ThumbnailController m_Controller;

        private ImageDialog m_ImageDialog;

        private ImageViewer m_ActiveImageViewer;

        private int ImageSize
        {
            get
            {
                return (64 * (this.trackBarSize.Value + 1));
            }
        }

        public Form1()
        {
            InitializeComponent();
            curDirectory = null;
            file_index = 0;
            file_list = new List<string>();


            m_ImageDialog = new ImageDialog();

            m_AddImageDelegate = new DelegateAddImage(this.AddImage);

            m_Controller = new ThumbnailController();
            m_Controller.OnStart += new ThumbnailControllerEventHandler(m_Controller_OnStart);
            m_Controller.OnAdd += new ThumbnailControllerEventHandler(m_Controller_OnAdd);
            m_Controller.OnEnd += new ThumbnailControllerEventHandler(m_Controller_OnEnd);

        }

        private void m_Controller_OnStart(object sender, ThumbnailControllerEventArgs e)
        {

        }

        private void m_Controller_OnAdd(object sender, ThumbnailControllerEventArgs e)
        {
            this.AddImage(e.ImageFilename);
            this.Invalidate();
        }

        private void m_Controller_OnEnd(object sender, ThumbnailControllerEventArgs e)
        {
            // thread safe
            if (this.InvokeRequired)
            {
                this.Invoke(new ThumbnailControllerEventHandler(m_Controller_OnEnd), sender, e);
            }
            else
            {
                this.dirBrowerBtn.Enabled = true;
            }
        }

        delegate void DelegateAddImage(string imageFilename);
        private DelegateAddImage m_AddImageDelegate;
        private void AddImage(string imageFilename)
        {
            // thread safe
            if (this.InvokeRequired)
            {
                this.Invoke(m_AddImageDelegate, imageFilename);
            }
            else
            {
                int size = ImageSize;

                ImageViewer imageViewer = new ImageViewer();
                imageViewer.Dock = DockStyle.Bottom;
                imageViewer.LoadImage(imageFilename, 256, 256);
                imageViewer.Width = size;
                imageViewer.Height = size;
                imageViewer.IsThumbnail = true;
                imageViewer.MouseClick += new MouseEventHandler(imageViewer_MouseClick);
                imageViewer.SetFilename(imageFilename);


                this.OnImageSizeChanged += new ThumbnailImageEventHandler(imageViewer.ImageSizeChanged);

                this.flowLayoutPanelMain.Controls.Add(imageViewer);
            }
        }

        private void imageViewer_MouseClick(object sender, MouseEventArgs e)
        {
            if (m_ActiveImageViewer != null)
            {
                m_ActiveImageViewer.IsActive = false;
            }

            m_ActiveImageViewer = (ImageViewer)sender;
            m_ActiveImageViewer.IsActive = true;

            if (m_ImageDialog.IsDisposed) m_ImageDialog = new ImageDialog();
            if (!m_ImageDialog.Visible) m_ImageDialog.Show();

            m_ImageDialog.SetImage(m_ActiveImageViewer.ImageLocation);
        }

        private void trackBarSize_ValueChanged(object sender, EventArgs e)
        {
            this.OnImageSizeChanged(this, new ThumbnailImageEventArgs(ImageSize));
        }


        private void Start_Finder(object sender, EventArgs e)
        {
            string cur_filename = file_list.ElementAt(file_index++);
            Image image = Image.FromFile(cur_filename);
            ExifRotate(image);

            Mat outMat;
            if (file_index >= file_list.Count)
            {
                MessageBox.Show("Check finished", "State");
                executeButton.Enabled = false;
                return;
            }

        }
        public static void ExifRotate(Image img)
        {
            if (!img.PropertyIdList.Contains(exifOrientationID))
                return;

            var prop = img.GetPropertyItem(exifOrientationID);
            int val = BitConverter.ToUInt16(prop.Value, 0);
            var rot = RotateFlipType.RotateNoneFlipNone;

            if (val == 3 || val == 4)
                rot = RotateFlipType.Rotate180FlipNone;
            else if (val == 5 || val == 6)
                rot = RotateFlipType.Rotate90FlipNone;
            else if (val == 7 || val == 8)
                rot = RotateFlipType.Rotate270FlipNone;

            if (val == 2 || val == 4 || val == 5 || val == 7)
                rot |= RotateFlipType.RotateNoneFlipX;

            if (rot != RotateFlipType.RotateNoneFlipNone)
                img.RotateFlip(rot);
        }
        private void AddFolder()
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = @"Choose folder path";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.flowLayoutPanelMain.Controls.Clear();
                m_Controller.AddFolder(dlg.SelectedPath);                
                this.dirBrowerBtn.Enabled = false;
            }
        }

        private void dirBrowser(object sender, EventArgs e)
        {

            this.AddFolder();

            /*

            file_index = 0;
            FolderBrowserDialog dlgFolder = new FolderBrowserDialog();

            dlgFolder.SelectedPath = curDirectory == null ? Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) : curDirectory;

            if (dlgFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                curDirectory = txtDirectory.Text = dlgFolder.SelectedPath;
                DirectoryInfo d = new DirectoryInfo(curDirectory);


                file_list = new List<string>();
                string[] Extensions = { "*.jpg", "*.png", "*.jfif" };
                foreach (var ext in Extensions)
                {
                    FileInfo[] Files = d.GetFiles(ext);
                    foreach (FileInfo file in Files)
                    {
                        file_list.Add(file.FullName);
                    }
                }
            }
            if (file_list.Count > 0)
            {
                executeButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("not found any image file. Please select other directory", "Warning");
            }
            */
        }

        private void checkValidInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
    public class ThumbnailImageEventArgs : EventArgs
    {
        public ThumbnailImageEventArgs(int size)
        {
            this.Size = size;
        }

        public int Size;
    }

    public delegate void ThumbnailImageEventHandler(object sender, ThumbnailImageEventArgs e);

}
