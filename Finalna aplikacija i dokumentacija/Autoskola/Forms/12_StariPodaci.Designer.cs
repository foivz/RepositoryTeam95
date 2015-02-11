namespace Autoskola
{
    partial class _12frmPodaciOPol
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
            this.lblPodaci = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.OIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instruktor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPodaci
            // 
            this.lblPodaci.AutoSize = true;
            this.lblPodaci.BackColor = System.Drawing.Color.Transparent;
            this.lblPodaci.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPodaci.Location = new System.Drawing.Point(53, 29);
            this.lblPodaci.Name = "lblPodaci";
            this.lblPodaci.Size = new System.Drawing.Size(709, 49);
            this.lblPodaci.TabIndex = 10;
            this.lblPodaci.Text = "Podaci o polazniku i satovima vožnje";
            this.lblPodaci.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPodaci.UseCompatibleTextRendering = true;
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.BackgroundImage = global::Autoskola.Properties.Resources.back_button_tocan;
            this.pbBack.Location = new System.Drawing.Point(752, 439);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(50, 50);
            this.pbBack.TabIndex = 36;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OIB,
            this.ime,
            this.prezime,
            this.Instruktor,
            this.ukupno});
            this.dgvPodaci.Location = new System.Drawing.Point(62, 110);
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.Size = new System.Drawing.Size(691, 129);
            this.dgvPodaci.TabIndex = 37;
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
            // Instruktor
            // 
            this.Instruktor.HeaderText = "Instruktor";
            this.Instruktor.Name = "Instruktor";
            this.Instruktor.ReadOnly = true;
            this.Instruktor.Width = 150;
            // 
            // ukupno
            // 
            this.ukupno.HeaderText = "Ukupno trajanje vožnje";
            this.ukupno.Name = "ukupno";
            this.ukupno.ReadOnly = true;
            this.ukupno.Width = 200;
            // 
            // _12frmPodaciOPol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Autoskola.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(814, 492);
            this.Controls.Add(this.dgvPodaci);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.lblPodaci);
            this.Name = "_12frmPodaciOPol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NadJos - Podaci o polazniku";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._12aForma_FormClosed);
            this.Load += new System.EventHandler(this._12frmPodaciOPol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPodaci;
        public System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn OIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instruktor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupno;
    }
}