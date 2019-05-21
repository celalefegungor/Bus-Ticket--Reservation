namespace Voyager.UI
{
    partial class frmBus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.chbHasToilet = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dGridBus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGridBus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plaka";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(148, 45);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(121, 20);
            this.txtMake.TabIndex = 3;
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(148, 76);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(121, 20);
            this.txtPlate.TabIndex = 4;
            // 
            // chbHasToilet
            // 
            this.chbHasToilet.AutoSize = true;
            this.chbHasToilet.Location = new System.Drawing.Point(148, 122);
            this.chbHasToilet.Name = "chbHasToilet";
            this.chbHasToilet.Size = new System.Drawing.Size(103, 17);
            this.chbHasToilet.TabIndex = 5;
            this.chbHasToilet.Text = "Tuvaleti Var Mı?";
            this.chbHasToilet.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(148, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dGridBus
            // 
            this.dGridBus.AllowUserToAddRows = false;
            this.dGridBus.AllowUserToDeleteRows = false;
            this.dGridBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridBus.Location = new System.Drawing.Point(19, 266);
            this.dGridBus.Name = "dGridBus";
            this.dGridBus.ReadOnly = true;
            this.dGridBus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridBus.Size = new System.Drawing.Size(769, 150);
            this.dGridBus.TabIndex = 7;
            // 
            // frmBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGridBus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chbHasToilet);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBus";
            this.Text = "frmBus";
            this.Load += new System.EventHandler(this.frmBus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.CheckBox chbHasToilet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dGridBus;
    }
}