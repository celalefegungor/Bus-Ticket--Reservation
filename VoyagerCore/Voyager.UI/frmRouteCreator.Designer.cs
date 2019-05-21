namespace Voyager.UI
{
    partial class frmRouteCreator
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
            this.cmb_KalkisYeri = new System.Windows.Forms.ComboBox();
            this.cmb_VarisYeri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmr_Mesafe = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgw_RouteList = new System.Windows.Forms.DataGridView();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Mesafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_RouteList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_KalkisYeri
            // 
            this.cmb_KalkisYeri.FormattingEnabled = true;
            this.cmb_KalkisYeri.Items.AddRange(new object[] {
            "İstanbul",
            "İzmir",
            "Ankara",
            "Bursa"});
            this.cmb_KalkisYeri.Location = new System.Drawing.Point(127, 19);
            this.cmb_KalkisYeri.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_KalkisYeri.Name = "cmb_KalkisYeri";
            this.cmb_KalkisYeri.Size = new System.Drawing.Size(145, 21);
            this.cmb_KalkisYeri.TabIndex = 0;
            // 
            // cmb_VarisYeri
            // 
            this.cmb_VarisYeri.FormattingEnabled = true;
            this.cmb_VarisYeri.Items.AddRange(new object[] {
            "Edirne",
            "Kırklareli",
            "Tekirdağ",
            "Aydın",
            "Adana",
            "Mersin"});
            this.cmb_VarisYeri.Location = new System.Drawing.Point(127, 62);
            this.cmb_VarisYeri.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_VarisYeri.Name = "cmb_VarisYeri";
            this.cmb_VarisYeri.Size = new System.Drawing.Size(145, 21);
            this.cmb_VarisYeri.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "KALKIŞ YERİ : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "VARIŞ YERİ : ";
            // 
            // nmr_Mesafe
            // 
            this.nmr_Mesafe.Location = new System.Drawing.Point(128, 107);
            this.nmr_Mesafe.Margin = new System.Windows.Forms.Padding(2);
            this.nmr_Mesafe.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nmr_Mesafe.Name = "nmr_Mesafe";
            this.nmr_Mesafe.Size = new System.Drawing.Size(144, 20);
            this.nmr_Mesafe.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "MESAFE : ";
            // 
            // dgw_RouteList
            // 
            this.dgw_RouteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_RouteList.Location = new System.Drawing.Point(13, 272);
            this.dgw_RouteList.Margin = new System.Windows.Forms.Padding(2);
            this.dgw_RouteList.Name = "dgw_RouteList";
            this.dgw_RouteList.RowTemplate.Height = 24;
            this.dgw_RouteList.Size = new System.Drawing.Size(578, 193);
            this.dgw_RouteList.TabIndex = 6;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(356, 96);
            this.btn_Ekle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(114, 29);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "KALKIŞ SAATİ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "VARIŞ SAATİ:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(172, 149);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(172, 186);
            this.maskedTextBox3.Mask = "00:00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 8;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // frmRouteCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.dgw_RouteList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmr_Mesafe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_VarisYeri);
            this.Controls.Add(this.cmb_KalkisYeri);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRouteCreator";
            this.Text = "frmRouteCreator";
            this.Load += new System.EventHandler(this.frmRouteCreator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Mesafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_RouteList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_KalkisYeri;
        private System.Windows.Forms.ComboBox cmb_VarisYeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmr_Mesafe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgw_RouteList;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
    }
}