namespace Autoskola
{
    partial class _04frmOsobe
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
            this.lblPZ = new System.Windows.Forms.Label();
            this.lblOdabir = new System.Windows.Forms.Label();
            this.rbPolaznici = new System.Windows.Forms.RadioButton();
            this.rbInstruktori = new System.Windows.Forms.RadioButton();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.lblDodaj = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAzuriraj = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgwOsobe = new System.Windows.Forms.DataGridView();
            this.OIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOsobe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPZ
            // 
            this.lblPZ.AutoSize = true;
            this.lblPZ.BackColor = System.Drawing.Color.Transparent;
            this.lblPZ.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPZ.Location = new System.Drawing.Point(201, 29);
            this.lblPZ.Name = "lblPZ";
            this.lblPZ.Size = new System.Drawing.Size(413, 41);
            this.lblPZ.TabIndex = 0;
            this.lblPZ.Text = "Polaznici/Zaposlenici";
            // 
            // lblOdabir
            // 
            this.lblOdabir.AutoSize = true;
            this.lblOdabir.BackColor = System.Drawing.Color.Transparent;
            this.lblOdabir.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdabir.Location = new System.Drawing.Point(29, 111);
            this.lblOdabir.Name = "lblOdabir";
            this.lblOdabir.Size = new System.Drawing.Size(164, 16);
            this.lblOdabir.TabIndex = 1;
            this.lblOdabir.Text = "Odaberi prema skupini";
            // 
            // rbPolaznici
            // 
            this.rbPolaznici.AutoSize = true;
            this.rbPolaznici.BackColor = System.Drawing.Color.Transparent;
            this.rbPolaznici.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPolaznici.Location = new System.Drawing.Point(208, 109);
            this.rbPolaznici.Name = "rbPolaznici";
            this.rbPolaznici.Size = new System.Drawing.Size(85, 22);
            this.rbPolaznici.TabIndex = 2;
            this.rbPolaznici.TabStop = true;
            this.rbPolaznici.Text = "Polaznici";
            this.rbPolaznici.UseVisualStyleBackColor = false;
            this.rbPolaznici.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbInstruktori
            // 
            this.rbInstruktori.AutoSize = true;
            this.rbInstruktori.BackColor = System.Drawing.Color.Transparent;
            this.rbInstruktori.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbInstruktori.Location = new System.Drawing.Point(299, 107);
            this.rbInstruktori.Name = "rbInstruktori";
            this.rbInstruktori.Size = new System.Drawing.Size(99, 22);
            this.rbInstruktori.TabIndex = 3;
            this.rbInstruktori.TabStop = true;
            this.rbInstruktori.Text = "Instruktori";
            this.rbInstruktori.UseVisualStyleBackColor = false;
            this.rbInstruktori.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.BackgroundImage = global::Autoskola.Properties.Resources.back_button_tocan;
            this.pbBack.Location = new System.Drawing.Point(752, 429);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(50, 50);
            this.pbBack.TabIndex = 10;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lblDodaj
            // 
            this.lblDodaj.AutoSize = true;
            this.lblDodaj.BackColor = System.Drawing.Color.Transparent;
            this.lblDodaj.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDodaj.Location = new System.Drawing.Point(536, 171);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(121, 18);
            this.lblDodaj.TabIndex = 12;
            this.lblDodaj.Text = "Dodaj novu osobu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Autoskola.Properties.Resources.nova_osoba;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(563, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblAzuriraj
            // 
            this.lblAzuriraj.AutoSize = true;
            this.lblAzuriraj.BackColor = System.Drawing.Color.Transparent;
            this.lblAzuriraj.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAzuriraj.Location = new System.Drawing.Point(555, 311);
            this.lblAzuriraj.Name = "lblAzuriraj";
            this.lblAzuriraj.Size = new System.Drawing.Size(102, 18);
            this.lblAzuriraj.TabIndex = 14;
            this.lblAzuriraj.Text = "Ažuriraj osobu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Autoskola.Properties.Resources.nova_osoba___Copy;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(563, 332);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dgwOsobe
            // 
            this.dgwOsobe.AllowUserToAddRows = false;
            this.dgwOsobe.AllowUserToDeleteRows = false;
            this.dgwOsobe.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwOsobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOsobe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OIB,
            this.ime,
            this.prezime});
            this.dgwOsobe.Location = new System.Drawing.Point(130, 152);
            this.dgwOsobe.Name = "dgwOsobe";
            this.dgwOsobe.ReadOnly = true;
            this.dgwOsobe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwOsobe.Size = new System.Drawing.Size(343, 285);
            this.dgwOsobe.TabIndex = 15;
            
            // 
            // OIB
            // 
            this.OIB.HeaderText = "OIB";
            this.OIB.Name = "OIB";
            this.OIB.ReadOnly = true;
            // 
            // ime
            // 
            this.ime.HeaderText = "Ime";
            this.ime.Name = "ime";
            this.ime.ReadOnly = true;
            // 
            // prezime
            // 
            this.prezime.HeaderText = "Prezime";
            this.prezime.Name = "prezime";
            this.prezime.ReadOnly = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.rbAdmin.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbAdmin.Location = new System.Drawing.Point(404, 107);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(69, 22);
            this.rbAdmin.TabIndex = 16;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = false;
            this.rbAdmin.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // _04frmOsobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Autoskola.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(814, 491);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.dgwOsobe);
            this.Controls.Add(this.lblAzuriraj);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.rbInstruktori);
            this.Controls.Add(this.rbPolaznici);
            this.Controls.Add(this.lblOdabir);
            this.Controls.Add(this.lblPZ);
            this.Name = "_04frmOsobe";
            this.Text = "NadJos - Osobe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._04_Osoba_FormClosed);
            this.Load += new System.EventHandler(this._04_Osoba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOsobe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn OIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        public System.Windows.Forms.DataGridView dgwOsobe;
        public System.Windows.Forms.Label lblOdabir;
        public System.Windows.Forms.RadioButton rbPolaznici;
        public System.Windows.Forms.RadioButton rbInstruktori;
        public System.Windows.Forms.PictureBox pbBack;
        public System.Windows.Forms.Label lblDodaj;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblAzuriraj;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.RadioButton rbAdmin;
    }
}