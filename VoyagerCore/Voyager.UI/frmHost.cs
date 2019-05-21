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
    public partial class frmHost : Form
    {
        public frmHost()
        {
            InitializeComponent();
        }

        private void frmHost_Load(object sender, EventArgs e)
        {
            dgw_Host.DataSource = null;
            dgw_Host.DataSource = Program.app.allHosts;
            cmb_Cinsiyet.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Host newHost = new Host(txt_Ad.Text,txt_Soyad.Text,dtp_DogumTarihi.Value);
            newHost.IdentityNumber = txt_Tc.Text;
            newHost.gender = (Gender)cmb_Cinsiyet.SelectedItem;
            Program.app.allHosts.Add(newHost);
            dgw_Host.DataSource = Program.app.allHosts.ToList();
        }
    }
}
