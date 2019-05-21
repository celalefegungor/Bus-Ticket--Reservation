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
    public partial class frmBus : Form
    {
        public frmBus()
        {
            InitializeComponent();
        }

        private void frmBus_Load(object sender, EventArgs e)
        {
            dGridBus.DataSource = null;
            dGridBus.DataSource = Program.app.allBuses.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chbHasToilet.Checked)
            {
                LuxuryBus bus = new LuxuryBus();
                bus.Make = txtMake.Text;
                bus.Plate = txtPlate.Text;
                Program.app.allBuses.Add(bus);
            }
            else
            {
                StandartBus bus = new StandartBus();
                bus.Make = txtMake.Text;
                bus.Plate = txtPlate.Text;
                Program.app.allBuses.Add(bus);
            }
            dGridBus.DataSource = null;
            dGridBus.DataSource=Program.app.allBuses.ToList();
        }
    }
}
