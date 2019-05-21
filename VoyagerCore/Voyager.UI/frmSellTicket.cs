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
    public partial class frmSellTicket : Form
    {
        public frmSellTicket()
        {
            InitializeComponent();
        }

        private void frmSellTicket_Load(object sender, EventArgs e)
        {
            dtp_Donus.Visible = false;
            lbl_DonusTarihi.Visible = false;
            dtp_Gidis.MinDate = DateTime.Now;
            
        }

        private void rdbtn_GidisDonus_CheckedChanged(object sender, EventArgs e)
        {
            dtp_Donus.Visible = true;
            lbl_DonusTarihi.Visible = true;
        }

        private void rdbtn_TekYon_CheckedChanged(object sender, EventArgs e)
        {
            dtp_Donus.Visible = false;
            lbl_DonusTarihi.Visible = false;
        }

        private void dtp_Gidis_ValueChanged(object sender, EventArgs e)
        {
            dtp_Donus.MinDate = dtp_Gidis.Value;
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            //frm_SeferListele frm_SeferListele = new frm_SeferListele();
            //frm_SeferListele.ShowDialog();
        }
    }
}
