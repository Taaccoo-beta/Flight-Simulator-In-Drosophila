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
        public PreSetting()
        {
            InitializeComponent();
        }

        private void btnSetSAdd_Click(object sender, EventArgs e)
        {

            if (rbTest.Checked)
            {
                listBox1.Items.Add((listBox1.Items.Count+1).ToString("00")+"   Test: " + tbLastTime.Text);
            }
            else
            {
                listBox1.Items.Add((listBox1.Items.Count+1).ToString("00")+"  Train: " + tbLastTime.Text);
            }
        }

        private void btnSetSDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
