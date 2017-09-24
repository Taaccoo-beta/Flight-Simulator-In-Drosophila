namespace FlightSimulator
{
    partial class PortDection
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
            this.gbDigitOutput_1 = new System.Windows.Forms.GroupBox();
            this.cbHighOrLow = new System.Windows.Forms.CheckBox();
            this.tbPortNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSeedByChoose = new System.Windows.Forms.Button();
            this.gbAnalogOutput = new System.Windows.Forms.GroupBox();
            this.btnTorqueBias = new System.Windows.Forms.Button();
            this.btnRotatinBias = new System.Windows.Forms.Button();
            this.tbTroqueBias = new System.Windows.Forms.TextBox();
            this.tbPrtatingBias = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbDigitalOutput = new System.Windows.Forms.GroupBox();
            this.cbRotatingBias = new System.Windows.Forms.CheckBox();
            this.cbCloseOpen = new System.Windows.Forms.CheckBox();
            this.cbIntergrator = new System.Windows.Forms.CheckBox();
            this.cbHeat = new System.Windows.Forms.CheckBox();
            this.cbShutter = new System.Windows.Forms.CheckBox();
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
            this.gbInputDetection = new System.Windows.Forms.GroupBox();
            this.lblTachoVoltageValue = new System.Windows.Forms.Label();
            this.lblTorqueVoltageValue = new System.Windows.Forms.Label();
            this.lblPositionVoltageValue = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Button();
            this.lblTacho = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTorque = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbDigitOutput_1.SuspendLayout();
            this.gbAnalogOutput.SuspendLayout();
            this.gbDigitalOutput.SuspendLayout();
            this.gbInputDetection.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDigitOutput_1
            // 
            this.gbDigitOutput_1.Controls.Add(this.cbHighOrLow);
            this.gbDigitOutput_1.Controls.Add(this.tbPortNumber);
            this.gbDigitOutput_1.Controls.Add(this.label11);
            this.gbDigitOutput_1.Controls.Add(this.btnSeedByChoose);
            this.gbDigitOutput_1.Location = new System.Drawing.Point(47, 661);
            this.gbDigitOutput_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbDigitOutput_1.Name = "gbDigitOutput_1";
            this.gbDigitOutput_1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbDigitOutput_1.Size = new System.Drawing.Size(621, 77);
            this.gbDigitOutput_1.TabIndex = 14;
            this.gbDigitOutput_1.TabStop = false;
            this.gbDigitOutput_1.Text = "DigitOutput";
            // 
            // cbHighOrLow
            // 
            this.cbHighOrLow.AutoSize = true;
            this.cbHighOrLow.Location = new System.Drawing.Point(300, 36);
            this.cbHighOrLow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbHighOrLow.Name = "cbHighOrLow";
            this.cbHighOrLow.Size = new System.Drawing.Size(61, 19);
            this.cbHighOrLow.TabIndex = 20;
            this.cbHighOrLow.Text = "High";
            this.cbHighOrLow.UseVisualStyleBackColor = true;
            // 
            // tbPortNumber
            // 
            this.tbPortNumber.Location = new System.Drawing.Point(217, 33);
            this.tbPortNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPortNumber.Name = "tbPortNumber";
            this.tbPortNumber.Size = new System.Drawing.Size(61, 25);
            this.tbPortNumber.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "DigitPortNumber:";
            // 
            // btnSeedByChoose
            // 
            this.btnSeedByChoose.Location = new System.Drawing.Point(407, 35);
            this.btnSeedByChoose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSeedByChoose.Name = "btnSeedByChoose";
            this.btnSeedByChoose.Size = new System.Drawing.Size(132, 23);
            this.btnSeedByChoose.TabIndex = 17;
            this.btnSeedByChoose.Text = "Send";
            this.btnSeedByChoose.UseVisualStyleBackColor = true;
            this.btnSeedByChoose.Click += new System.EventHandler(this.btnSeedByChoose_Click);
            // 
            // gbAnalogOutput
            // 
            this.gbAnalogOutput.Controls.Add(this.btnTorqueBias);
            this.gbAnalogOutput.Controls.Add(this.btnRotatinBias);
            this.gbAnalogOutput.Controls.Add(this.tbTroqueBias);
            this.gbAnalogOutput.Controls.Add(this.tbPrtatingBias);
            this.gbAnalogOutput.Controls.Add(this.label10);
            this.gbAnalogOutput.Controls.Add(this.label9);
            this.gbAnalogOutput.Location = new System.Drawing.Point(47, 202);
            this.gbAnalogOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbAnalogOutput.Name = "gbAnalogOutput";
            this.gbAnalogOutput.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbAnalogOutput.Size = new System.Drawing.Size(621, 170);
            this.gbAnalogOutput.TabIndex = 13;
            this.gbAnalogOutput.TabStop = false;
            this.gbAnalogOutput.Text = "AnalogOutput";
            // 
            // btnTorqueBias
            // 
            this.btnTorqueBias.Location = new System.Drawing.Point(407, 108);
            this.btnTorqueBias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTorqueBias.Name = "btnTorqueBias";
            this.btnTorqueBias.Size = new System.Drawing.Size(132, 23);
            this.btnTorqueBias.TabIndex = 12;
            this.btnTorqueBias.Text = "Send";
            this.btnTorqueBias.UseVisualStyleBackColor = true;
            this.btnTorqueBias.Click += new System.EventHandler(this.btnTorqueBias_Click);
            // 
            // btnRotatinBias
            // 
            this.btnRotatinBias.Location = new System.Drawing.Point(407, 60);
            this.btnRotatinBias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRotatinBias.Name = "btnRotatinBias";
            this.btnRotatinBias.Size = new System.Drawing.Size(132, 23);
            this.btnRotatinBias.TabIndex = 11;
            this.btnRotatinBias.Text = "Send";
            this.btnRotatinBias.UseVisualStyleBackColor = true;
            this.btnRotatinBias.Click += new System.EventHandler(this.btnRotatinBias_Click);
            // 
            // tbTroqueBias
            // 
            this.tbTroqueBias.Location = new System.Drawing.Point(231, 108);
            this.tbTroqueBias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTroqueBias.Name = "tbTroqueBias";
            this.tbTroqueBias.Size = new System.Drawing.Size(132, 25);
            this.tbTroqueBias.TabIndex = 8;
            // 
            // tbPrtatingBias
            // 
            this.tbPrtatingBias.Location = new System.Drawing.Point(231, 60);
            this.tbPrtatingBias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPrtatingBias.Name = "tbPrtatingBias";
            this.tbPrtatingBias.Size = new System.Drawing.Size(132, 25);
            this.tbPrtatingBias.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Torque Bias:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Rotating Bias:";
            // 
            // gbDigitalOutput
            // 
            this.gbDigitalOutput.Controls.Add(this.cbRotatingBias);
            this.gbDigitalOutput.Controls.Add(this.cbCloseOpen);
            this.gbDigitalOutput.Controls.Add(this.cbIntergrator);
            this.gbDigitalOutput.Controls.Add(this.cbHeat);
            this.gbDigitalOutput.Controls.Add(this.cbShutter);
            this.gbDigitalOutput.Controls.Add(this.btnSeedRotating);
            this.gbDigitalOutput.Controls.Add(this.btnSendClosed);
            this.gbDigitalOutput.Controls.Add(this.btnSendIntergrator);
            this.gbDigitalOutput.Controls.Add(this.btnSendHeat);
            this.gbDigitalOutput.Controls.Add(this.btnSendShutter);
            this.gbDigitalOutput.Controls.Add(this.label8);
            this.gbDigitalOutput.Controls.Add(this.label7);
            this.gbDigitalOutput.Controls.Add(this.label6);
            this.gbDigitalOutput.Controls.Add(this.label4);
            this.gbDigitalOutput.Controls.Add(this.label2);
            this.gbDigitalOutput.Location = new System.Drawing.Point(47, 378);
            this.gbDigitalOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbDigitalOutput.Name = "gbDigitalOutput";
            this.gbDigitalOutput.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbDigitalOutput.Size = new System.Drawing.Size(621, 247);
            this.gbDigitalOutput.TabIndex = 12;
            this.gbDigitalOutput.TabStop = false;
            this.gbDigitalOutput.Text = "DigitalOutput";
            // 
            // cbRotatingBias
            // 
            this.cbRotatingBias.AutoSize = true;
            this.cbRotatingBias.Location = new System.Drawing.Point(231, 201);
            this.cbRotatingBias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbRotatingBias.Name = "cbRotatingBias";
            this.cbRotatingBias.Size = new System.Drawing.Size(61, 19);
            this.cbRotatingBias.TabIndex = 19;
            this.cbRotatingBias.Text = "High";
            this.cbRotatingBias.UseVisualStyleBackColor = true;
            // 
            // cbCloseOpen
            // 
            this.cbCloseOpen.AutoSize = true;
            this.cbCloseOpen.Location = new System.Drawing.Point(231, 160);
            this.cbCloseOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCloseOpen.Name = "cbCloseOpen";
            this.cbCloseOpen.Size = new System.Drawing.Size(61, 19);
            this.cbCloseOpen.TabIndex = 18;
            this.cbCloseOpen.Text = "High";
            this.cbCloseOpen.UseVisualStyleBackColor = true;
            // 
            // cbIntergrator
            // 
            this.cbIntergrator.AutoSize = true;
            this.cbIntergrator.Location = new System.Drawing.Point(231, 125);
            this.cbIntergrator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbIntergrator.Name = "cbIntergrator";
            this.cbIntergrator.Size = new System.Drawing.Size(61, 19);
            this.cbIntergrator.TabIndex = 17;
            this.cbIntergrator.Text = "High";
            this.cbIntergrator.UseVisualStyleBackColor = true;
            // 
            // cbHeat
            // 
            this.cbHeat.AutoSize = true;
            this.cbHeat.Location = new System.Drawing.Point(231, 90);
            this.cbHeat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbHeat.Name = "cbHeat";
            this.cbHeat.Size = new System.Drawing.Size(61, 19);
            this.cbHeat.TabIndex = 16;
            this.cbHeat.Text = "High";
            this.cbHeat.UseVisualStyleBackColor = true;
            // 
            // cbShutter
            // 
            this.cbShutter.AutoSize = true;
            this.cbShutter.Location = new System.Drawing.Point(231, 51);
            this.cbShutter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbShutter.Name = "cbShutter";
            this.cbShutter.Size = new System.Drawing.Size(61, 19);
            this.cbShutter.TabIndex = 15;
            this.cbShutter.Text = "High";
            this.cbShutter.UseVisualStyleBackColor = true;
            // 
            // btnSeedRotating
            // 
            this.btnSeedRotating.Location = new System.Drawing.Point(407, 197);
            this.btnSeedRotating.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSeedRotating.Name = "btnSeedRotating";
            this.btnSeedRotating.Size = new System.Drawing.Size(132, 23);
            this.btnSeedRotating.TabIndex = 14;
            this.btnSeedRotating.Text = "Send";
            this.btnSeedRotating.UseVisualStyleBackColor = true;
            this.btnSeedRotating.Click += new System.EventHandler(this.btnSeedRotating_Click);
            // 
            // btnSendClosed
            // 
            this.btnSendClosed.Location = new System.Drawing.Point(407, 157);
            this.btnSendClosed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSendClosed.Name = "btnSendClosed";
            this.btnSendClosed.Size = new System.Drawing.Size(132, 23);
            this.btnSendClosed.TabIndex = 13;
            this.btnSendClosed.Text = "Send";
            this.btnSendClosed.UseVisualStyleBackColor = true;
            this.btnSendClosed.Click += new System.EventHandler(this.btnSendClosed_Click);
            // 
            // btnSendIntergrator
            // 
            this.btnSendIntergrator.Location = new System.Drawing.Point(407, 121);
            this.btnSendIntergrator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSendIntergrator.Name = "btnSendIntergrator";
            this.btnSendIntergrator.Size = new System.Drawing.Size(132, 23);
            this.btnSendIntergrator.TabIndex = 12;
            this.btnSendIntergrator.Text = "Send";
            this.btnSendIntergrator.UseVisualStyleBackColor = true;
            this.btnSendIntergrator.Click += new System.EventHandler(this.btnSendIntergrator_Click);
            // 
            // btnSendHeat
            // 
            this.btnSendHeat.Location = new System.Drawing.Point(407, 87);
            this.btnSendHeat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSendHeat.Name = "btnSendHeat";
            this.btnSendHeat.Size = new System.Drawing.Size(132, 23);
            this.btnSendHeat.TabIndex = 11;
            this.btnSendHeat.Text = "Send";
            this.btnSendHeat.UseVisualStyleBackColor = true;
            this.btnSendHeat.Click += new System.EventHandler(this.btnSendHeat_Click);
            // 
            // btnSendShutter
            // 
            this.btnSendShutter.Location = new System.Drawing.Point(407, 51);
            this.btnSendShutter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSendShutter.Name = "btnSendShutter";
            this.btnSendShutter.Size = new System.Drawing.Size(132, 23);
            this.btnSendShutter.TabIndex = 10;
            this.btnSendShutter.Text = "Send";
            this.btnSendShutter.UseVisualStyleBackColor = true;
            this.btnSendShutter.Click += new System.EventHandler(this.btnSendShutter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Rotating Bias";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Close/Open";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Intergrator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Heat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Shutter";
            // 
            // gbInputDetection
            // 
            this.gbInputDetection.Controls.Add(this.lblTachoVoltageValue);
            this.gbInputDetection.Controls.Add(this.lblTorqueVoltageValue);
            this.gbInputDetection.Controls.Add(this.lblPositionVoltageValue);
            this.gbInputDetection.Controls.Add(this.lblStart);
            this.gbInputDetection.Controls.Add(this.lblTacho);
            this.gbInputDetection.Controls.Add(this.label5);
            this.gbInputDetection.Controls.Add(this.lblTorque);
            this.gbInputDetection.Controls.Add(this.label3);
            this.gbInputDetection.Controls.Add(this.lblPosition);
            this.gbInputDetection.Controls.Add(this.label1);
            this.gbInputDetection.Location = new System.Drawing.Point(47, 14);
            this.gbInputDetection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInputDetection.Name = "gbInputDetection";
            this.gbInputDetection.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInputDetection.Size = new System.Drawing.Size(621, 181);
            this.gbInputDetection.TabIndex = 11;
            this.gbInputDetection.TabStop = false;
            this.gbInputDetection.Text = "InputDetection";
            // 
            // lblTachoVoltageValue
            // 
            this.lblTachoVoltageValue.AutoSize = true;
            this.lblTachoVoltageValue.Location = new System.Drawing.Point(284, 126);
            this.lblTachoVoltageValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTachoVoltageValue.Name = "lblTachoVoltageValue";
            this.lblTachoVoltageValue.Size = new System.Drawing.Size(39, 15);
            this.lblTachoVoltageValue.TabIndex = 9;
            this.lblTachoVoltageValue.Text = "NULL";
            // 
            // lblTorqueVoltageValue
            // 
            this.lblTorqueVoltageValue.AutoSize = true;
            this.lblTorqueVoltageValue.Location = new System.Drawing.Point(284, 84);
            this.lblTorqueVoltageValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTorqueVoltageValue.Name = "lblTorqueVoltageValue";
            this.lblTorqueVoltageValue.Size = new System.Drawing.Size(39, 15);
            this.lblTorqueVoltageValue.TabIndex = 8;
            this.lblTorqueVoltageValue.Text = "NULL";
            // 
            // lblPositionVoltageValue
            // 
            this.lblPositionVoltageValue.AutoSize = true;
            this.lblPositionVoltageValue.Location = new System.Drawing.Point(284, 47);
            this.lblPositionVoltageValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPositionVoltageValue.Name = "lblPositionVoltageValue";
            this.lblPositionVoltageValue.Size = new System.Drawing.Size(39, 15);
            this.lblPositionVoltageValue.TabIndex = 7;
            this.lblPositionVoltageValue.Text = "NULL";
            // 
            // lblStart
            // 
            this.lblStart.Location = new System.Drawing.Point(407, 73);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(132, 38);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Start";
            this.lblStart.UseVisualStyleBackColor = true;
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // lblTacho
            // 
            this.lblTacho.AutoSize = true;
            this.lblTacho.Location = new System.Drawing.Point(205, 126);
            this.lblTacho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTacho.Name = "lblTacho";
            this.lblTacho.Size = new System.Drawing.Size(39, 15);
            this.lblTacho.TabIndex = 5;
            this.lblTacho.Text = "NULL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tacho:";
            // 
            // lblTorque
            // 
            this.lblTorque.AutoSize = true;
            this.lblTorque.Location = new System.Drawing.Point(205, 84);
            this.lblTorque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTorque.Name = "lblTorque";
            this.lblTorque.Size = new System.Drawing.Size(39, 15);
            this.lblTorque.TabIndex = 3;
            this.lblTorque.Text = "NULL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Torque:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(205, 47);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(39, 15);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "NULL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PortDection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 752);
            this.Controls.Add(this.gbDigitOutput_1);
            this.Controls.Add(this.gbAnalogOutput);
            this.Controls.Add(this.gbDigitalOutput);
            this.Controls.Add(this.gbInputDetection);
            this.Name = "PortDection";
            this.Text = "PortDection";
            this.Load += new System.EventHandler(this.PortDection_Load);
            this.gbDigitOutput_1.ResumeLayout(false);
            this.gbDigitOutput_1.PerformLayout();
            this.gbAnalogOutput.ResumeLayout(false);
            this.gbAnalogOutput.PerformLayout();
            this.gbDigitalOutput.ResumeLayout(false);
            this.gbDigitalOutput.PerformLayout();
            this.gbInputDetection.ResumeLayout(false);
            this.gbInputDetection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDigitOutput_1;
        private System.Windows.Forms.CheckBox cbHighOrLow;
        private System.Windows.Forms.TextBox tbPortNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSeedByChoose;
        private System.Windows.Forms.GroupBox gbAnalogOutput;
        private System.Windows.Forms.Button btnTorqueBias;
        private System.Windows.Forms.Button btnRotatinBias;
        private System.Windows.Forms.TextBox tbTroqueBias;
        private System.Windows.Forms.TextBox tbPrtatingBias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbDigitalOutput;
        private System.Windows.Forms.CheckBox cbRotatingBias;
        private System.Windows.Forms.CheckBox cbCloseOpen;
        private System.Windows.Forms.CheckBox cbIntergrator;
        private System.Windows.Forms.CheckBox cbHeat;
        private System.Windows.Forms.CheckBox cbShutter;
        private System.Windows.Forms.Button btnSeedRotating;
        private System.Windows.Forms.Button btnSendClosed;
        private System.Windows.Forms.Button btnSendIntergrator;
        private System.Windows.Forms.Button btnSendHeat;
        private System.Windows.Forms.Button btnSendShutter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbInputDetection;
        private System.Windows.Forms.Label lblTachoVoltageValue;
        private System.Windows.Forms.Label lblTorqueVoltageValue;
        private System.Windows.Forms.Label lblPositionVoltageValue;
        private System.Windows.Forms.Button lblStart;
        private System.Windows.Forms.Label lblTacho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTorque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}