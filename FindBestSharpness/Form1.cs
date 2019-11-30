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

using MathNet.Numerics.Interpolation;

namespace FindBestSharpness
{
    public partial class Form1 : Form
    {

        private string curDirectory;
        private List<String> file_list;
        private List<String> path_list;
        private int file_index;
        private Mat m_cur_frame;
        private const int exifOrientationID = 0x112; //274

        private List<int> arrayOfZHeights;
        private List<Bitmap> arrayOfImages;
        private List<double> arrayOfStd;
        int sizeSquare;
        Point centerSquare;


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
            path_list = new List<string>();
            arrayOfZHeights = new List<int>();
            arrayOfImages = new List<Bitmap>();
            arrayOfStd = new List<double>();
            sizeSquare = 100;
            centerSquare = new Point(0, 0);


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
                this.executeButton.Enabled = true;
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
                string file = Path.GetFileNameWithoutExtension(imageFilename);
                file_list.Add(file);
                path_list.Add(imageFilename);
                int size = ImageSize;

                ImageViewer imageViewer = new ImageViewer();
                imageViewer.Dock = DockStyle.Bottom;
                imageViewer.LoadImage(imageFilename, 256, 256);
                imageViewer.Width = size;
                imageViewer.Height = size;
                imageViewer.IsThumbnail = true;
                imageViewer.MouseClick += new MouseEventHandler(imageViewer_MouseClick);
                imageViewer.SetFilename(file);





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
            //             string cur_filename = file_list.ElementAt(file_index++);
            //             Image image = Image.FromFile(cur_filename);
            //             ExifRotate(image);
            // 
            //             Mat outMat;
            //             if (file_index >= file_list.Count)
            //             {
            //                 MessageBox.Show("Check finished", "State");
            //                 executeButton.Enabled = false;
            //                 return;
            //             }

            arrayOfZHeights.Clear();
            arrayOfImages.Clear();
            arrayOfStd.Clear();

            sizeSquare = int.Parse(sSquare.Text);
            centerSquare.X = int.Parse(startX.Text);
            centerSquare.Y = int.Parse(startY.Text);

            foreach(string file in file_list)
            {
                arrayOfZHeights.Add(int.Parse(file));
            }

            foreach(string path in path_list)
            {
                arrayOfImages.Add(new Bitmap(path));
            }

            int bestHeight = FindSharpestImage(arrayOfImages.ToArray(), arrayOfZHeights.ToArray(), sizeSquare, centerSquare);


        }

        private int FindSharpestImage(Bitmap[] arrayOfImages, int[] arrayOfHeights, int sizeSquare, Point centerSquare)
        {
            if (arrayOfImages.Length != arrayOfHeights.Length)
                return -1;
            for (int i = 0; i < arrayOfImages.Length; i++)
            {
                Image<Bgr, Byte> imageCV = new Image<Bgr, Byte>(arrayOfImages[i]);
                Mat mat = imageCV.Mat;
                Mat cropMat = new Mat(mat, new Rectangle(centerSquare, new Size(sizeSquare, sizeSquare)));
//                 CvInvoke.CvtColor(mat, mat, ColorConversion.Bgr2Gray);
                Mat outMat = new Mat();
                CvInvoke.Laplacian(cropMat, outMat, DepthType.Cv64F);

                MCvScalar meanScalar = new MCvScalar();
                MCvScalar stdScalar = new MCvScalar();
                CvInvoke.MeanStdDev(outMat, ref meanScalar, ref stdScalar);
                double measured = stdScalar.V0 * stdScalar.V0 + stdScalar.V1 * stdScalar.V1 + stdScalar.V2 * stdScalar.V2;

                arrayOfStd.Add(measured);
            }

            int bestHeight = FindGoodHeight(arrayOfHeights, arrayOfStd.ToArray());

            return bestHeight;
        }

        private int FindGoodHeight(int[] heights,  double[] stdVariance)
        {
            if(0 == stdVariance.Length)
                return -1;
            double[] xVec = heights.ToList().Select(x => (double)x).ToArray();
            CubicSpline cubicSpline = CubicSpline.InterpolateNatural(xVec, stdVariance);

            int maxHeight = heights.ToList().Max();
            int minHeight = heights.ToList().Min();
            int count = maxHeight - minHeight;
            double[] predXVec = new double[count];
            double[] predYVec = new double[count];

            double maxYVect = 0;
            int ret = 0;

            for(int i = 0; i < count; i++)
            {
                predXVec[i] = minHeight + i;
                predYVec[i] = cubicSpline.Interpolate(predXVec[i]);
                if (maxYVect < predYVec[i])
                {
                    maxYVect = predYVec[i];
                    ret = (int)predXVec[i];
                }

//                 maxXElement = maxXElement < predYVec[i] ? predYVec[i] : maxXElement;
            }

            return ret;

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
                InitializeMembers();
                this.flowLayoutPanelMain.Controls.Clear();
                m_Controller.AddFolder(dlg.SelectedPath);                
                this.dirBrowerBtn.Enabled = false;
            }
        }

        private void InitializeMembers()
        {
            file_list.Clear();
            path_list.Clear();
            arrayOfZHeights.Clear();
            arrayOfImages.Clear();
            arrayOfStd.Clear();
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)/* && (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }

            // only allow one decimal point
//             if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
//             {
//                 e.Handled = true;
//             }
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

//     public struct StdVariance
//     {
//         public int height;
//         public double variance;
// 
//         public StdVariance(int h, double v)
//         {
//             height = h;
//             variance = v;
//         }
// 
//     }

    public delegate void ThumbnailImageEventHandler(object sender, ThumbnailImageEventArgs e);

}
