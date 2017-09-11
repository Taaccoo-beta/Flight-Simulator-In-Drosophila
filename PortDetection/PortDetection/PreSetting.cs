using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortDetection
{
    public partial class PreSetting : Form
    {

        //Train  true    Test  false
        private List<bool> trainOrTest = new List<bool>();
        private List<int> experimentTime = new List<int>();

        //false minute, true second
        private bool isSecond = true; 


        public PreSetting()
        {
            InitializeComponent();
        }

        


        private void btnSetSAdd_Click(object sender, EventArgs e)
        {


            if (rbTest.Checked)
            {
                trainOrTest.Add(false);
                experimentTime.Add(int.Parse(tbLastTime.Text));
                if (isSecond)
                {
                    lbExpSequence.Items.Add(trainOrTest.Count.ToString("00") + "   " + "Test  " + tbLastTime.Text + "s");
                }
                else
                {
                    lbExpSequence.Items.Add(trainOrTest.Count.ToString("00") + "   " + "Test  " + tbLastTime.Text + "m");
                }
                
                
            }
            else
            {
                trainOrTest.Add(true);
                experimentTime.Add(int.Parse(tbLastTime.Text));
                if (isSecond)
                {
                    lbExpSequence.Items.Add(trainOrTest.Count.ToString("00") + "  " + "Train  " + tbLastTime.Text + "s");
                }
                else
                {
                    lbExpSequence.Items.Add(trainOrTest.Count.ToString("00") + "  " + "Train  " + tbLastTime.Text + "m");
                }

                
            }

            
        }

        private void btnSetSDelete_Click(object sender, EventArgs e)
        {

            try
            {
                trainOrTest.RemoveAt(lbExpSequence.SelectedIndex);
                experimentTime.RemoveAt(lbExpSequence.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Wrong, no item choosed!");

            }
            
            lbExpSequence.Items.Clear();

            for (int i = 0; i != trainOrTest.Count; i++)
            {
                if (trainOrTest[i] == true)
                {
                    if (isSecond)
                    {
                        lbExpSequence.Items.Add((i + 1).ToString("00") + "  " + "Train  " + experimentTime[i].ToString()+"s");
                    }
                    else
                    {
                        lbExpSequence.Items.Add((i + 1).ToString("00") + "  " + "Train  " + experimentTime[i].ToString()+"m");
                    }
                    
                }
                else
                {
                    if (isSecond)
                    {
                        lbExpSequence.Items.Add((i + 1).ToString("00") + "   " + "Test  " + experimentTime[i].ToString()+"s");
                    }
                    else
                    {
                        lbExpSequence.Items.Add((i + 1).ToString("00") + "   " + "Test  " + experimentTime[i].ToString()+"m");
                    }

                    
                }
            }

        }

        private void lblLastTime_Click(object sender, EventArgs e)
        {

        }

        private void cbTimeOrHour_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSecondOrMinute.Checked == true)
            {
                isSecond = false;
                cbSecondOrMinute.Text = "m";
            }
            else
            {
                isSecond = true;
                cbSecondOrMinute.Text = "s";
            }
        }

        private void btnChooseDataPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog BrowDialog = new FolderBrowserDialog();
            BrowDialog.ShowNewFolderButton = true;
            BrowDialog.Description = "请选择数据保存位置";
            BrowDialog.ShowDialog();
            string path = BrowDialog.SelectedPath;
            lblDataPath.Text = path.Substring((int)(path.Length / 2), path.Length-1);
            


        }

        private void lblDPValue_Click(object sender, EventArgs e)
        {

        }
    }
}
