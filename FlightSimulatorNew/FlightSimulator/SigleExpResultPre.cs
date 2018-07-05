using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private List<float> getPIValue;
        private string path;
        private List<List<float>> positionForEverySequence;
        private List<List<float>> torqueForEverySequence;


        public SigleExpResultPre(string dateTime, string expName, List<int> ExpTime, List<bool> TrainOrTest,string path, List<List<float>> positionForEverySequence, List<List<float>> torqueForEverySequence)
        {
            this.dateTime = dateTime;
            this.expName = expName;
            this.Exptime = ExpTime;
            this.TrainOrTest = TrainOrTest;
           
            this.path = path;
            InitializeComponent();
            this.positionForEverySequence = positionForEverySequence;
            this.torqueForEverySequence = torqueForEverySequence;
        }

        //public SigleExpResultPre()
        //{
        //    InitializeComponent();
        //}
        public void setPositionAndTroque(List<List<float>> position, List<List<float>> torque)
        {
            this.position = position;
            this.torque = torque;
            PICalc pc = new PICalc(position, torque, ifTPunishment);
            getPIValue = pc.getPIValue();
        }
        public List<float> outPIValue()
        {
            return getPIValue;
        }
        private void SigleExpResultPre_Load(object sender, EventArgs e)
        {

        }

        private void DataSave()
        {
            FileInfo myFile = new FileInfo(path);
            StreamWriter sW = myFile.CreateText();

            sW.WriteLine("ExpName: " + expName);
            sW.WriteLine("Date: " + dateTime);

            sW.Write("ExpSequence: ");
            foreach (var item in TrainOrTest)
            {
                if (item)
                {
                    sW.Write("Tr;");
                }
                else
                {
                    sW.Write("Te;");
                }
            }

            sW.WriteLine();
            sW.Write("TimeSequence: ");
            foreach (var item in Exptime)
            {
                sW.Write(item.ToString() + ";");
            }

          
            sW.WriteLine();
            sW.WriteLine();
            sW.Write("Position" + " " + "Torque");
            sW.WriteLine();

            int index = positionForEverySequence.Count;
            for (int i = 0; i != index; i++)
            {
                int indexInside = positionForEverySequence[i].Count;
                for (int j = 0; j != indexInside; j++)
                {
                    sW.WriteLine(positionForEverySequence[i][j].ToString("00.00") + "," + torqueForEverySequence[i][j].ToString("00.00"));
                }
            }

            sW.Close();
        }
        public void showResult()
        {
           
            

            lblExpName.Text = expName;
            lblExpTime.Text = dateTime;
            lblPathValue.Text = path;
            DataSave();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Press OK to delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                File.Delete("e:/data/Test.txt");
                this.Close();
            }
            else
            {
                this.Close();
            }

        }
    }
}
