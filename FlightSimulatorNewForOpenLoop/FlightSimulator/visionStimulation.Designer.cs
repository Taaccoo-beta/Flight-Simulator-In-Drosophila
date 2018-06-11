namespace FlightSimulator
{
    partial class visionStimulation
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShowHeight = new System.Windows.Forms.Label();
            this.lblShowWidth = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSpeedValue = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.Set = new System.Windows.Forms.Button();
            this.tbnBarWidth = new System.Windows.Forms.Button();
            this.tbBarValue = new System.Windows.Forms.TextBox();
            this.lblBarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1244, 329);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(772, 383);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width:";
            // 
            // lblShowHeight
            // 
            this.lblShowHeight.AutoSize = true;
            this.lblShowHeight.Location = new System.Drawing.Point(573, 383);
            this.lblShowHeight.Name = "lblShowHeight";
            this.lblShowHeight.Size = new System.Drawing.Size(39, 15);
            this.lblShowHeight.TabIndex = 5;
            this.lblShowHeight.Text = "NULL";
            // 
            // lblShowWidth
            // 
            this.lblShowWidth.AutoSize = true;
            this.lblShowWidth.Location = new System.Drawing.Point(573, 348);
            this.lblShowWidth.Name = "lblShowWidth";
            this.lblShowWidth.Size = new System.Drawing.Size(39, 15);
            this.lblShowWidth.TabIndex = 4;
            this.lblShowWidth.Text = "NULL";
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(772, 344);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(853, 344);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "NULL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Speed";
            // 
            // tbSpeedValue
            // 
            this.tbSpeedValue.Location = new System.Drawing.Point(314, 384);
            this.tbSpeedValue.Name = "tbSpeedValue";
            this.tbSpeedValue.Size = new System.Drawing.Size(100, 25);
            this.tbSpeedValue.TabIndex = 10;
            this.tbSpeedValue.Text = "10";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(853, 383);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Set
            // 
            this.Set.Location = new System.Drawing.Point(420, 386);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(55, 23);
            this.Set.TabIndex = 12;
            this.Set.Text = "Set";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // tbnBarWidth
            // 
            this.tbnBarWidth.Location = new System.Drawing.Point(210, 385);
            this.tbnBarWidth.Name = "tbnBarWidth";
            this.tbnBarWidth.Size = new System.Drawing.Size(55, 23);
            this.tbnBarWidth.TabIndex = 15;
            this.tbnBarWidth.Text = "Set";
            this.tbnBarWidth.UseVisualStyleBackColor = true;
            // 
            // tbBarValue
            // 
            this.tbBarValue.Location = new System.Drawing.Point(104, 383);
            this.tbBarValue.Name = "tbBarValue";
            this.tbBarValue.Size = new System.Drawing.Size(100, 25);
            this.tbBarValue.TabIndex = 14;
            this.tbBarValue.Text = "10";
            // 
            // lblBarLabel
            // 
            this.lblBarLabel.AutoSize = true;
            this.lblBarLabel.Location = new System.Drawing.Point(101, 351);
            this.lblBarLabel.Name = "lblBarLabel";
            this.lblBarLabel.Size = new System.Drawing.Size(71, 15);
            this.lblBarLabel.TabIndex = 13;
            this.lblBarLabel.Text = "BarWidth";
            // 
            // visionStimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 474);
            this.Controls.Add(this.tbnBarWidth);
            this.Controls.Add(this.tbBarValue);
            this.Controls.Add(this.lblBarLabel);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tbSpeedValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.lblShowHeight);
            this.Controls.Add(this.lblShowWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pictureBox1);
            this.Name = "visionStimulation";
            this.Text = "visionStimulation";
            this.Load += new System.EventHandler(this.visionStimulation_Load);
            this.ResizeEnd += new System.EventHandler(this.visionStimulation_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.visionStimulation_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShowHeight;
        private System.Windows.Forms.Label lblShowWidth;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSpeedValue;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.Button tbnBarWidth;
        private System.Windows.Forms.TextBox tbBarValue;
        private System.Windows.Forms.Label lblBarLabel;
    }
}