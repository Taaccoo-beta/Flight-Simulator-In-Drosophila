using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XControl;
using rorationSimulation;
namespace PortDetection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private PortControl pc;
        private float position;
        private float troque;
        private float tacho;
        private bool isStart = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            pc = new PortControl(0);
            pc.AnalogPortConfigurationIn();
            pc.DigitalConfigurationOut();
            pc.AnalogPortConfigurationOut();

            timer1.Interval = 100;
            timer2.Interval = 100;

        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            if (isStart)
            {
                this.lblStart.Text = "Stop";
                isStart = false;
                timer1.Start();
            }
            else
            {
                this.lblStart.Text = "Start";
                isStart = true;
                timer1.Stop();
            }
        }
        private List<float> lpf1 = new List<float>();
        private List<float> lpf2 = new List<float>();
        private drawProcess dpl = new drawProcess(600, 400,Color.Black);
        private void timer1_Tick(object sender, EventArgs e)
        {
            position = float.Parse(pc.AnalogInput(0));
            troque = float.Parse(pc.AnalogInput(1));
            tacho = float.Parse(pc.AnalogInput(2));


            this.lblPosition.Text = position.ToString("00.000");
            this.lblTorque.Text = troque.ToString("00.000");
            this.lblTacho.Text = tacho.ToString("00.000");

           
            lpf1.Add(position);
            lpf2.Add(troque);
            if (lpf1.Count == 300)
            {
                lpf1.Remove(lpf1[0]);
            }

            if (lpf2.Count == 300)
            {
                lpf2.Remove(lpf2[0]);
            }

            
           
            this.CreateGraphics().DrawImage(dpl.drawBackGround(lpf1,lpf2), 540, 70);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSendShutter_Click(object sender, EventArgs e)
        {
            if (this.cb1.Checked)
            {
                this.pc.DigitOutput(0, MccDaq.DigitalLogicState.Low);
            }
            else
            {
                this.pc.DigitOutput(0, MccDaq.DigitalLogicState.High);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.checkBox1.Text = "Low";

            }
            else
            {
                this.checkBox1.Text = "High";
            }
        }

       

        private void btnSendHeat_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.pc.DigitOutput(1, MccDaq.DigitalLogicState.Low);
            }
            else
            {
                this.pc.DigitOutput(1, MccDaq.DigitalLogicState.High);
            }
        }

        private void btnSendIntergrator_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.pc.DigitOutput(2, MccDaq.DigitalLogicState.Low);
            }
            else
            {
                this.pc.DigitOutput(2, MccDaq.DigitalLogicState.High);
            }
        }

        private void btnSendClosed_Click(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.pc.DigitOutput(3, MccDaq.DigitalLogicState.Low);
            }
            else
            {
                this.pc.DigitOutput(3, MccDaq.DigitalLogicState.High);
            }
        }

        private void btnSeedRotating_Click(object sender, EventArgs e)
        {
            if (this.checkBox4.Checked)
            {
                this.pc.DigitOutput(4, MccDaq.DigitalLogicState.Low);
            }
            else
            {
                this.pc.DigitOutput(4, MccDaq.DigitalLogicState.High);
            }
        }

        private void btnRotatinBias_Click(object sender, EventArgs e)
        {
            pc.VOutput(0, float.Parse(this.tbPrtatingBias.Text));
        }

        private void btnTorqueBias_Click(object sender, EventArgs e)
        {
            this.pc.VOutput(1, float.Parse(this.tbTroqueBias.Text));
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox5.Checked)
            {
                this.pc.DigitOutput(int.Parse(tbPortNumber.Text), MccDaq.DigitalLogicState.Low);
            }
            else
            {
                this.pc.DigitOutput(int.Parse(tbPortNumber.Text), MccDaq.DigitalLogicState.High);
            }
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb1.Checked)
            {
                this.cb1.Text = "Low";

            }
            else
            {
                this.cb1.Text = "High";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.checkBox1.Text = "Low";

            }
            else
            {
                this.checkBox1.Text = "High";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.checkBox2.Text = "Low";

            }
            else
            {
                this.checkBox2.Text = "High";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.checkBox3.Text = "Low";

            }
            else
            {
                this.checkBox3.Text = "High";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox4.Checked)
            {
                this.checkBox4.Text = "Low";

            }
            else
            {
                this.checkBox4.Text = "High";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox5.Checked)
            {
                this.checkBox5.Text = "Low";

            }
            else
            {
                this.checkBox5.Text = "High";
            }
        }

        private void cbIsPosition_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsPosition.Checked)
            {
                dpl.isPosition = true;
            }
            else
            {
                dpl.isPosition = false;
            }
        }

        private void cbIsTorque_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsTorque.Checked)
            {
                dpl.isTorque = true;
            }
            else
            {
                dpl.isTorque = false;
            }
        }
    }
}
