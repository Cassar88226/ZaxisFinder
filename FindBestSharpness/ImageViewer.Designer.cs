namespace FindBestSharpness
{
    partial class ImageViewer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.strFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // strFileName
            // 
            this.strFileName.AutoSize = true;
            this.strFileName.Location = new System.Drawing.Point(3, 0);
            this.strFileName.Name = "strFileName";
            this.strFileName.Size = new System.Drawing.Size(46, 13);
            this.strFileName.TabIndex = 0;
            this.strFileName.Text = "filename";
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.strFileName);
            this.DoubleBuffered = true;
            this.Name = "ImageViewer";
            this.Size = new System.Drawing.Size(227, 210);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label strFileName;
    }
}
