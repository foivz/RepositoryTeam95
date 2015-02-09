namespace Autoskola
{
    partial class _09frmEvidencijaPol
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
            this.lblEvidencija = new System.Windows.Forms.Label();
            this.pbEvidentirajPol = new System.Windows.Forms.PictureBox();
            this.lblEvidentirajPol = new System.Windows.Forms.Label();
            this.pbStareEvidencije = new System.Windows.Forms.PictureBox();
            this.lblStareEvidencije = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.dgwEvidencijaPol = new System.Windows.Forms.DataGridView();
            this.OIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbEvidentirajPol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStareEvidencije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEvidencijaPol)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEvidencija
            // 
            this.lblEvidencija.AutoSize = true;
            this.lblEvidencija.BackColor = System.Drawing.Color.Transparent;
            this.lblEvidencija.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEvidencija.Location = new System.Drawing.Point(166, 29);
            this.lblEvidencija.Name = "lblEvidencija";
            this.lblEvidencija.Size = new System.Drawing.Size(463, 47);
            this.lblEvidencija.TabIndex = 1;
            this.lblEvidencija.Text = "EVIDENCIJA POLAZNIKA";
            this.lblEvidencija.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEvidencija.UseCompatibleTextRendering = true;
            // 
            // pbEvidentirajPol
            // 
            this.pbEvidentirajPol.BackColor = System.Drawing.Color.White;
            this.pbEvidentirajPol.BackgroundImage = global::Autoskola.Properties.Resources.evidentiraj_ikona;
            this.pbEvidentirajPol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEvidentirajPol.Location = new System.Drawing.Point(543, 155);
            this.pbEvidentirajPol.Name = "pbEvidentirajPol";
            this.pbEvidentirajPol.Size = new System.Drawing.Size(75, 68);
            this.pbEvidentirajPol.TabIndex = 10;
            this.pbEvidentirajPol.TabStop = false;
            this.pbEvidentirajPol.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblEvidentirajPol
            // 
            this.lblEvidentirajPol.AutoSize = true;
            this.lblEvidentirajPol.BackColor = System.Drawing.Color.Transparent;
            this.lblEvidentirajPol.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEvidentirajPol.Location = new System.Drawing.Point(504, 134);
            this.lblEvidentirajPol.Name = "lblEvidentirajPol";
            this.lblEvidentirajPol.Size = new System.Drawing.Size(147, 18);
            this.lblEvidentirajPol.TabIndex = 11;
            this.lblEvidentirajPol.Text = "Evidentiraj polaznika";
            // 
            // pbStareEvidencije
            // 
            this.pbStareEvidencije.BackColor = System.Drawing.Color.White;
            this.pbStareEvidencije.BackgroundImage = global::Autoskola.Properties.Resources.icon_files;
            this.pbStareEvidencije.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStareEvidencije.Location = new System.Drawing.Point(543, 306);
            this.pbStareEvidencije.Name = "pbStareEvidencije";
            this.pbStareEvidencije.Size = new System.Drawing.Size(75, 75);
            this.pbStareEvidencije.TabIndex = 12;
            this.pbStareEvidencije.TabStop = false;
            this.pbStareEvidencije.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblStareEvidencije
            // 
            this.lblStareEvidencije.AutoSize = true;
            this.lblStareEvidencije.BackColor = System.Drawing.Color.Transparent;
            this.lblStareEvidencije.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStareEvidencije.Location = new System.Drawing.Point(515, 285);
            this.lblStareEvidencije.Name = "lblStareEvidencije";
            this.lblStareEvidencije.Size = new System.Drawing.Size(116, 18);
            this.lblStareEvidencije.TabIndex = 13;
            this.lblStareEvidencije.Text = "Stare evidencije";
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.BackgroundImage = global::Autoskola.Properties.Resources.back_button_tocan;
            this.pbBack.Location = new System.Drawing.Point(742, 430);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(50, 50);
            this.pbBack.TabIndex = 14;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // dgwEvidencijaPol
            // 
            this.dgwEvidencijaPol.AllowUserToAddRows = false;
            this.dgwEvidencijaPol.AllowUserToDeleteRows = false;
            this.dgwEvidencijaPol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEvidencijaPol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OIB,
            this.ime,
            this.prezime});
            this.dgwEvidencijaPol.Location = new System.Drawing.Point(94, 108);
            this.dgwEvidencijaPol.Name = "dgwEvidencijaPol";
            this.dgwEvidencijaPol.ReadOnly = true;
            this.dgwEvidencijaPol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwEvidencijaPol.Size = new System.Drawing.Size(358, 295);
            this.dgwEvidencijaPol.TabIndex = 15;
            // 
            // OIB
            // 
            this.OIB.HeaderText = "OIB";
            this.OIB.Name = "OIB";
            this.OIB.ReadOnly = true;
            this.OIB.Width = 80;
            // 
            // ime
            // 
            this.ime.HeaderText = "Ime";
            this.ime.Name = "ime";
            this.ime.ReadOnly = true;
            this.ime.Width = 120;
            // 
            // prezime
            // 
            this.prezime.HeaderText = "Prezime";
            this.prezime.Name = "prezime";
            this.prezime.ReadOnly = true;
            this.prezime.Width = 120;
            // 
            // _09frmEvidencijaPol
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Autoskola.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(814, 492);
            this.Controls.Add(this.dgwEvidencijaPol);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.lblStareEvidencije);
            this.Controls.Add(this.pbStareEvidencije);
            this.Controls.Add(this.lblEvidentirajPol);
            this.Controls.Add(this.pbEvidentirajPol);
            this.Controls.Add(this.lblEvidencija);
            this.Name = "_09frmEvidencijaPol";
            this.Text = "NadJos - Evidencija polaznika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._9aForma_FormClosed);
            this.Load += new System.EventHandler(this._09frmEvidencijaPol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEvidentirajPol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStareEvidencije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEvidencijaPol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvidencija;
        public System.Windows.Forms.PictureBox pbEvidentirajPol;
        public System.Windows.Forms.Label lblEvidentirajPol;
        public System.Windows.Forms.PictureBox pbStareEvidencije;
        public System.Windows.Forms.Label lblStareEvidencije;
        public System.Windows.Forms.PictureBox pbBack;
        public System.Windows.Forms.DataGridView dgwEvidencijaPol;
        private System.Windows.Forms.DataGridViewTextBoxColumn OIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
    }
}