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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbLastTime = new System.Windows.Forms.TextBox();
            this.lblTrainOrTest = new System.Windows.Forms.Label();
            this.lblLastTime = new System.Windows.Forms.Label();
            this.rbTrain = new System.Windows.Forms.RadioButton();
            this.rbTest = new System.Windows.Forms.RadioButton();
            this.btnSetSAdd = new System.Windows.Forms.Button();
            this.btnSetSDelete = new System.Windows.Forms.Button();
            this.gbSetSequence = new System.Windows.Forms.GroupBox();
            this.gbSetName = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblPatternChoose = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblExName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDataPath = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblPunishmentChosse = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.gbSetSequence.SuspendLayout();
            this.gbSetName.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 163);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 173);
            this.listBox1.TabIndex = 0;
            // 
            // tbLastTime
            // 
            this.tbLastTime.Location = new System.Drawing.Point(112, 75);
            this.tbLastTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbLastTime.Name = "tbLastTime";
            this.tbLastTime.Size = new System.Drawing.Size(76, 20);
            this.tbLastTime.TabIndex = 2;
            // 
            // lblTrainOrTest
            // 
            this.lblTrainOrTest.AutoSize = true;
            this.lblTrainOrTest.Location = new System.Drawing.Point(14, 49);
            this.lblTrainOrTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrainOrTest.Name = "lblTrainOrTest";
            this.lblTrainOrTest.Size = new System.Drawing.Size(63, 13);
            this.lblTrainOrTest.TabIndex = 3;
            this.lblTrainOrTest.Text = "TrainOrTest";
            // 
            // lblLastTime
            // 
            this.lblLastTime.AutoSize = true;
            this.lblLastTime.Location = new System.Drawing.Point(123, 49);
            this.lblLastTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastTime.Name = "lblLastTime";
            this.lblLastTime.Size = new System.Drawing.Size(50, 13);
            this.lblLastTime.TabIndex = 4;
            this.lblLastTime.Text = "LastTime";
            // 
            // rbTrain
            // 
            this.rbTrain.AutoSize = true;
            this.rbTrain.Location = new System.Drawing.Point(16, 75);
            this.rbTrain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbTrain.Name = "rbTrain";
            this.rbTrain.Size = new System.Drawing.Size(49, 17);
            this.rbTrain.TabIndex = 5;
            this.rbTrain.TabStop = true;
            this.rbTrain.Text = "Train";
            this.rbTrain.UseVisualStyleBackColor = true;
            // 
            // rbTest
            // 
            this.rbTest.AutoSize = true;
            this.rbTest.Location = new System.Drawing.Point(16, 96);
            this.rbTest.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbTest.Name = "rbTest";
            this.rbTest.Size = new System.Drawing.Size(46, 17);
            this.rbTest.TabIndex = 6;
            this.rbTest.TabStop = true;
            this.rbTest.Text = "Test";
            this.rbTest.UseVisualStyleBackColor = true;
            // 
            // btnSetSAdd
            // 
            this.btnSetSAdd.Location = new System.Drawing.Point(16, 128);
            this.btnSetSAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSetSAdd.Name = "btnSetSAdd";
            this.btnSetSAdd.Size = new System.Drawing.Size(69, 20);
            this.btnSetSAdd.TabIndex = 7;
            this.btnSetSAdd.Text = "Add";
            this.btnSetSAdd.UseVisualStyleBackColor = true;
            this.btnSetSAdd.Click += new System.EventHandler(this.btnSetSAdd_Click);
            // 
            // btnSetSDelete
            // 
            this.btnSetSDelete.Location = new System.Drawing.Point(120, 128);
            this.btnSetSDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSetSDelete.Name = "btnSetSDelete";
            this.btnSetSDelete.Size = new System.Drawing.Size(67, 20);
            this.btnSetSDelete.TabIndex = 8;
            this.btnSetSDelete.Text = "Detele";
            this.btnSetSDelete.UseVisualStyleBackColor = true;
            this.btnSetSDelete.Click += new System.EventHandler(this.btnSetSDelete_Click);
            // 
            // gbSetSequence
            // 
            this.gbSetSequence.Controls.Add(this.btnSetSDelete);
            this.gbSetSequence.Controls.Add(this.listBox1);
            this.gbSetSequence.Controls.Add(this.btnSetSAdd);
            this.gbSetSequence.Controls.Add(this.tbLastTime);
            this.gbSetSequence.Controls.Add(this.rbTest);
            this.gbSetSequence.Controls.Add(this.lblTrainOrTest);
            this.gbSetSequence.Controls.Add(this.rbTrain);
            this.gbSetSequence.Controls.Add(this.lblLastTime);
            this.gbSetSequence.Location = new System.Drawing.Point(20, 24);
            this.gbSetSequence.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbSetSequence.Name = "gbSetSequence";
            this.gbSetSequence.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbSetSequence.Size = new System.Drawing.Size(219, 374);
            this.gbSetSequence.TabIndex = 9;
            this.gbSetSequence.TabStop = false;
            this.gbSetSequence.Text = "Set-Sequence";
            // 
            // gbSetName
            // 
            this.gbSetName.Controls.Add(this.listBox3);
            this.gbSetName.Controls.Add(this.lblPunishmentChosse);
            this.gbSetName.Controls.Add(this.listBox2);
            this.gbSetName.Controls.Add(this.lblPatternChoose);
            this.gbSetName.Controls.Add(this.textBox2);
            this.gbSetName.Controls.Add(this.lblExName);
            this.gbSetName.Controls.Add(this.textBox1);
            this.gbSetName.Controls.Add(this.lblDataPath);
            this.gbSetName.Location = new System.Drawing.Point(280, 24);
            this.gbSetName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbSetName.Name = "gbSetName";
            this.gbSetName.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbSetName.Size = new System.Drawing.Size(216, 374);
            this.gbSetName.TabIndex = 10;
            this.gbSetName.TabStop = false;
            this.gbSetName.Text = "ExInit";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Method 1",
            "Method 2"});
            this.listBox2.Location = new System.Drawing.Point(28, 196);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(172, 43);
            this.listBox2.TabIndex = 16;
            // 
            // lblPatternChoose
            // 
            this.lblPatternChoose.AutoSize = true;
            this.lblPatternChoose.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPatternChoose.Location = new System.Drawing.Point(62, 163);
            this.lblPatternChoose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatternChoose.Name = "lblPatternChoose";
            this.lblPatternChoose.Size = new System.Drawing.Size(83, 12);
            this.lblPatternChoose.TabIndex = 15;
            this.lblPatternChoose.Text = "PatternChoose";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 91);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 14;
            // 
            // lblExName
            // 
            this.lblExName.AutoSize = true;
            this.lblExName.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExName.Location = new System.Drawing.Point(8, 94);
            this.lblExName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExName.Name = "lblExName";
            this.lblExName.Size = new System.Drawing.Size(89, 12);
            this.lblExName.TabIndex = 13;
            this.lblExName.Text = "ExperimentName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 12;
            // 
            // lblDataPath
            // 
            this.lblDataPath.AutoSize = true;
            this.lblDataPath.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDataPath.Location = new System.Drawing.Point(44, 40);
            this.lblDataPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataPath.Name = "lblDataPath";
            this.lblDataPath.Size = new System.Drawing.Size(53, 12);
            this.lblDataPath.TabIndex = 11;
            this.lblDataPath.Text = "DataPath";
            // 
            // lblPunishmentChosse
            // 
            this.lblPunishmentChosse.AutoSize = true;
            this.lblPunishmentChosse.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPunishmentChosse.Location = new System.Drawing.Point(62, 268);
            this.lblPunishmentChosse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPunishmentChosse.Name = "lblPunishmentChosse";
            this.lblPunishmentChosse.Size = new System.Drawing.Size(101, 12);
            this.lblPunishmentChosse.TabIndex = 17;
            this.lblPunishmentChosse.Text = "PunishmentChoose";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "Heat",
            "Shake"});
            this.listBox3.Location = new System.Drawing.Point(28, 293);
            this.listBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(172, 43);
            this.listBox3.TabIndex = 18;
            // 
            // PreSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 432);
            this.Controls.Add(this.gbSetName);
            this.Controls.Add(this.gbSetSequence);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PreSetting";
            this.Text = "PreSetting";
            this.gbSetSequence.ResumeLayout(false);
            this.gbSetSequence.PerformLayout();
            this.gbSetName.ResumeLayout(false);
            this.gbSetName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbLastTime;
        private System.Windows.Forms.Label lblTrainOrTest;
        private System.Windows.Forms.Label lblLastTime;
        private System.Windows.Forms.RadioButton rbTrain;
        private System.Windows.Forms.RadioButton rbTest;
        private System.Windows.Forms.Button btnSetSAdd;
        private System.Windows.Forms.Button btnSetSDelete;
        private System.Windows.Forms.GroupBox gbSetSequence;
        private System.Windows.Forms.GroupBox gbSetName;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblPatternChoose;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblExName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDataPath;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label lblPunishmentChosse;
    }
}