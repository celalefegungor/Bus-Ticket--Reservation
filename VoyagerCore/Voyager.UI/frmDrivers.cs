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
    public partial class frmDrivers : Form
    {
        public frmDrivers()
        {
            InitializeComponent();
        }

        private void frmDrivers_Load(object sender, EventArgs e)
        {
            dgw_Drivers.DataSource = null;
            dgw_Drivers.DataSource = Program.app.allDrivers;
            cmb_Lisans.DataSource = Enum.GetValues(typeof(LicenseType));
            cmb_Cinsiyet.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Driver newDriver = new Driver(txt_Ad.Text,txt_Soyad.Text,(LicenseType)cmb_Lisans.SelectedItem, dtp_DogumTarihi.Value);
            newDriver.gender = (Gender)cmb_Cinsiyet.SelectedItem;
            newDriver.IdentityNumber = txt_TcNo.Text;
            Program.app.allDrivers.Add(newDriver);
            dgw_Drivers.DataSource = Program.app.allDrivers.ToList();           
            Temizle();           
        }

        private void Temizle()
        {
            txt_Ad.Clear();
            txt_Soyad.Clear();
            txt_TcNo.Clear();
            cmb_Cinsiyet.SelectedIndex = -1;
            cmb_Lisans.SelectedIndex = -1;
            dtp_DogumTarihi.Value = DateTime.Now;
        }
    }
}
