namespace Autoskola
{
    partial class _06frmKatalogVozila
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
            this.lblKatalog = new System.Windows.Forms.Label();
            this.pbDodaj = new System.Windows.Forms.PictureBox();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.lblObrisi = new System.Windows.Forms.Label();
            this.pbObrisi = new System.Windows.Forms.PictureBox();
            this.lblDodajKategoriju = new System.Windows.Forms.Label();
            this.pbDodajKategoriju = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.dgwKatalog = new System.Windows.Forms.DataGridView();
            this.voziloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbDodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObrisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDodajKategoriju)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKatalog
            // 
            this.lblKatalog.AutoSize = true;
            this.lblKatalog.BackColor = System.Drawing.Color.Transparent;
            this.lblKatalog.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKatalog.Location = new System.Drawing.Point(231, 29);
            this.lblKatalog.Name = "lblKatalog";
            this.lblKatalog.Size = new System.Drawing.Size(352, 49);
            this.lblKatalog.TabIndex = 2;
            this.lblKatalog.Text = "KATALOG VOZILA";
            this.lblKatalog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKatalog.UseCompatibleTextRendering = true;
            // 
            // pbDodaj
            // 
            this.pbDodaj.BackgroundImage = global::Autoskola.Properties.Resources.noviauto;
            this.pbDodaj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDodaj.Location = new System.Drawing.Point(564, 127);
            this.pbDodaj.Name = "pbDodaj";
            this.pbDodaj.Size = new System.Drawing.Size(70, 70);
            this.pbDodaj.TabIndex = 3;
            this.pbDodaj.TabStop = false;
            this.pbDodaj.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.BackColor = System.Drawing.Color.Transparent;
            this.lblDodaj.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDodaj.Location = new System.Drawing.Point(537, 106);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(118, 18);
            this.lblDodaj.TabIndex = 4;
            this.lblDodaj.Text = "Dodaj novo vozilo";
            // 
            // lblObrisi
            // 
            this.lblObrisi.AutoSize = true;
            this.lblObrisi.BackColor = System.Drawing.Color.Transparent;
            this.lblObrisi.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObrisi.Location = new System.Drawing.Point(561, 221);
            this.lblObrisi.Name = "lblObrisi";
            this.lblObrisi.Size = new System.Drawing.Size(88, 18);
            this.lblObrisi.TabIndex = 6;
            this.lblObrisi.Text = "Obriši vozilo";
            // 
            // pbObrisi
            // 
            this.pbObrisi.BackgroundImage = global::Autoskola.Properties.Resources.brisiautogumb;
            this.pbObrisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbObrisi.Location = new System.Drawing.Point(564, 242);
            this.pbObrisi.Name = "pbObrisi";
            this.pbObrisi.Size = new System.Drawing.Size(70, 70);
            this.pbObrisi.TabIndex = 5;
            this.pbObrisi.TabStop = false;
            this.pbObrisi.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblDodajKategoriju
            // 
            this.lblDodajKategoriju.AutoSize = true;
            this.lblDodajKategoriju.BackColor = System.Drawing.Color.Transparent;
            this.lblDodajKategoriju.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDodajKategoriju.Location = new System.Drawing.Point(504, 341);
            this.lblDodajKategoriju.Name = "lblDodajKategoriju";
            this.lblDodajKategoriju.Size = new System.Drawing.Size(193, 18);
            this.lblDodajKategoriju.TabIndex = 8;
            this.lblDodajKategoriju.Text = "Dodaj novu kategoriju vozila";
            // 
            // pbDodajKategoriju
            // 
            this.pbDodajKategoriju.BackgroundImage = global::Autoskola.Properties.Resources.kategorije_vozila;
            this.pbDodajKategoriju.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDodajKategoriju.Location = new System.Drawing.Point(564, 362);
            this.pbDodajKategoriju.Name = "pbDodajKategoriju";
            this.pbDodajKategoriju.Size = new System.Drawing.Size(70, 70);
            this.pbDodajKategoriju.TabIndex = 7;
            this.pbDodajKategoriju.TabStop = false;
            this.pbDodajKategoriju.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.BackgroundImage = global::Autoskola.Properties.Resources.back_button_tocan;
            this.pbBack.Location = new System.Drawing.Point(752, 440);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(50, 50);
            this.pbBack.TabIndex = 9;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // dgwKatalog
            // 
            this.dgwKatalog.AllowUserToAddRows = false;
            this.dgwKatalog.AllowUserToDeleteRows = false;
            this.dgwKatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voziloID,
            this.naziv});
            this.dgwKatalog.Location = new System.Drawing.Point(118, 106);
            this.dgwKatalog.MultiSelect = false;
            this.dgwKatalog.Name = "dgwKatalog";
            this.dgwKatalog.ReadOnly = true;
            this.dgwKatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwKatalog.Size = new System.Drawing.Size(368, 335);
            this.dgwKatalog.TabIndex = 10;
            // 
            // voziloID
            // 
            this.voziloID.FillWeight = 20F;
            this.voziloID.HeaderText = "ID";
            this.voziloID.Name = "voziloID";
            this.voziloID.ReadOnly = true;
            this.voziloID.Width = 25;
            // 
            // naziv
            // 
            this.naziv.FillWeight = 80F;
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            this.naziv.Width = 300;
            // 
            // _06frmKatalogVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Autoskola.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(814, 492);
            this.Controls.Add(this.dgwKatalog);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.lblDodajKategoriju);
            this.Controls.Add(this.pbDodajKategoriju);
            this.Controls.Add(this.lblObrisi);
            this.Controls.Add(this.pbObrisi);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.pbDodaj);
            this.Controls.Add(this.lblKatalog);
            this.Name = "_06frmKatalogVozila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NadJos - Katalog vozila";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._6aForma_FormClosed);
            this.Load += new System.EventHandler(this._6aForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObrisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDodajKategoriju)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKatalog;
        public System.Windows.Forms.DataGridView dgwKatalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        public System.Windows.Forms.PictureBox pbDodaj;
        public System.Windows.Forms.Label lblDodaj;
        public System.Windows.Forms.Label lblObrisi;
        public System.Windows.Forms.PictureBox pbObrisi;
        public System.Windows.Forms.Label lblDodajKategoriju;
        public System.Windows.Forms.PictureBox pbDodajKategoriju;
        public System.Windows.Forms.PictureBox pbBack;
    }
}