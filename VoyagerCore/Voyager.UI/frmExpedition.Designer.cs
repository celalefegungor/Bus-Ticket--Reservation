namespace Voyager.UI
{
    partial class frmExpedition
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
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHostes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDrivers = new System.Windows.Forms.ComboBox();
            this.dGridExpedition = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtpEstimated = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.chbHasSnack = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGridExpedition)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRoute
            // 
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(84, 113);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(304, 21);
            this.cmbRoute.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Host";
            // 
            // cmbHostes
            // 
            this.cmbHostes.FormattingEnabled = true;
            this.cmbHostes.Location = new System.Drawing.Point(84, 76);
            this.cmbHostes.Name = "cmbHostes";
            this.cmbHostes.Size = new System.Drawing.Size(304, 21);
            this.cmbHostes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Driver";
            // 
            // cmbDrivers
            // 
            this.cmbDrivers.FormattingEnabled = true;
            this.cmbDrivers.Location = new System.Drawing.Point(84, 42);
            this.cmbDrivers.Name = "cmbDrivers";
            this.cmbDrivers.Size = new System.Drawing.Size(304, 21);
            this.cmbDrivers.TabIndex = 5;
            // 
            // dGridExpedition
            // 
            this.dGridExpedition.AllowUserToAddRows = false;
            this.dGridExpedition.AllowUserToDeleteRows = false;
            this.dGridExpedition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridExpedition.Location = new System.Drawing.Point(15, 268);
            this.dGridExpedition.Name = "dGridExpedition";
            this.dGridExpedition.ReadOnly = true;
            this.dGridExpedition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridExpedition.Size = new System.Drawing.Size(773, 170);
            this.dGridExpedition.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(473, 76);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.Location = new System.Drawing.Point(84, 216);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(200, 20);
            this.dtpDeparture.TabIndex = 8;
            // 
            // dtpEstimated
            // 
            this.dtpEstimated.Location = new System.Drawing.Point(84, 242);
            this.dtpEstimated.Name = "dtpEstimated";
            this.dtpEstimated.Size = new System.Drawing.Size(200, 20);
            this.dtpEstimated.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bus";
            // 
            // cmbBus
            // 
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(84, 13);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(304, 21);
            this.cmbBus.TabIndex = 11;
            // 
            // chbHasSnack
            // 
            this.chbHasSnack.AutoSize = true;
            this.chbHasSnack.Location = new System.Drawing.Point(84, 162);
            this.chbHasSnack.Name = "chbHasSnack";
            this.chbHasSnack.Size = new System.Drawing.Size(99, 17);
            this.chbHasSnack.TabIndex = 12;
            this.chbHasSnack.Text = "Yemek Servisi?";
            this.chbHasSnack.UseVisualStyleBackColor = true;
            // 
            // frmExpedition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chbHasSnack);
            this.Controls.Add(this.cmbBus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEstimated);
            this.Controls.Add(this.dtpDeparture);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dGridExpedition);
            this.Controls.Add(this.cmbDrivers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbHostes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRoute);
            this.Name = "frmExpedition";
            this.Text = "frmExpedition";
            this.Load += new System.EventHandler(this.frmExpedition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridExpedition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHostes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDrivers;
        private System.Windows.Forms.DataGridView dGridExpedition;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.DateTimePicker dtpEstimated;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.CheckBox chbHasSnack;
    }
}