using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rorationSimulation;
using XControl;


namespace FlightSimulator
{
    public partial class Form1 : Form
    {
        //Train  true    Test  false
        private List<bool> trainOrTest_1 = new List<bool>();
        private List<int> experimentTime_1 = new List<int>();

        private List<bool> trainOrTest_2 = new List<bool>();
        private List<int> experimentTime_2 = new List<int>();

        private List<bool> trainOrTest_3 = new List<bool>();
        private List<int> experimentTime_3 = new List<int>();

        private List<Control> controls;
        //test in step 3
        private List<bool> trainOrTestForTest = new List<bool>();
        private List<int> experimentTimeForTest = new List<int>();


        drawProcess dp;
        drawProcess dp1;
        drawProcess dp2;



       


        private int sequenceIndex = 0;

        private Bitmap imageNow;

        //debug mode start
        bool ifStartDebugMode = true;

        //save position and torque point
        private List<float> lpf1 = new List<float>();
        private List<float> lpf2 = new List<float>();

        private List<float> lpf3 = new List<float>();
        private List<float> lpf4 = new List<float>();


        private PortControl pc;

        //false minute, true second
        private bool isSecond_1 = true;
        private bool isSecond_2 = true;
        private bool isSecond_3 = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void portDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortDection pt = new PortDection();
            int iActulaWidth = Screen.PrimaryScreen.Bounds.Width;
            int iActulaHeight = Screen.PrimaryScreen.Bounds.Height;
            pt.Location = new Point(iActulaWidth/2, iActulaHeight/10);
            pt.Show();
        }

        private void btnSetSAdd_Click(object sender, EventArgs e)
        {
            if (rbTest_1.Checked)
            {
                trainOrTest_1.Add(false);
                experimentTime_1.Add(int.Parse(tbLastTime_1.Text));
                if (isSecond_1)
                {
                    lbExpSequence_1.Items.Add(trainOrTest_1.Count.ToString("00") + "   " + "Test  " + tbLastTime_1.Text + "s");
                }
                else
                {
                    lbExpSequence_1.Items.Add(trainOrTest_1.Count.ToString("00") + "   " + "Test  " + tbLastTime_1.Text + "m");
                }


            }
            else
            {
                trainOrTest_1.Add(true);
                experimentTime_1.Add(int.Parse(tbLastTime_1.Text));
                if (isSecond_1)
                {
                    lbExpSequence_1.Items.Add(trainOrTest_1.Count.ToString("00") + "  " + "Train  " + tbLastTime_1.Text + "s");
                }
                else
                {
                    lbExpSequence_1.Items.Add(trainOrTest_1.Count.ToString("00") + "  " + "Train  " + tbLastTime_1.Text + "m");
                }


            }
        }

        private void btnSetSDelete_Click(object sender, EventArgs e)
        {
            try
            {
                trainOrTest_1.RemoveAt(lbExpSequence_1.SelectedIndex);
                experimentTime_1.RemoveAt(lbExpSequence_1.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Wrong, no item choosed!");

            }

            lbExpSequence_1.Items.Clear();

            for (int i = 0; i != trainOrTest_1.Count; i++)
            {
                if (trainOrTest_1[i] == true)
                {
                    if (isSecond_1)
                    {
                        lbExpSequence_1.Items.Add((i + 1).ToString("00") + "  " + "Train  " + experimentTime_1[i].ToString() + "s");
                    }
                    else
                    {
                        lbExpSequence_1.Items.Add((i + 1).ToString("00") + "  " + "Train  " + experimentTime_1[i].ToString() + "m");
                    }

                }
                else
                {
                    if (isSecond_1)
                    {
                        lbExpSequence_1.Items.Add((i + 1).ToString("00") + "   " + "Test  " + experimentTime_1[i].ToString() + "s");
                    }
                    else
                    {
                        lbExpSequence_1.Items.Add((i + 1).ToString("00") + "   " + "Test  " + experimentTime_1[i].ToString() + "m");
                    }


                }
            }

        }

        private void btnSetSAdd_2_Click(object sender, EventArgs e)
        {
            if (rbTest_2.Checked)
            {
                trainOrTest_2.Add(false);
                experimentTime_2.Add(int.Parse(tbLastTime_2.Text));
                if (isSecond_2)
                {
                    lbExpSequence_2.Items.Add(trainOrTest_2.Count.ToString("00") + "   " + "Test  " + tbLastTime_2.Text + "s");
                }
                else
                {
                    lbExpSequence_2.Items.Add(trainOrTest_2.Count.ToString("00") + "   " + "Test  " + tbLastTime_2.Text + "m");
                }


            }
            else
            {
                trainOrTest_2.Add(true);
                experimentTime_2.Add(int.Parse(tbLastTime_2.Text));
                if (isSecond_2)
                {
                    lbExpSequence_2.Items.Add(trainOrTest_2.Count.ToString("00") + "  " + "Train  " + tbLastTime_2.Text + "s");
                }
                else
                {
                    lbExpSequence_2.Items.Add(trainOrTest_2.Count.ToString("00") + "  " + "Train  " + tbLastTime_2.Text + "m");
                }


            }
        }

        private void btnSetSAdd_3_Click(object sender, EventArgs e)
        {
            if (rbTest_3.Checked)
            {
                trainOrTest_3.Add(false);
                experimentTime_3.Add(int.Parse(tbLastTime_3.Text));
                if (isSecond_3)
                {
                    lbExpSequence_3.Items.Add(trainOrTest_3.Count.ToString("00") + "   " + "Test  " + tbLastTime_3.Text + "s");
                }
                else
                {
                    lbExpSequence_3.Items.Add(trainOrTest_3.Count.ToString("00") + "   " + "Test  " + tbLastTime_3.Text + "m");
                }


            }
            else
            {
                trainOrTest_3.Add(true);
                experimentTime_3.Add(int.Parse(tbLastTime_3.Text));
                if (isSecond_3)
                {
                    lbExpSequence_3.Items.Add(trainOrTest_3.Count.ToString("00") + "  " + "Train  " + tbLastTime_3.Text + "s");
                }
                else
                {
                    lbExpSequence_3.Items.Add(trainOrTest_3.Count.ToString("00") + "  " + "Train  " + tbLastTime_3.Text + "m");
                }


            }
        }

        private void btnSetSDelete_2_Click(object sender, EventArgs e)
        {
            try
            {
                trainOrTest_2.RemoveAt(lbExpSequence_2.SelectedIndex);
                experimentTime_2.RemoveAt(lbExpSequence_2.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Wrong, no item choosed!");

            }

            lbExpSequence_2.Items.Clear();

            for (int i = 0; i != trainOrTest_2.Count; i++)
            {
                if (trainOrTest_2[i] == true)
                {
                    if (isSecond_2)
                    {
                        lbExpSequence_2.Items.Add((i + 1).ToString("00") + "  " + "Train  " + experimentTime_2[i].ToString() + "s");
                    }
                    else
                    {
                        lbExpSequence_2.Items.Add((i + 1).ToString("00") + "  " + "Train  " + experimentTime_2[i].ToString() + "m");
                    }

                }
                else
                {
                    if (isSecond_2)
                    {
                        lbExpSequence_2.Items.Add((i + 1).ToString("00") + "   " + "Test  " + experimentTime_2[i].ToString() + "s");
                    }
                    else
                    {
                        lbExpSequence_2.Items.Add((i + 1).ToString("00") + "   " + "Test  " + experimentTime_2[i].ToString() + "m");
                    }


                }
            }

        }

        private void btnSetSDelete_3_Click(object sender, EventArgs e)
        {
            try
            {
                trainOrTest_3.RemoveAt(lbExpSequence_3.SelectedIndex);
                experimentTime_3.RemoveAt(lbExpSequence_3.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Wrong, no item choosed!");

            }

            lbExpSequence_3.Items.Clear();

            for (int i = 0; i != trainOrTest_3.Count; i++)
            {
                if (trainOrTest_3[i] == true)
                {
                    if (isSecond_3)
                    {
                        lbExpSequence_3.Items.Add((i + 1).ToString("00") + "  " + "Train  " + experimentTime_3[i].ToString() + "s");
                    }
                    else
                    {
                        lbExpSequence_3.Items.Add((i + 1).ToString("00") + "  " + "Train  " + experimentTime_3[i].ToString() + "m");
                    }

                }
                else
                {
                    if (isSecond_3)
                    {
                        lbExpSequence_3.Items.Add((i + 1).ToString("00") + "   " + "Test  " + experimentTime_3[i].ToString() + "s");
                    }
                    else
                    {
                        lbExpSequence_3.Items.Add((i + 1).ToString("00") + "   " + "Test  " + experimentTime_3[i].ToString() + "m");
                    }


                }
            }

        }

        private void cbSecondOrMinute_1_CheckedChanged(object sender, EventArgs e)
        {
           
        }


        

        private void btnSetSequenceSave_3_Click(object sender, EventArgs e)
        {

        }

        private void gbSetSequence_2_Enter(object sender, EventArgs e)
        {

        }

        private void cbSetSeqChoosed_1_Click(object sender, EventArgs e)
        {
            if (cbSetSeqChoosed_1.Checked == true)
            {
                cbSetSeqChoosed_1.Checked = true;
                cbSetSeqChoosed_2.Checked = false ;
                cbSetSeqChoosed_3.Checked = false;
            }
            else
            {
                cbSetSeqChoosed_1.Checked = false;
                
            }
        }

        private void cbSetSeqChoosed_2_Click(object sender, EventArgs e)
        {
            if (cbSetSeqChoosed_2.Checked == true)
            {
                cbSetSeqChoosed_2.Checked = true;
                cbSetSeqChoosed_1.Checked = false;
                cbSetSeqChoosed_3.Checked = false;
            }
            else
            {
                cbSetSeqChoosed_2.Checked = false;

            }
        }

        private void cbSetSeqChoosed_3_Click(object sender, EventArgs e)
        {
            if (cbSetSeqChoosed_3.Checked == true)
            {
                cbSetSeqChoosed_3.Checked = true;
                cbSetSeqChoosed_1.Checked = false;
                cbSetSeqChoosed_2.Checked = false;
            }
            else
            {
                cbSetSeqChoosed_3.Checked = false;

            }
        }

        private void btnChooseDataPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog BrowDialog = new FolderBrowserDialog();
            BrowDialog.ShowNewFolderButton = true;
            BrowDialog.Description = "请选择数据保存位置";
            BrowDialog.ShowDialog();
            string path = BrowDialog.SelectedPath;
            lblDPValue.Text = path;
        }

        private void lblDPValue_Click(object sender, EventArgs e)
        {

        }

        private void btnGoStep_2_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
        }

        private void btnTestDrawing_Click(object sender, EventArgs e)
        {
            lblChooseDisplay.Visible = true;
            cbIsPosition.Visible = true;
            cbIsTorque.Visible = true;

            dp = new drawProcess(this.pictureBox1.Size.Width, this.pictureBox1.Size.Height,Color.DarkCyan);
            this.timer1.Start();
            
            //this.pictureBox1.CreateGraphics().DrawImage(dp.drawTest(), 0, 0);
        }

        private void tpStep2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pc = new PortControl(0);
            pc.AnalogPortConfigurationIn();
            pc.AnalogPortConfigurationOut();
            pc.DigitalConfigurationOut();

            timer1.Interval = 10;
            timer2.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            float positionVoltageValue;
            float torqueVoltageValue;

            float position = float.Parse(pc.AnalogInput(0, out positionVoltageValue));
            float troque = float.Parse(pc.AnalogInput(1, out torqueVoltageValue));
            

            if (ifStartDebugMode)
            {
                position = position / 100;
                troque = troque / 100;
            }


            this.lblPositionValue.Text = position.ToString();
            this.lblTorqueValue.Text = troque.ToString();
           
        


            lpf1.Add(position);
            lpf2.Add(troque);
            if (lpf1.Count == 400)
            {
                lpf1.Remove(lpf1[0]);
            }

            if (lpf2.Count == 400)
            {
                lpf2.Remove(lpf2[0]);
            }



            this.pictureBox1.CreateGraphics().DrawImage(dp.drawSignalCurve(lpf1, lpf2), 0, 0);
            
        }

        private void cbIsPosition_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsPosition.Checked)
            {
                dp.isPosition = true;
            }
            else
            {
                dp.isPosition = false;
            }
        }

        private void cbIsTorque_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsTorque.Checked)
            {
                dp.isTorque = true;
            }
            else
            {
                dp.isTorque = false;
            }
        }

        private void cbOpenOrClosed_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOpenOrClosed.Checked)
            {
                cbOpenOrClosed.Text = "Closed";
            }
            else
            {
                cbOpenOrClosed.Text = "Open";
            }
        }

        private void btnGoStep_3_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(2);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            float positionVoltageValue;
            float torqueVoltageValue;

            float position = float.Parse(pc.AnalogInput(0, out positionVoltageValue));
            float troque = float.Parse(pc.AnalogInput(1, out torqueVoltageValue));


            if (ifStartDebugMode)
            {
                position = position / 100;
                troque = troque / 100;
            }


          




            lpf3.Add(position);
            lpf4.Add(troque);
            if (lpf3.Count == 150)
            {
                lpf3.Remove(lpf3[0]);
            }

            if (lpf4.Count == 150)
            {
                lpf4.Remove(lpf4[0]);
            }



            this.pictureBox2.CreateGraphics().DrawImage(dp1.drawSignalCurve(lpf3, lpf4), 0, 0);
            imageNow = dp2.drawCommunitivePoint(troque, true);
            this.pictureBox3.CreateGraphics().DrawImage(imageNow, 0, 0);
            

    }

        private void btnStep3Start_Click(object sender, EventArgs e)
        {
            dp1 = new drawProcess(this.pictureBox2.Width, this.pictureBox2.Height, Color.DarkCyan);
            dp2 = new drawProcess(this.pictureBox3.Width, this.pictureBox3.Height, Color.DarkCyan);
            for (int i = 0; i < 6; i++)
            {
                if (i % 2 == 0)
                {
                    trainOrTestForTest.Add(true);
                }
                else
                {
                    trainOrTestForTest.Add(false);
                }

                experimentTimeForTest.Add(300);

                
            }


           

            controls = new List<Control>();
            for (int i = 0; i < 6; i++)
            {
                Label l = new Label();
                l.Name = "lblDForSequence" + i.ToString();
                l.AutoSize = true;
                l.BorderStyle = BorderStyle.FixedSingle;
                l.Margin = new System.Windows.Forms.Padding(3);
                l.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                if (trainOrTestForTest[i] == true)
                {
                    l.Text = "Tr: " + experimentTimeForTest[i].ToString();
                }
                else
                {
                    l.Text = "Te: " + experimentTimeForTest[i].ToString();
                }
                controls.Add(l);
                
                this.flpTopForLabel.Controls.Add(l);
            }
            controls[0].BackColor = Color.DarkCyan;


            timer2.Start();
            timer1.Stop();
            this.btnStep3Start.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Bitmap imageHere = new Bitmap(imageNow);
            PictureBox pb = new PictureBox();
            float width = this.flpBottomForImageList.Size.Width - 30;
            float height = (int)(((float)this.pictureBox3.Size.Height / (float)this.pictureBox3.Size.Width) * width);
            pb.Size = new Size((int)width,(int)height);
          
            pb.Image = imageHere;
            pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flpBottomForImageList.Controls.Add(pb);

            sequenceIndex++;
            if (sequenceIndex < controls.Count)
            {
                controls[sequenceIndex].BackColor = Color.DarkCyan;
                controls[sequenceIndex - 1].BackColor = Color.White;
            }
            else
            {
                this.button1.Enabled = false;
                controls[controls.Count - 1].BackColor = Color.White;
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tpStep1_Click(object sender, EventArgs e)
        {

        }

        private void lblSecondOrMinute_1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSeOrMi_1_Click(object sender, EventArgs e)
        {
            if (isSecond_1)
            {
                this.btnSeOrMi_1.Text = "M";
                isSecond_1 = false;
            }
            else
            {
                this.btnSeOrMi_1.Text = "S";
                isSecond_1 = true;
            }
        }

        private void btnSeOrMi_2_Click(object sender, EventArgs e)
        {
            if (isSecond_2)
            {
                this.btnSeOrMi_2.Text = "M";
                isSecond_2 = false;
            }
            else
            {
                this.btnSeOrMi_2.Text = "S";
                isSecond_2 = true;
            }
        }

        private void btnSeOrMi_3_Click(object sender, EventArgs e)
        {
            if (isSecond_3)
            {
                this.btnSeOrMi_3.Text = "M";
                isSecond_3 = false;
            }
            else
            {
                this.btnSeOrMi_3.Text = "S";
                isSecond_3 = true;
            }
        }
    }
}
