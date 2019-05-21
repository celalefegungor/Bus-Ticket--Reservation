namespace Voyager.UI
{
    partial class frmSellTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_BiletSatis = new System.Windows.Forms.GroupBox();
            this.lbl_DonusTarihi = new System.Windows.Forms.Label();
            this.lbl_GidisTarihi = new System.Windows.Forms.Label();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.dtp_Donus = new System.Windows.Forms.DateTimePicker();
            this.dtp_Gidis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Donus = new System.Windows.Forms.ComboBox();
            this.cmb_Gidis = new System.Windows.Forms.ComboBox();
            this.rdbtn_GidisDonus = new System.Windows.Forms.RadioButton();
            this.rdbtn_TekYon = new System.Windows.Forms.RadioButton();
            this.grp_BiletSatis.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_BiletSatis
            // 
            this.grp_BiletSatis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grp_BiletSatis.Controls.Add(this.lbl_DonusTarihi);
            this.grp_BiletSatis.Controls.Add(this.lbl_GidisTarihi);
            this.grp_BiletSatis.Controls.Add(this.btn_Listele);
            this.grp_BiletSatis.Controls.Add(this.dtp_Donus);
            this.grp_BiletSatis.Controls.Add(this.dtp_Gidis);
            this.grp_BiletSatis.Controls.Add(this.label2);
            this.grp_BiletSatis.Controls.Add(this.label1);
            this.grp_BiletSatis.Controls.Add(this.cmb_Donus);
            this.grp_BiletSatis.Controls.Add(this.cmb_Gidis);
            this.grp_BiletSatis.Controls.Add(this.rdbtn_GidisDonus);
            this.grp_BiletSatis.Controls.Add(this.rdbtn_TekYon);
            this.grp_BiletSatis.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_BiletSatis.Location = new System.Drawing.Point(12, 12);
            this.grp_BiletSatis.Name = "grp_BiletSatis";
            this.grp_BiletSatis.Size = new System.Drawing.Size(454, 422);
            this.grp_BiletSatis.TabIndex = 1;
            this.grp_BiletSatis.TabStop = false;
            this.grp_BiletSatis.Text = "BİLET SATIŞ EKRANI";
            // 
            // lbl_DonusTarihi
            // 
            this.lbl_DonusTarihi.AutoSize = true;
            this.lbl_DonusTarihi.Location = new System.Drawing.Point(257, 269);
            this.lbl_DonusTarihi.Name = "lbl_DonusTarihi";
            this.lbl_DonusTarihi.Size = new System.Drawing.Size(116, 17);
            this.lbl_DonusTarihi.TabIndex = 10;
            this.lbl_DonusTarihi.Text = "DÖNÜŞ TARİHİ";
            // 
            // lbl_GidisTarihi
            // 
            this.lbl_GidisTarihi.AutoSize = true;
            this.lbl_GidisTarihi.Location = new System.Drawing.Point(68, 269);
            this.lbl_GidisTarihi.Name = "lbl_GidisTarihi";
            this.lbl_GidisTarihi.Size = new System.Drawing.Size(116, 17);
            this.lbl_GidisTarihi.TabIndex = 9;
            this.lbl_GidisTarihi.Text = "GİDİŞ TARİHİ";
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(107, 361);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(235, 23);
            this.btn_Listele.TabIndex = 8;
            this.btn_Listele.Text = "LİSTELE";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // dtp_Donus
            // 
            this.dtp_Donus.Location = new System.Drawing.Point(230, 288);
            this.dtp_Donus.Name = "dtp_Donus";
            this.dtp_Donus.Size = new System.Drawing.Size(173, 24);
            this.dtp_Donus.TabIndex = 7;
            // 
            // dtp_Gidis
            // 
            this.dtp_Gidis.Location = new System.Drawing.Point(41, 288);
            this.dtp_Gidis.Name = "dtp_Gidis";
            this.dtp_Gidis.Size = new System.Drawing.Size(173, 24);
            this.dtp_Gidis.TabIndex = 6;
            this.dtp_Gidis.ValueChanged += new System.EventHandler(this.dtp_Gidis_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "NEREYE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "NEREDEN";
            // 
            // cmb_Donus
            // 
            this.cmb_Donus.FormattingEnabled = true;
            this.cmb_Donus.Location = new System.Drawing.Point(41, 217);
            this.cmb_Donus.Name = "cmb_Donus";
            this.cmb_Donus.Size = new System.Drawing.Size(362, 25);
            this.cmb_Donus.TabIndex = 3;
            // 
            // cmb_Gidis
            // 
            this.cmb_Gidis.FormattingEnabled = true;
            this.cmb_Gidis.Location = new System.Drawing.Point(41, 129);
            this.cmb_Gidis.Name = "cmb_Gidis";
            this.cmb_Gidis.Size = new System.Drawing.Size(362, 25);
            this.cmb_Gidis.TabIndex = 2;
            // 
            // rdbtn_GidisDonus
            // 
            this.rdbtn_GidisDonus.AutoSize = true;
            this.rdbtn_GidisDonus.Location = new System.Drawing.Point(240, 49);
            this.rdbtn_GidisDonus.Name = "rdbtn_GidisDonus";
            this.rdbtn_GidisDonus.Size = new System.Drawing.Size(143, 21);
            this.rdbtn_GidisDonus.TabIndex = 1;
            this.rdbtn_GidisDonus.TabStop = true;
            this.rdbtn_GidisDonus.Text = "GİDİŞ - DÖNÜŞ";
            this.rdbtn_GidisDonus.UseVisualStyleBackColor = true;
            this.rdbtn_GidisDonus.CheckedChanged += new System.EventHandler(this.rdbtn_GidisDonus_CheckedChanged);
            // 
            // rdbtn_TekYon
            // 
            this.rdbtn_TekYon.AutoSize = true;
            this.rdbtn_TekYon.Location = new System.Drawing.Point(107, 49);
            this.rdbtn_TekYon.Name = "rdbtn_TekYon";
            this.rdbtn_TekYon.Size = new System.Drawing.Size(89, 21);
            this.rdbtn_TekYon.TabIndex = 0;
            this.rdbtn_TekYon.TabStop = true;
            this.rdbtn_TekYon.Text = "TEK YÖN";
            this.rdbtn_TekYon.UseVisualStyleBackColor = true;
            this.rdbtn_TekYon.CheckedChanged += new System.EventHandler(this.rdbtn_TekYon_CheckedChanged);
            // 
            // frmSellTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.grp_BiletSatis);
            this.Name = "frmSellTicket";
            this.Text = "frmSellTicket";
            this.Load += new System.EventHandler(this.frmSellTicket_Load);
            this.grp_BiletSatis.ResumeLayout(false);
            this.grp_BiletSatis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_BiletSatis;
        private System.Windows.Forms.Label lbl_DonusTarihi;
        private System.Windows.Forms.Label lbl_GidisTarihi;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.DateTimePicker dtp_Donus;
        private System.Windows.Forms.DateTimePicker dtp_Gidis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Donus;
        private System.Windows.Forms.ComboBox cmb_Gidis;
        private System.Windows.Forms.RadioButton rdbtn_GidisDonus;
        private System.Windows.Forms.RadioButton rdbtn_TekYon;
    }
}