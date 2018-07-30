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
        
        private List<float> getPIValue;
        private string path;
        private Dictionary<int,List<float>> positionData;
        private Dictionary<int,List<float>> troqueData;
        private int[] expOrder;

        public SigleExpResultPre(string dateTime, string expName, List<int> ExpTime, List<bool> TrainOrTest,string path, Dictionary<int,List<float>> positionData, Dictionary<int,List<float>> troqueData,int[] expOrder)
        {
            this.dateTime = dateTime;
            this.expName = expName;
            this.Exptime = ExpTime;
            this.TrainOrTest = TrainOrTest;
            this.positionData = positionData;
            this.troqueData = troqueData;
            this.path = path;
            this.expOrder = expOrder;
            InitializeComponent();
            
        }

        //public SigleExpResultPre()
        //{
        //    InitializeComponent();
        //}
        
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

            sW.Write("ExpOrder:  [");
            foreach (var item in expOrder)
            {
                sW.Write(item + ",");
            }
            sW.Write("]");

            sW.WriteLine();


            sW.WriteLine();
            sW.WriteLine();
            sW.Write("Position" + " " + "Torque");
            sW.WriteLine();

            for (int i = 1; i != 7; i++)
            {
                sW.Write("exp"+i);
                sW.WriteLine();
                int indexInside = positionData[i].Count;
                for (int j = 0; j != indexInside; j++)
                {
                    sW.WriteLine(positionData[i][j].ToString("00.00") + "," + troqueData[i][j].ToString("00.00"));
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
