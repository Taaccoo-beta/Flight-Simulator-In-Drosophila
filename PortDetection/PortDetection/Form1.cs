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

        private void timer1_Tick(object sender, EventArgs e)
        {
            position = float.Parse(pc.AnalogInput(0));
            troque = float.Parse(pc.AnalogInput(1));
            tacho = float.Parse(pc.AnalogInput(2));


            this.lblPosition.Text = position.ToString("00.000");
            this.lblTorque.Text = position.ToString("00.000");
            this.lblTacho.Text = position.ToString("00.000");
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSendShutter_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
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
            if (this.radioButton1.Checked)
            {
                this.radioButton1.Text = "Low";

            }
            else
            {
                this.radioButton1.Text = "High";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                this.radioButton2.Text = "Low";

            }
            else
            {
                this.radioButton2.Text = "High";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
            {
                this.radioButton3.Text = "Low";

            }
            else
            {
                this.radioButton3.Text = "High";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton4.Checked)
            {
                this.radioButton4.Text = "Low";

            }
            else
            {
                this.radioButton4.Text = "High";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton5.Checked)
            {
                this.radioButton5.Text = "Low";

            }
            else
            {
                this.radioButton5.Text = "High";
            }
        }

        private void btnSendHeat_Click(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
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
            if (this.radioButton3.Checked)
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
            if (this.radioButton4.Checked)
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
            if (this.radioButton5.Checked)
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
    }
}
