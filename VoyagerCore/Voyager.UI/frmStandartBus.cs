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
    public partial class frmStandartBus : Form
    {

        public frmStandartBus()
        {
            InitializeComponent();
        }

        private void btn_biletSatis_Click(object sender, EventArgs e)
        {
            Person person = new Person(txt_Ad.Text, txt_Soyad.Text);
            person.IdentityNumber = txt_TcNo.Text;
            person.DateOfBirth = dtp_DogumTarihi.Value;
            if (rdbtn_Erkek.Checked)
            {
                person.gender = Gender.Male;
            }
            else
            {
                person.gender = Gender.Female;
            }
            Program.app.allPeople.Add(person);
            dgw_Yolcu.DataSource = Program.app.allPeople.ToList();
            if (txt_Koltuk.Text=="")
            {
                Program.app.allPeople.RemoveAt(Program.app.allPeople.Count - 1);
                dgw_Yolcu.DataSource = null;
                dgw_Yolcu.DataSource = Program.app.allPeople.ToList();
                MessageBox.Show("Koltuk Seçilmedi.");
                
            }
            Temizle();
        }

        private void frmStandartBus_Load(object sender, EventArgs e)
        {

            dgw_Yolcu.DataSource = Program.app.allPeople.ToList();
            btn_1.Click += new EventHandler(this.Btn_Click);
            btn_2.Click += new EventHandler(this.Btn_Click);
            btn_3.Click += new EventHandler(this.Btn_Click);
            btn_4.Click += new EventHandler(this.Btn_Click);
            btn_5.Click += new EventHandler(this.Btn_Click);
            btn_6.Click += new EventHandler(this.Btn_Click);
            btn_7.Click += new EventHandler(this.Btn_Click);
            btn_8.Click += new EventHandler(this.Btn_Click);
            btn_9.Click += new EventHandler(this.Btn_Click);
            btn_10.Click += new EventHandler(this.Btn_Click);
            btn_11.Click += new EventHandler(this.Btn_Click);
            btn_12.Click += new EventHandler(this.Btn_Click);
            btn_13.Click += new EventHandler(this.Btn_Click);
            btn_14.Click += new EventHandler(this.Btn_Click);
            btn_15.Click += new EventHandler(this.Btn_Click);
            btn_16.Click += new EventHandler(this.Btn_Click);
            btn_17.Click += new EventHandler(this.Btn_Click);
            btn_18.Click += new EventHandler(this.Btn_Click);
            btn_19.Click += new EventHandler(this.Btn_Click);
            btn_20.Click += new EventHandler(this.Btn_Click);
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (rdbtn_Erkek.Checked)
            {
                clickedButton.BackColor = Color.DarkBlue;
                clickedButton.Enabled = false;
            }
            else if (rdbtn_Kadin.Checked)
            {
                clickedButton.BackColor = Color.Red;
                clickedButton.Enabled = false;
            }
            txt_Koltuk.Text = clickedButton.Text;  
        }

        private void Temizle()
        {
            txt_Ad.Clear();
            txt_Soyad.Clear();
            txt_TcNo.Clear();
            txt_Koltuk.Clear();
            dtp_DogumTarihi.Value = DateTime.Now;
        }

        private void grp_Yolcu_Enter(object sender, EventArgs e)
        {

        }
    }
}

