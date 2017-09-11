namespace PortDetection
{
    partial class PreSetting
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
            this.lbExpSequence = new System.Windows.Forms.ListBox();
            this.tbLastTime = new System.Windows.Forms.TextBox();
            this.lblTrainOrTest = new System.Windows.Forms.Label();
            this.lblLastTime = new System.Windows.Forms.Label();
            this.rbTrain = new System.Windows.Forms.RadioButton();
            this.rbTest = new System.Windows.Forms.RadioButton();
            this.btnSetSAdd = new System.Windows.Forms.Button();
            this.btnSetSDelete = new System.Windows.Forms.Button();
            this.gbSetSequence = new System.Windows.Forms.GroupBox();
            this.cbSecondOrMinute = new System.Windows.Forms.CheckBox();
            this.gbSetDataPath = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblExName = new System.Windows.Forms.Label();
            this.lblDataPath = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblDPValue = new System.Windows.Forms.Label();
            this.btnChooseDataPath = new System.Windows.Forms.Button();
            this.gbSetName = new System.Windows.Forms.GroupBox();
            this.gbSetPattern = new System.Windows.Forms.GroupBox();
            this.rbDownT = new System.Windows.Forms.RadioButton();
            this.rbUpT = new System.Windows.Forms.RadioButton();
            this.lblWhichToPunishment = new System.Windows.Forms.Label();
            this.gbPunishmentChoose = new System.Windows.Forms.GroupBox();
            this.rbPCShake = new System.Windows.Forms.RadioButton();
            this.rbPCHeat = new System.Windows.Forms.RadioButton();
            this.gbSetSequence.SuspendLayout();
            this.gbSetDataPath.SuspendLayout();
            this.gbSetName.SuspendLayout();
            this.gbSetPattern.SuspendLayout();
            this.gbPunishmentChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbExpSequence
            // 
            this.lbExpSequence.FormattingEnabled = true;
            this.lbExpSequence.ItemHeight = 15;
            this.lbExpSequence.Location = new System.Drawing.Point(21, 188);
            this.lbExpSequence.Name = "lbExpSequence";
            this.lbExpSequence.Size = new System.Drawing.Size(228, 199);
            this.lbExpSequence.TabIndex = 0;
            // 
            // tbLastTime
            // 
            this.tbLastTime.Location = new System.Drawing.Point(149, 87);
            this.tbLastTime.Name = "tbLastTime";
            this.tbLastTime.Size = new System.Drawing.Size(57, 25);
            this.tbLastTime.TabIndex = 2;
            this.tbLastTime.Text = "3";
            // 
            // lblTrainOrTest
            // 
            this.lblTrainOrTest.AutoSize = true;
            this.lblTrainOrTest.Location = new System.Drawing.Point(19, 57);
            this.lblTrainOrTest.Name = "lblTrainOrTest";
            this.lblTrainOrTest.Size = new System.Drawing.Size(95, 15);
            this.lblTrainOrTest.TabIndex = 3;
            this.lblTrainOrTest.Text = "TrainOrTest";
            // 
            // lblLastTime
            // 
            this.lblLastTime.AutoSize = true;
            this.lblLastTime.Location = new System.Drawing.Point(156, 57);
            this.lblLastTime.Name = "lblLastTime";
            this.lblLastTime.Size = new System.Drawing.Size(71, 15);
            this.lblLastTime.TabIndex = 4;
            this.lblLastTime.Text = "LastTime";
            this.lblLastTime.Click += new System.EventHandler(this.lblLastTime_Click);
            // 
            // rbTrain
            // 
            this.rbTrain.AutoSize = true;
            this.rbTrain.Checked = true;
            this.rbTrain.Location = new System.Drawing.Point(21, 87);
            this.rbTrain.Name = "rbTrain";
            this.rbTrain.Size = new System.Drawing.Size(68, 19);
            this.rbTrain.TabIndex = 5;
            this.rbTrain.TabStop = true;
            this.rbTrain.Text = "Train";
            this.rbTrain.UseVisualStyleBackColor = true;
            // 
            // rbTest
            // 
            this.rbTest.AutoSize = true;
            this.rbTest.Location = new System.Drawing.Point(21, 111);
            this.rbTest.Name = "rbTest";
            this.rbTest.Size = new System.Drawing.Size(60, 19);
            this.rbTest.TabIndex = 6;
            this.rbTest.TabStop = true;
            this.rbTest.Text = "Test";
            this.rbTest.UseVisualStyleBackColor = true;
            // 
            // btnSetSAdd
            // 
            this.btnSetSAdd.Location = new System.Drawing.Point(21, 148);
            this.btnSetSAdd.Name = "btnSetSAdd";
            this.btnSetSAdd.Size = new System.Drawing.Size(92, 23);
            this.btnSetSAdd.TabIndex = 7;
            this.btnSetSAdd.Text = "Add";
            this.btnSetSAdd.UseVisualStyleBackColor = true;
            this.btnSetSAdd.Click += new System.EventHandler(this.btnSetSAdd_Click);
            // 
            // btnSetSDelete
            // 
            this.btnSetSDelete.Location = new System.Drawing.Point(149, 148);
            this.btnSetSDelete.Name = "btnSetSDelete";
            this.btnSetSDelete.Size = new System.Drawing.Size(89, 23);
            this.btnSetSDelete.TabIndex = 8;
            this.btnSetSDelete.Text = "Detele";
            this.btnSetSDelete.UseVisualStyleBackColor = true;
            this.btnSetSDelete.Click += new System.EventHandler(this.btnSetSDelete_Click);
            // 
            // gbSetSequence
            // 
            this.gbSetSequence.Controls.Add(this.cbSecondOrMinute);
            this.gbSetSequence.Controls.Add(this.btnSetSDelete);
            this.gbSetSequence.Controls.Add(this.lbExpSequence);
            this.gbSetSequence.Controls.Add(this.btnSetSAdd);
            this.gbSetSequence.Controls.Add(this.tbLastTime);
            this.gbSetSequence.Controls.Add(this.rbTest);
            this.gbSetSequence.Controls.Add(this.lblTrainOrTest);
            this.gbSetSequence.Controls.Add(this.rbTrain);
            this.gbSetSequence.Controls.Add(this.lblLastTime);
            this.gbSetSequence.Location = new System.Drawing.Point(27, 28);
            this.gbSetSequence.Name = "gbSetSequence";
            this.gbSetSequence.Size = new System.Drawing.Size(292, 432);
            this.gbSetSequence.TabIndex = 9;
            this.gbSetSequence.TabStop = false;
            this.gbSetSequence.Text = "Set-Sequence";
            // 
            // cbSecondOrMinute
            // 
            this.cbSecondOrMinute.AutoSize = true;
            this.cbSecondOrMinute.Location = new System.Drawing.Point(212, 89);
            this.cbSecondOrMinute.Name = "cbSecondOrMinute";
            this.cbSecondOrMinute.Size = new System.Drawing.Size(37, 19);
            this.cbSecondOrMinute.TabIndex = 9;
            this.cbSecondOrMinute.Text = "s";
            this.cbSecondOrMinute.UseVisualStyleBackColor = true;
            this.cbSecondOrMinute.CheckedChanged += new System.EventHandler(this.cbTimeOrHour_CheckedChanged);
            // 
            // gbSetDataPath
            // 
            this.gbSetDataPath.Controls.Add(this.btnChooseDataPath);
            this.gbSetDataPath.Controls.Add(this.lblDPValue);
            this.gbSetDataPath.Controls.Add(this.lblDataPath);
            this.gbSetDataPath.Location = new System.Drawing.Point(373, 28);
            this.gbSetDataPath.Name = "gbSetDataPath";
            this.gbSetDataPath.Size = new System.Drawing.Size(300, 130);
            this.gbSetDataPath.TabIndex = 10;
            this.gbSetDataPath.TabStop = false;
            this.gbSetDataPath.Text = "ExInit-SetPath";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 14;
            // 
            // lblExName
            // 
            this.lblExName.AutoSize = true;
            this.lblExName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExName.Location = new System.Drawing.Point(6, 43);
            this.lblExName.Name = "lblExName";
            this.lblExName.Size = new System.Drawing.Size(127, 15);
            this.lblExName.TabIndex = 13;
            this.lblExName.Text = "ExperimentName:";
            // 
            // lblDataPath
            // 
            this.lblDataPath.AutoSize = true;
            this.lblDataPath.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDataPath.Location = new System.Drawing.Point(14, 34);
            this.lblDataPath.Name = "lblDataPath";
            this.lblDataPath.Size = new System.Drawing.Size(79, 15);
            this.lblDataPath.TabIndex = 11;
            this.lblDataPath.Text = "DataPath:";
            // 
            // lblDPValue
            // 
            this.lblDPValue.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDPValue.Location = new System.Drawing.Point(99, 34);
            this.lblDPValue.Name = "lblDPValue";
            this.lblDPValue.Size = new System.Drawing.Size(71, 15);
            this.lblDPValue.TabIndex = 19;
            this.lblDPValue.Text = "DataPath";
            this.lblDPValue.Click += new System.EventHandler(this.lblDPValue_Click);
            // 
            // btnChooseDataPath
            // 
            this.btnChooseDataPath.Location = new System.Drawing.Point(94, 95);
            this.btnChooseDataPath.Name = "btnChooseDataPath";
            this.btnChooseDataPath.Size = new System.Drawing.Size(89, 29);
            this.btnChooseDataPath.TabIndex = 20;
            this.btnChooseDataPath.Text = "Open";
            this.btnChooseDataPath.UseVisualStyleBackColor = true;
            this.btnChooseDataPath.Click += new System.EventHandler(this.btnChooseDataPath_Click);
            // 
            // gbSetName
            // 
            this.gbSetName.Controls.Add(this.textBox2);
            this.gbSetName.Controls.Add(this.lblExName);
            this.gbSetName.Location = new System.Drawing.Point(373, 176);
            this.gbSetName.Name = "gbSetName";
            this.gbSetName.Size = new System.Drawing.Size(300, 91);
            this.gbSetName.TabIndex = 19;
            this.gbSetName.TabStop = false;
            this.gbSetName.Text = "ExInit-SetName";
            // 
            // gbSetPattern
            // 
            this.gbSetPattern.Controls.Add(this.lblWhichToPunishment);
            this.gbSetPattern.Controls.Add(this.rbDownT);
            this.gbSetPattern.Controls.Add(this.rbUpT);
            this.gbSetPattern.Location = new System.Drawing.Point(373, 282);
            this.gbSetPattern.Name = "gbSetPattern";
            this.gbSetPattern.Size = new System.Drawing.Size(300, 82);
            this.gbSetPattern.TabIndex = 20;
            this.gbSetPattern.TabStop = false;
            this.gbSetPattern.Text = "ExInit-SetPattern";
            // 
            // rbDownT
            // 
            this.rbDownT.AutoSize = true;
            this.rbDownT.Location = new System.Drawing.Point(183, 34);
            this.rbDownT.Name = "rbDownT";
            this.rbDownT.Size = new System.Drawing.Size(68, 19);
            this.rbDownT.TabIndex = 8;
            this.rbDownT.TabStop = true;
            this.rbDownT.Text = "DownT";
            this.rbDownT.UseVisualStyleBackColor = true;
            // 
            // rbUpT
            // 
            this.rbUpT.AutoSize = true;
            this.rbUpT.Checked = true;
            this.rbUpT.Location = new System.Drawing.Point(115, 34);
            this.rbUpT.Name = "rbUpT";
            this.rbUpT.Size = new System.Drawing.Size(52, 19);
            this.rbUpT.TabIndex = 7;
            this.rbUpT.TabStop = true;
            this.rbUpT.Text = "UpT";
            this.rbUpT.UseVisualStyleBackColor = true;
            // 
            // lblWhichToPunishment
            // 
            this.lblWhichToPunishment.AutoSize = true;
            this.lblWhichToPunishment.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWhichToPunishment.Location = new System.Drawing.Point(6, 34);
            this.lblWhichToPunishment.Name = "lblWhichToPunishment";
            this.lblWhichToPunishment.Size = new System.Drawing.Size(102, 15);
            this.lblWhichToPunishment.TabIndex = 14;
            this.lblWhichToPunishment.Text = "Punishment：";
            // 
            // gbPunishmentChoose
            // 
            this.gbPunishmentChoose.Controls.Add(this.rbPCShake);
            this.gbPunishmentChoose.Controls.Add(this.rbPCHeat);
            this.gbPunishmentChoose.Location = new System.Drawing.Point(373, 378);
            this.gbPunishmentChoose.Name = "gbPunishmentChoose";
            this.gbPunishmentChoose.Size = new System.Drawing.Size(300, 82);
            this.gbPunishmentChoose.TabIndex = 21;
            this.gbPunishmentChoose.TabStop = false;
            this.gbPunishmentChoose.Text = "ExInit-setPunishment";
            // 
            // rbPCShake
            // 
            this.rbPCShake.AutoSize = true;
            this.rbPCShake.Location = new System.Drawing.Point(151, 36);
            this.rbPCShake.Name = "rbPCShake";
            this.rbPCShake.Size = new System.Drawing.Size(68, 19);
            this.rbPCShake.TabIndex = 8;
            this.rbPCShake.TabStop = true;
            this.rbPCShake.Text = "Shake";
            this.rbPCShake.UseVisualStyleBackColor = true;
            // 
            // rbPCHeat
            // 
            this.rbPCHeat.AutoSize = true;
            this.rbPCHeat.Checked = true;
            this.rbPCHeat.Location = new System.Drawing.Point(66, 36);
            this.rbPCHeat.Name = "rbPCHeat";
            this.rbPCHeat.Size = new System.Drawing.Size(60, 19);
            this.rbPCHeat.TabIndex = 7;
            this.rbPCHeat.TabStop = true;
            this.rbPCHeat.Text = "Heat";
            this.rbPCHeat.UseVisualStyleBackColor = true;
            // 
            // PreSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 498);
            this.Controls.Add(this.gbPunishmentChoose);
            this.Controls.Add(this.gbSetPattern);
            this.Controls.Add(this.gbSetName);
            this.Controls.Add(this.gbSetDataPath);
            this.Controls.Add(this.gbSetSequence);
            this.Name = "PreSetting";
            this.Text = "PreSetting";
            this.gbSetSequence.ResumeLayout(false);
            this.gbSetSequence.PerformLayout();
            this.gbSetDataPath.ResumeLayout(false);
            this.gbSetDataPath.PerformLayout();
            this.gbSetName.ResumeLayout(false);
            this.gbSetName.PerformLayout();
            this.gbSetPattern.ResumeLayout(false);
            this.gbSetPattern.PerformLayout();
            this.gbPunishmentChoose.ResumeLayout(false);
            this.gbPunishmentChoose.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbExpSequence;
        private System.Windows.Forms.TextBox tbLastTime;
        private System.Windows.Forms.Label lblTrainOrTest;
        private System.Windows.Forms.Label lblLastTime;
        private System.Windows.Forms.RadioButton rbTrain;
        private System.Windows.Forms.RadioButton rbTest;
        private System.Windows.Forms.Button btnSetSAdd;
        private System.Windows.Forms.Button btnSetSDelete;
        private System.Windows.Forms.GroupBox gbSetSequence;
        private System.Windows.Forms.GroupBox gbSetDataPath;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblExName;
        private System.Windows.Forms.Label lblDataPath;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cbSecondOrMinute;
        private System.Windows.Forms.Button btnChooseDataPath;
        private System.Windows.Forms.Label lblDPValue;
        private System.Windows.Forms.GroupBox gbSetName;
        private System.Windows.Forms.GroupBox gbSetPattern;
        private System.Windows.Forms.Label lblWhichToPunishment;
        private System.Windows.Forms.RadioButton rbDownT;
        private System.Windows.Forms.RadioButton rbUpT;
        private System.Windows.Forms.GroupBox gbPunishmentChoose;
        private System.Windows.Forms.RadioButton rbPCShake;
        private System.Windows.Forms.RadioButton rbPCHeat;
    }
}