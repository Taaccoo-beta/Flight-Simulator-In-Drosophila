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
            this.lblStart = new System.Windows.Forms.Button();
            this.lblTacho = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTorque = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.btnSeedRotating = new System.Windows.Forms.Button();
            this.btnSendClosed = new System.Windows.Forms.Button();
            this.btnSendIntergrator = new System.Windows.Forms.Button();
            this.btnSendHeat = new System.Windows.Forms.Button();
            this.btnSendShutter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTorqueBias = new System.Windows.Forms.Button();
            this.btnRotatinBias = new System.Windows.Forms.Button();
            this.tbTroqueBias = new System.Windows.Forms.TextBox();
            this.tbPrtatingBias = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DigitOutPut = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.tbPortNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbIsPosition = new System.Windows.Forms.CheckBox();
            this.cbIsTorque = new System.Windows.Forms.CheckBox();
            this.lblChooseDisplay = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.DigitOutPut.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.cb1);
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
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(173, 174);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(48, 17);
            this.checkBox4.TabIndex = 19;
            this.checkBox4.Text = "High";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(173, 139);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 17);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "High";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(173, 108);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "High";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(173, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "High";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(173, 44);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(48, 17);
            this.cb1.TabIndex = 15;
            this.cb1.Text = "High";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Rotating Bias";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Intergrator";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Shutter";
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
            // tbTroqueBias
            // 
            this.tbTroqueBias.Location = new System.Drawing.Point(173, 94);
            this.tbTroqueBias.Name = "tbTroqueBias";
            this.tbTroqueBias.Size = new System.Drawing.Size(100, 20);
            this.tbTroqueBias.TabIndex = 8;
            // 
            // tbPrtatingBias
            // 
            this.tbPrtatingBias.Location = new System.Drawing.Point(173, 52);
            this.tbPrtatingBias.Name = "tbPrtatingBias";
            this.tbPrtatingBias.Size = new System.Drawing.Size(100, 20);
            this.tbPrtatingBias.TabIndex = 7;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Rotating Bias:";
            // 
            // DigitOutPut
            // 
            this.DigitOutPut.Controls.Add(this.checkBox5);
            this.DigitOutPut.Controls.Add(this.tbPortNumber);
            this.DigitOutPut.Controls.Add(this.label11);
            this.DigitOutPut.Controls.Add(this.button1);
            this.DigitOutPut.Location = new System.Drawing.Point(44, 614);
            this.DigitOutPut.Name = "DigitOutPut";
            this.DigitOutPut.Size = new System.Drawing.Size(466, 67);
            this.DigitOutPut.TabIndex = 10;
            this.DigitOutPut.TabStop = false;
            this.DigitOutPut.Text = "DigitOutput";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(216, 31);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(48, 17);
            this.checkBox5.TabIndex = 20;
            this.checkBox5.Text = "High";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // tbPortNumber
            // 
            this.tbPortNumber.Location = new System.Drawing.Point(142, 29);
            this.tbPortNumber.Name = "tbPortNumber";
            this.tbPortNumber.Size = new System.Drawing.Size(47, 20);
            this.tbPortNumber.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "DigitPortNumber:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 20);
            this.button1.TabIndex = 17;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbIsPosition
            // 
            this.cbIsPosition.AutoSize = true;
            this.cbIsPosition.Checked = true;
            this.cbIsPosition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsPosition.Location = new System.Drawing.Point(673, 502);
            this.cbIsPosition.Name = "cbIsPosition";
            this.cbIsPosition.Size = new System.Drawing.Size(63, 17);
            this.cbIsPosition.TabIndex = 16;
            this.cbIsPosition.Text = "Position";
            this.cbIsPosition.UseVisualStyleBackColor = true;
            this.cbIsPosition.CheckedChanged += new System.EventHandler(this.cbIsPosition_CheckedChanged);
            // 
            // cbIsTorque
            // 
            this.cbIsTorque.AutoSize = true;
            this.cbIsTorque.Checked = true;
            this.cbIsTorque.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsTorque.Location = new System.Drawing.Point(757, 502);
            this.cbIsTorque.Name = "cbIsTorque";
            this.cbIsTorque.Size = new System.Drawing.Size(60, 17);
            this.cbIsTorque.TabIndex = 17;
            this.cbIsTorque.Text = "Torque";
            this.cbIsTorque.UseVisualStyleBackColor = true;
            this.cbIsTorque.CheckedChanged += new System.EventHandler(this.cbIsTorque_CheckedChanged);
            // 
            // lblChooseDisplay
            // 
            this.lblChooseDisplay.AutoSize = true;
            this.lblChooseDisplay.Location = new System.Drawing.Point(574, 503);
            this.lblChooseDisplay.Name = "lblChooseDisplay";
            this.lblChooseDisplay.Size = new System.Drawing.Size(81, 13);
            this.lblChooseDisplay.TabIndex = 18;
            this.lblChooseDisplay.Text = "Choose display:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 733);
            this.Controls.Add(this.lblChooseDisplay);
            this.Controls.Add(this.cbIsTorque);
            this.Controls.Add(this.cbIsPosition);
            this.Controls.Add(this.DigitOutPut);
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
            this.DigitOutPut.ResumeLayout(false);
            this.DigitOutPut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTorqueBias;
        private System.Windows.Forms.Button btnRotatinBias;
        private System.Windows.Forms.TextBox tbTroqueBias;
        private System.Windows.Forms.TextBox tbPrtatingBias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox DigitOutPut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPortNumber;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox cbIsPosition;
        private System.Windows.Forms.CheckBox cbIsTorque;
        private System.Windows.Forms.Label lblChooseDisplay;
    }
}

