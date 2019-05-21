using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voyager.BLL;

namespace Voyager.UI
{
    public partial class frmExpedition : Form
    {
        public frmExpedition()
        {
            InitializeComponent();
        }

        private void frmExpedition_Load(object sender, EventArgs e)
        {
            cmbRoute.DisplayMember = "Name";
            cmbRoute.DataSource = Program.app.allRoutes;
            cmbDrivers.DisplayMember = "FullName";
            cmbDrivers.DataSource = Program.app.allDrivers;
            cmbHostes.DisplayMember = "FullName";
            cmbHostes.DataSource = Program.app.allHosts;
            cmbBus.DisplayMember = "Plate";
            cmbBus.DataSource = Program.app.allBuses;
            dGridExpedition.DataSource = null;
            dGridExpedition.DataSource = Program.app.allExpeditions.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Expedition expedition = new Expedition((Route)cmbRoute.SelectedItem,dtpDeparture.Value,dtpEstimated.Value);
            expedition.Bus = (Bus)cmbBus.SelectedItem;
            expedition.HasSnackService = chbHasSnack.Checked;
            Program.app.allExpeditions.Add(expedition);
            dGridExpedition.DataSource = null;
            dGridExpedition.DataSource = Program.app.allExpeditions.ToList();
        }
    }
}