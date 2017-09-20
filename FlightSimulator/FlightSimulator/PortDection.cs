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
namespace FlightSimulator
{
    public partial class PortDection : Form
    {

        private PortControl pc;


        public PortDection()
        {
            InitializeComponent();

            
        }

        private void PortDection_Load(object sender, EventArgs e)
        {
            pc = new PortControl(0);
            pc.AnalogPortConfigurationIn();
            pc.AnalogPortConfigurationOut();
            pc.DigitalConfigurationOut();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {

        }
    }
}
