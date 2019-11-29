namespace FindBestSharpness
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dirBrowerBtn = new System.Windows.Forms.Button();
            this.label_cur_frame = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startY = new System.Windows.Forms.TextBox();
            this.startX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sHeight = new System.Windows.Forms.TextBox();
            this.sWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.zAxis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMain = new FindBestSharpness.ThumbnailFlowLayoutPanel();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.SuspendLayout();
            // 
            // dirBrowerBtn
            // 
            this.dirBrowerBtn.Location = new System.Drawing.Point(543, 9);
            this.dirBrowerBtn.Name = "dirBrowerBtn";
            this.dirBrowerBtn.Size = new System.Drawing.Size(75, 23);
            this.dirBrowerBtn.TabIndex = 0;
            this.dirBrowerBtn.Text = "Browser...";
            this.dirBrowerBtn.UseVisualStyleBackColor = true;
            this.dirBrowerBtn.Click += new System.EventHandler(this.dirBrowser);
            // 
            // label_cur_frame
            // 
            this.label_cur_frame.Location = new System.Drawing.Point(10, 34);
            this.label_cur_frame.Name = "label_cur_frame";
            this.label_cur_frame.Size = new System.Drawing.Size(49, 23);
            this.label_cur_frame.TabIndex = 3;
            this.label_cur_frame.Text = "Start X :";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(12, 11);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(525, 20);
            this.txtDirectory.TabIndex = 4;
            this.txtDirectory.Text = "Select the Directory";
            // 
            // executeButton
            // 
            this.executeButton.Enabled = false;
            this.executeButton.Location = new System.Drawing.Point(639, 9);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 0;
            this.executeButton.Text = "Start";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.Start_Finder);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Y :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startY);
            this.groupBox1.Controls.Add(this.startX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_cur_frame);
            this.groupBox1.Location = new System.Drawing.Point(639, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start Point";
            // 
            // startY
            // 
            this.startY.Location = new System.Drawing.Point(65, 67);
            this.startY.Name = "startY";
            this.startY.Size = new System.Drawing.Size(100, 20);
            this.startY.TabIndex = 4;
            this.startY.Text = "0";
            this.startY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkValidInput);
            // 
            // startX
            // 
            this.startX.Location = new System.Drawing.Point(65, 33);
            this.startX.Name = "startX";
            this.startX.Size = new System.Drawing.Size(100, 20);
            this.startX.TabIndex = 4;
            this.startX.Text = "0";
            this.startX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkValidInput);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sHeight);
            this.groupBox2.Controls.Add(this.sWidth);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(639, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 105);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // sHeight
            // 
            this.sHeight.Location = new System.Drawing.Point(65, 67);
            this.sHeight.Name = "sHeight";
            this.sHeight.Size = new System.Drawing.Size(100, 20);
            this.sHeight.TabIndex = 4;
            this.sHeight.Text = "100";
            this.sHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkValidInput);
            // 
            // sWidth
            // 
            this.sWidth.Location = new System.Drawing.Point(65, 33);
            this.sWidth.Name = "sWidth";
            this.sWidth.Size = new System.Drawing.Size(100, 20);
            this.sWidth.TabIndex = 4;
            this.sWidth.Text = "100";
            this.sWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkValidInput);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Width :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.zAxis);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(639, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 105);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "100";
            // 
            // zAxis
            // 
            this.zAxis.Location = new System.Drawing.Point(65, 33);
            this.zAxis.Name = "zAxis";
            this.zAxis.Size = new System.Drawing.Size(100, 20);
            this.zAxis.TabIndex = 4;
            this.zAxis.Text = "100";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Z axis :";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.flowLayoutPanelMain);
            this.panelMain.Location = new System.Drawing.Point(12, 49);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(606, 396);
            this.panelMain.TabIndex = 7;
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(606, 396);
            this.flowLayoutPanelMain.TabIndex = 0;
            // 
            // trackBarSize
            // 
            this.trackBarSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSize.AutoSize = false;
            this.trackBarSize.LargeChange = 1;
            this.trackBarSize.Location = new System.Drawing.Point(723, 10);
            this.trackBarSize.Maximum = 2;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(124, 23);
            this.trackBarSize.TabIndex = 6;
            this.trackBarSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSize.Value = 1;
            this.trackBarSize.ValueChanged += new System.EventHandler(this.trackBarSize_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 461);
            this.Controls.Add(this.trackBarSize);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.dirBrowerBtn);
            this.Name = "Form1";
            this.Text = "Find_BestSharpness";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dirBrowerBtn;
        private System.Windows.Forms.Label label_cur_frame;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox startY;
        private System.Windows.Forms.TextBox startX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox sHeight;
        private System.Windows.Forms.TextBox sWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox zAxis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TrackBar trackBarSize;
        private ThumbnailFlowLayoutPanel flowLayoutPanelMain;
    }
}

