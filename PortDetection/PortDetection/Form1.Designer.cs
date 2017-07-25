namespace PortDetection
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTorque = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTacho = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSendShutter = new System.Windows.Forms.Button();
            this.btnSendHeat = new System.Windows.Forms.Button();
            this.btnSendIntergrator = new System.Windows.Forms.Button();
            this.btnSendClosed = new System.Windows.Forms.Button();
            this.btnSeedRotating = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPrtatingBias = new System.Windows.Forms.TextBox();
            this.tbTroqueBias = new System.Windows.Forms.TextBox();
            this.btnRotatinBias = new System.Windows.Forms.Button();
            this.btnTorqueBias = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(154, 41);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(35, 13);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "NULL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.lblTacho);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTorque);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblPosition);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "InputDetection";
            // 
            // lblTorque
            // 
            this.lblTorque.AutoSize = true;
            this.lblTorque.Location = new System.Drawing.Point(154, 73);
            this.lblTorque.Name = "lblTorque";
            this.lblTorque.Size = new System.Drawing.Size(35, 13);
            this.lblTorque.TabIndex = 3;
            this.lblTorque.Text = "NULL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Torque:";
            // 
            // lblTacho
            // 
            this.lblTacho.AutoSize = true;
            this.lblTacho.Location = new System.Drawing.Point(154, 109);
            this.lblTacho.Name = "lblTacho";
            this.lblTacho.Size = new System.Drawing.Size(35, 13);
            this.lblTacho.TabIndex = 5;
            this.lblTacho.Text = "NULL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tacho:";
            // 
            // lblStart
            // 
            this.lblStart.Location = new System.Drawing.Point(305, 63);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(99, 33);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Start";
            this.lblStart.UseVisualStyleBackColor = true;
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.btnSeedRotating);
            this.groupBox2.Controls.Add(this.btnSendClosed);
            this.groupBox2.Controls.Add(this.btnSendIntergrator);
            this.groupBox2.Controls.Add(this.btnSendHeat);
            this.groupBox2.Controls.Add(this.btnSendShutter);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(44, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 214);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DigitalOutputDetection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Shutter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Heat";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Intergrator";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Close/Open";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Rotating Bias";
            // 
            // btnSendShutter
            // 
            this.btnSendShutter.Location = new System.Drawing.Point(305, 44);
            this.btnSendShutter.Name = "btnSendShutter";
            this.btnSendShutter.Size = new System.Drawing.Size(99, 20);
            this.btnSendShutter.TabIndex = 10;
            this.btnSendShutter.Text = "Send";
            this.btnSendShutter.UseVisualStyleBackColor = true;
            this.btnSendShutter.Click += new System.EventHandler(this.btnSendShutter_Click);
            // 
            // btnSendHeat
            // 
            this.btnSendHeat.Location = new System.Drawing.Point(305, 75);
            this.btnSendHeat.Name = "btnSendHeat";
            this.btnSendHeat.Size = new System.Drawing.Size(99, 20);
            this.btnSendHeat.TabIndex = 11;
            this.btnSendHeat.Text = "Send";
            this.btnSendHeat.UseVisualStyleBackColor = true;
            this.btnSendHeat.Click += new System.EventHandler(this.btnSendHeat_Click);
            // 
            // btnSendIntergrator
            // 
            this.btnSendIntergrator.Location = new System.Drawing.Point(305, 105);
            this.btnSendIntergrator.Name = "btnSendIntergrator";
            this.btnSendIntergrator.Size = new System.Drawing.Size(99, 20);
            this.btnSendIntergrator.TabIndex = 12;
            this.btnSendIntergrator.Text = "Send";
            this.btnSendIntergrator.UseVisualStyleBackColor = true;
            this.btnSendIntergrator.Click += new System.EventHandler(this.btnSendIntergrator_Click);
            // 
            // btnSendClosed
            // 
            this.btnSendClosed.Location = new System.Drawing.Point(305, 136);
            this.btnSendClosed.Name = "btnSendClosed";
            this.btnSendClosed.Size = new System.Drawing.Size(99, 20);
            this.btnSendClosed.TabIndex = 13;
            this.btnSendClosed.Text = "Send";
            this.btnSendClosed.UseVisualStyleBackColor = true;
            this.btnSendClosed.Click += new System.EventHandler(this.btnSendClosed_Click);
            // 
            // btnSeedRotating
            // 
            this.btnSeedRotating.Location = new System.Drawing.Point(305, 171);
            this.btnSeedRotating.Name = "btnSeedRotating";
            this.btnSeedRotating.Size = new System.Drawing.Size(99, 20);
            this.btnSeedRotating.TabIndex = 14;
            this.btnSeedRotating.Text = "Send";
            this.btnSeedRotating.UseVisualStyleBackColor = true;
            this.btnSeedRotating.Click += new System.EventHandler(this.btnSeedRotating_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(191, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "High";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(191, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "High";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(191, 108);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 17);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "High";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(191, 139);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 17);
            this.radioButton4.TabIndex = 18;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "High";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(191, 169);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(47, 17);
            this.radioButton5.TabIndex = 19;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "High";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTorqueBias);
            this.groupBox3.Controls.Add(this.btnRotatinBias);
            this.groupBox3.Controls.Add(this.tbTroqueBias);
            this.groupBox3.Controls.Add(this.tbPrtatingBias);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(44, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 147);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AnalogOutputDetection";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Rotating Bias:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Torque Bias:";
            // 
            // tbPrtatingBias
            // 
            this.tbPrtatingBias.Location = new System.Drawing.Point(173, 52);
            this.tbPrtatingBias.Name = "tbPrtatingBias";
            this.tbPrtatingBias.Size = new System.Drawing.Size(100, 20);
            this.tbPrtatingBias.TabIndex = 7;
            // 
            // tbTroqueBias
            // 
            this.tbTroqueBias.Location = new System.Drawing.Point(173, 94);
            this.tbTroqueBias.Name = "tbTroqueBias";
            this.tbTroqueBias.Size = new System.Drawing.Size(100, 20);
            this.tbTroqueBias.TabIndex = 8;
            // 
            // btnRotatinBias
            // 
            this.btnRotatinBias.Location = new System.Drawing.Point(305, 52);
            this.btnRotatinBias.Name = "btnRotatinBias";
            this.btnRotatinBias.Size = new System.Drawing.Size(99, 20);
            this.btnRotatinBias.TabIndex = 11;
            this.btnRotatinBias.Text = "Send";
            this.btnRotatinBias.UseVisualStyleBackColor = true;
            this.btnRotatinBias.Click += new System.EventHandler(this.btnRotatinBias_Click);
            // 
            // btnTorqueBias
            // 
            this.btnTorqueBias.Location = new System.Drawing.Point(305, 94);
            this.btnTorqueBias.Name = "btnTorqueBias";
            this.btnTorqueBias.Size = new System.Drawing.Size(99, 20);
            this.btnTorqueBias.TabIndex = 12;
            this.btnTorqueBias.Text = "Send";
            this.btnTorqueBias.UseVisualStyleBackColor = true;
            this.btnTorqueBias.Click += new System.EventHandler(this.btnTorqueBias_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 595);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PortDetection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button lblStart;
        private System.Windows.Forms.Label lblTacho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTorque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeedRotating;
        private System.Windows.Forms.Button btnSendClosed;
        private System.Windows.Forms.Button btnSendIntergrator;
        private System.Windows.Forms.Button btnSendHeat;
        private System.Windows.Forms.Button btnSendShutter;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTorqueBias;
        private System.Windows.Forms.Button btnRotatinBias;
        private System.Windows.Forms.TextBox tbTroqueBias;
        private System.Windows.Forms.TextBox tbPrtatingBias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

