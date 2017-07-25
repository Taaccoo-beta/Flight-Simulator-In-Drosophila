namespace rorationSimulation
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblShowLocation = new System.Windows.Forms.Label();
            this.lblTorque = new System.Windows.Forms.Label();
            this.lblShowTorque = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 314);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(138, 454);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(56, 26);
            this.btnDraw.TabIndex = 7;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(24, 454);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(56, 26);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(252, 454);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(56, 26);
            this.btnRight.TabIndex = 9;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 654);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Right";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(60, 365);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "Location";
            // 
            // lblShowLocation
            // 
            this.lblShowLocation.AutoSize = true;
            this.lblShowLocation.Location = new System.Drawing.Point(135, 365);
            this.lblShowLocation.Name = "lblShowLocation";
            this.lblShowLocation.Size = new System.Drawing.Size(35, 13);
            this.lblShowLocation.TabIndex = 12;
            this.lblShowLocation.Text = "NULL";
            // 
            // lblTorque
            // 
            this.lblTorque.AutoSize = true;
            this.lblTorque.Location = new System.Drawing.Point(67, 393);
            this.lblTorque.Name = "lblTorque";
            this.lblTorque.Size = new System.Drawing.Size(41, 13);
            this.lblTorque.TabIndex = 13;
            this.lblTorque.Text = "Torque";
            // 
            // lblShowTorque
            // 
            this.lblShowTorque.AutoSize = true;
            this.lblShowTorque.Location = new System.Drawing.Point(135, 393);
            this.lblShowTorque.Name = "lblShowTorque";
            this.lblShowTorque.Size = new System.Drawing.Size(35, 13);
            this.lblShowTorque.TabIndex = 14;
            this.lblShowTorque.Text = "NULL";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1123, 777);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblShowTorque);
            this.Controls.Add(this.lblTorque);
            this.Controls.Add(this.lblShowLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblShowLocation;
        private System.Windows.Forms.Label lblTorque;
        private System.Windows.Forms.Label lblShowTorque;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

