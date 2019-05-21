using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyager.UI
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivers drivers = new frmDrivers();
            drivers.Show();
        }

        private void hostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHost host = new frmHost();
            host.Show();
        }

        private void expeditionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpedition expedition = new frmExpedition();
            expedition.Show();
        }

        private void routeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRouteCreator routeCreator = new frmRouteCreator();
            routeCreator.Show();
        }

        private void busesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBus frmBus = new frmBus();
            frmBus.ShowDialog();
        }
    }
}
