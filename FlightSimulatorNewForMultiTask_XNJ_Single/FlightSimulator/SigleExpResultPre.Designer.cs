namespace FlightSimulator
{
    partial class SigleExpResultPre
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblExpTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExpName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPathValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "EepTime:";
            // 
            // lblExpTime
            // 
            this.lblExpTime.AutoSize = true;
            this.lblExpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblExpTime.Location = new System.Drawing.Point(225, 83);
            this.lblExpTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpTime.Name = "lblExpTime";
            this.lblExpTime.Size = new System.Drawing.Size(50, 20);
            this.lblExpTime.TabIndex = 1;
            this.lblExpTime.Text = "NULL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(118, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "EexName:";
            // 
            // lblExpName
            // 
            this.lblExpName.AutoSize = true;
            this.lblExpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblExpName.Location = new System.Drawing.Point(225, 124);
            this.lblExpName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpName.Name = "lblExpName";
            this.lblExpName.Size = new System.Drawing.Size(50, 20);
            this.lblExpName.TabIndex = 3;
            this.lblExpName.Text = "NULL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 223);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPathValue
            // 
            this.lblPathValue.AutoSize = true;
            this.lblPathValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPathValue.Location = new System.Drawing.Point(225, 160);
            this.lblPathValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPathValue.Name = "lblPathValue";
            this.lblPathValue.Size = new System.Drawing.Size(50, 20);
            this.lblPathValue.TabIndex = 9;
            this.lblPathValue.Text = "NULL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(118, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Path:";
            // 
            // SigleExpResultPre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 276);
            this.Controls.Add(this.lblPathValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblExpName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblExpTime);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SigleExpResultPre";
            this.Text = "SigleExpResultPre";
            this.Load += new System.EventHandler(this.SigleExpResultPre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExpTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblExpName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPathValue;
        private System.Windows.Forms.Label label4;
    }
}