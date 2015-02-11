namespace Autoskola
{
    partial class _07frmDodajNovoVozilo
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
            this.lblDodajNovoVozilo = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblOdustani = new System.Windows.Forms.Label();
            this.pbOdustani = new System.Windows.Forms.PictureBox();
            this.lblPohrani = new System.Windows.Forms.Label();
            this.pbPohrani = new System.Windows.Forms.PictureBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOdustani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPohrani)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDodajNovoVozilo
            // 
            this.lblDodajNovoVozilo.AutoSize = true;
            this.lblDodajNovoVozilo.BackColor = System.Drawing.Color.Transparent;
            this.lblDodajNovoVozilo.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDodajNovoVozilo.Location = new System.Drawing.Point(195, 29);
            this.lblDodajNovoVozilo.Name = "lblDodajNovoVozilo";
            this.lblDodajNovoVozilo.Size = new System.Drawing.Size(425, 49);
            this.lblDodajNovoVozilo.TabIndex = 3;
            this.lblDodajNovoVozilo.Text = "DODAJ NOVO VOZILO";
            this.lblDodajNovoVozilo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDodajNovoVozilo.UseCompatibleTextRendering = true;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.BackColor = System.Drawing.Color.Transparent;
            this.lblNaziv.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(300, 185);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 18);
            this.lblNaziv.TabIndex = 4;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNaziv.Location = new System.Drawing.Point(412, 178);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 5;
            // 
            // lblOdustani
            // 
            this.lblOdustani.AutoSize = true;
            this.lblOdustani.BackColor = System.Drawing.Color.Transparent;
            this.lblOdustani.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdustani.Location = new System.Drawing.Point(445, 331);
            this.lblOdustani.Name = "lblOdustani";
            this.lblOdustani.Size = new System.Drawing.Size(68, 18);
            this.lblOdustani.TabIndex = 40;
            this.lblOdustani.Text = "Odustani";
            // 
            // pbOdustani
            // 
            this.pbOdustani.BackgroundImage = global::Autoskola.Properties.Resources.pohrana_odustani_gumb;
            this.pbOdustani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOdustani.Location = new System.Drawing.Point(438, 352);
            this.pbOdustani.Name = "pbOdustani";
            this.pbOdustani.Size = new System.Drawing.Size(75, 70);
            this.pbOdustani.TabIndex = 39;
            this.pbOdustani.TabStop = false;
            this.pbOdustani.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblPohrani
            // 
            this.lblPohrani.AutoSize = true;
            this.lblPohrani.BackColor = System.Drawing.Color.Transparent;
            this.lblPohrani.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPohrani.Location = new System.Drawing.Point(300, 331);
            this.lblPohrani.Name = "lblPohrani";
            this.lblPohrani.Size = new System.Drawing.Size(60, 18);
            this.lblPohrani.TabIndex = 38;
            this.lblPohrani.Text = "Pohrani";
            // 
            // pbPohrani
            // 
            this.pbPohrani.BackColor = System.Drawing.Color.White;
            this.pbPohrani.BackgroundImage = global::Autoskola.Properties.Resources.pohrana_spremi_gumb;
            this.pbPohrani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPohrani.Location = new System.Drawing.Point(290, 352);
            this.pbPohrani.Name = "pbPohrani";
            this.pbPohrani.Size = new System.Drawing.Size(75, 70);
            this.pbPohrani.TabIndex = 37;
            this.pbPohrani.TabStop = false;
            this.pbPohrani.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.BackColor = System.Drawing.Color.Transparent;
            this.lblKategorija.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKategorija.Location = new System.Drawing.Point(300, 221);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(75, 18);
            this.lblKategorija.TabIndex = 41;
            this.lblKategorija.Text = "Kategorija";
            // 
            // cbKategorija
            // 
            this.cbKategorija.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(412, 218);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(100, 23);
            this.cbKategorija.TabIndex = 42;
            // 
            // _07frmDodajNovoVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Autoskola.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(814, 492);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.lblOdustani);
            this.Controls.Add(this.pbOdustani);
            this.Controls.Add(this.lblPohrani);
            this.Controls.Add(this.pbPohrani);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblDodajNovoVozilo);
            this.Name = "_07frmDodajNovoVozilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NadJos - Novo vozilo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._7aForma_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbOdustani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPohrani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDodajNovoVozilo;
        public System.Windows.Forms.TextBox txtNaziv;
        public System.Windows.Forms.ComboBox cbKategorija;
        public System.Windows.Forms.Label lblNaziv;
        public System.Windows.Forms.Label lblOdustani;
        public System.Windows.Forms.PictureBox pbOdustani;
        public System.Windows.Forms.Label lblPohrani;
        public System.Windows.Forms.PictureBox pbPohrani;
        public System.Windows.Forms.Label lblKategorija;
    }
}