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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startX = new System.Windows.Forms.TextBox();
            this.startY = new System.Windows.Forms.TextBox();
            this.sSquare = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.zAxis = new System.Windows.Forms.TextBox();
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
            this.dirBrowerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirBrowerBtn.Location = new System.Drawing.Point(633, 9);
            this.dirBrowerBtn.Name = "dirBrowerBtn";
            this.dirBrowerBtn.Size = new System.Drawing.Size(220, 31);
            this.dirBrowerBtn.TabIndex = 0;
            this.dirBrowerBtn.Text = "Browser...";
            this.dirBrowerBtn.UseVisualStyleBackColor = true;
            this.dirBrowerBtn.Click += new System.EventHandler(this.dirBrowser);
            // 
            // label_cur_frame
            // 
            this.label_cur_frame.Location = new System.Drawing.Point(13, 43);
            this.label_cur_frame.Name = "label_cur_frame";
            this.label_cur_frame.Size = new System.Drawing.Size(56, 23);
            this.label_cur_frame.TabIndex = 3;
            this.label_cur_frame.Text = "X :";
            this.label_cur_frame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectory.Location = new System.Drawing.Point(12, 11);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(606, 26);
            this.txtDirectory.TabIndex = 4;
            this.txtDirectory.Text = "Select the Directory";
            // 
            // executeButton
            // 
            this.executeButton.Enabled = false;
            this.executeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeButton.Location = new System.Drawing.Point(636, 356);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(220, 31);
            this.executeButton.TabIndex = 0;
            this.executeButton.Text = "Start";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.Start_Finder);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Y :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.sSquare);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(636, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 228);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geometry";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.startX);
            this.groupBox2.Controls.Add(this.startY);
            this.groupBox2.Controls.Add(this.label_cur_frame);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 126);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Center of Squre ";
            // 
            // startX
            // 
            this.startX.Location = new System.Drawing.Point(81, 40);
            this.startX.Name = "startX";
            this.startX.Size = new System.Drawing.Size(100, 26);
            this.startX.TabIndex = 4;
            this.startX.Text = "0";
            this.startX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkValidInput);
            // 
            // startY
            // 
            this.startY.Location = new System.Drawing.Point(81, 82);
            this.startY.Name = "startY";
            this.startY.Size = new System.Drawing.Size(100, 26);
            this.startY.TabIndex = 4;
            this.startY.Text = "0";
            this.startY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkValidInput);
            // 
            // sSquare
            // 
            this.sSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSquare.Location = new System.Drawing.Point(93, 181);
            this.sSquare.Name = "sSquare";
            this.sSquare.Size = new System.Drawing.Size(100, 26);
            this.sSquare.TabIndex = 4;
            this.sSquare.Text = "100";
            this.sSquare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkValidInput);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Size :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.zAxis);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(636, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 87);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // zAxis
            // 
            this.zAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zAxis.Location = new System.Drawing.Point(93, 39);
            this.zAxis.Name = "zAxis";
            this.zAxis.Size = new System.Drawing.Size(100, 26);
            this.zAxis.TabIndex = 4;
            this.zAxis.Text = "0";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Z axis :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.flowLayoutPanelMain);
            this.panelMain.Location = new System.Drawing.Point(12, 49);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(606, 451);
            this.panelMain.TabIndex = 7;
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(606, 451);
            this.flowLayoutPanelMain.TabIndex = 0;
            // 
            // trackBarSize
            // 
            this.trackBarSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSize.AutoSize = false;
            this.trackBarSize.LargeChange = 1;
            this.trackBarSize.Location = new System.Drawing.Point(633, 56);
            this.trackBarSize.Maximum = 2;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(220, 23);
            this.trackBarSize.TabIndex = 6;
            this.trackBarSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSize.Value = 1;
            this.trackBarSize.ValueChanged += new System.EventHandler(this.trackBarSize_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 509);
            this.Controls.Add(this.trackBarSize);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.groupBox3);
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
        private System.Windows.Forms.TextBox sSquare;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox zAxis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TrackBar trackBarSize;
        private ThumbnailFlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

