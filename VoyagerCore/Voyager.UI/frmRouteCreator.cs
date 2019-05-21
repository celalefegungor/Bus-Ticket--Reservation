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
    public partial class frmRouteCreator : Form
    {
        public frmRouteCreator()
        {
            InitializeComponent();
        }

        private void frmRouteCreator_Load(object sender, EventArgs e)
        {
            dgw_RouteList.DataSource = null;
            dgw_RouteList.DataSource = Program.app.allRoutes;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Route newRoute = new Route(cmb_KalkisYeri.Text,cmb_VarisYeri.Text,(int)nmr_Mesafe.Value);
            Program.app.allRoutes.Add(newRoute);
            dgw_RouteList.DataSource = Program.app.allRoutes.ToList();

        }
    }
}
