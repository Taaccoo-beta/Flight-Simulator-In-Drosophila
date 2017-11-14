using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSimulator
{
    public partial class SigleExpResultPre : Form
    {

        private string dateTime;
        private string expName;
        private List<int> Exptime;
        private List<bool> TrainOrTest;
        private bool ifTPunishment;
        private List<List<float>> position;
        private List<List<float>> torque;


        //public SigleExpResultPre(string dateTime,string expName,List<int> ExpTime,List<bool> TrainOrTest,bool ifPublishment)
        //{
        //    this.dateTime = dateTime;
        //    this.expName = expName;
        //    this.Exptime = ExpTime;
        //    this.TrainOrTest = TrainOrTest;
        //    this.ifTPunishment = ifPublishment;

        //    InitializeComponent();
        //}

        public SigleExpResultPre()
        {
            InitializeComponent();
        }
        public void setPositionAndTroque(List<List<float>> position, List<List<float>> torque)
        {
            this.position = position;
            this.torque = torque;
        }

        private void SigleExpResultPre_Load(object sender, EventArgs e)
        {

        }

        public void showResult()
        {
            List<Control> controls = new List<Control>();
            int controlsLength = 3;


            for (int i = 0; i < controlsLength; i++)
            {
                Label l = new Label();
                l.Name = "lblDForSequence" + i.ToString();
                l.AutoSize = true;
                l.BorderStyle = BorderStyle.FixedSingle;
                l.Margin = new System.Windows.Forms.Padding(3);
                l.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                if (TrainOrTest[i] == true)
                {
                    l.Text = "Tr: " + Exptime[i].ToString();
                }
                else
                {
                    l.Text = "Te: " + Exptime[i].ToString();
                }
                controls.Add(l);

                this.flowLayoutPanel1.Controls.Add(l);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Exptime = new List<int>();
            TrainOrTest = new List<bool>();
            for (int i = 0; i != 3; i++)
            {
                Exptime.Add(i * 10);
                TrainOrTest.Add(i % 2 == 0 ? true : false);
            }

            showResult();
        }
    }
}
