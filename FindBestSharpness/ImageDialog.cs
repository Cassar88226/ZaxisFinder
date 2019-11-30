using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace FindBestSharpness
{
    public partial class ImageDialog : Form
    {
        public ImageDialog()
        {
            InitializeComponent();
        }

        public void SetImage(string filename)
        {
            SetImageIntern(filename);
//             Thread thread = new Thread(new ParameterizedThreadStart(SetImageIntern));
//             thread.IsBackground = true;
//             thread.Start(filename);
        }

        private void SetImageIntern(object filename)
        {
            this.imageViewerFull.Image = Image.FromFile((string)filename);
            string file = Path.GetFileNameWithoutExtension((string)filename);

            this.imageViewerFull.SetFilename(file);
            this.imageViewerFull.Invalidate();
        }

        private void ImageDialog_Resize(object sender, EventArgs e)
        {
            this.imageViewerFull.Invalidate();
        }
    }
}