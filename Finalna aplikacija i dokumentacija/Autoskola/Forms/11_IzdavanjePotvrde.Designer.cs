namespace Autoskola
{
    partial class _11frmIzdavanjePotvrde
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
            this.lblIzdavanje = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbIzdajPotvrdu = new System.Windows.Forms.PictureBox();
            this.lblIzdajPotvrdu = new System.Windows.Forms.Label();
            this.dgwIzdavanjePotvrde = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIzdajPotvrdu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIzdavanjePotvrde)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIzdavanje
            // 
            this.lblIzdavanje.AutoSize = true;
            this.lblIzdavanje.BackColor = System.Drawing.Color.Transparent;
            this.lblIzdavanje.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzdavanje.Location = new System.Drawing.Point(192, 29);
            this.lblIzdavanje.Name = "lblIzdavanje";
            this.lblIzdavanje.Size = new System.Drawing.Size(430, 49);
            this.lblIzdavanje.TabIndex = 0;
            this.lblIzdavanje.Text = "IZDAVANJE POTVRDE";
            this.lblIzdavanje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblIzdavanje.UseCompatibleTextRendering = true;
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.BackgroundImage = global::Autoskola.Properties.Resources.back_button_tocan;
            this.pbBack.Location = new System.Drawing.Point(752, 430);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(50, 50);
            this.pbBack.TabIndex = 10;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pbIzdajPotvrdu
            // 
            this.pbIzdajPotvrdu.BackColor = System.Drawing.Color.White;
            this.pbIzdajPotvrdu.BackgroundImage = global::Autoskola.Properties.Resources.School_Diploma_512;
            this.pbIzdajPotvrdu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIzdajPotvrdu.Location = new System.Drawing.Point(520, 222);
            this.pbIzdajPotvrdu.Name = "pbIzdajPotvrdu";
            this.pbIzdajPotvrdu.Size = new System.Drawing.Size(77, 69);
            this.pbIzdajPotvrdu.TabIndex = 12;
            this.pbIzdajPotvrdu.TabStop = false;
            this.pbIzdajPotvrdu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblIzdajPotvrdu
            // 
            this.lblIzdajPotvrdu.AutoSize = true;
            this.lblIzdajPotvrdu.BackColor = System.Drawing.Color.Transparent;
            this.lblIzdajPotvrdu.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzdajPotvrdu.Location = new System.Drawing.Point(517, 201);
            this.lblIzdajPotvrdu.Name = "lblIzdajPotvrdu";
            this.lblIzdajPotvrdu.Size = new System.Drawing.Size(90, 18);
            this.lblIzdajPotvrdu.TabIndex = 11;
            this.lblIzdajPotvrdu.Text = "Izdaj potvrdu";
            // 
            // dgwIzdavanjePotvrde
            // 
            this.dgwIzdavanjePotvrde.AllowUserToAddRows = false;
            this.dgwIzdavanjePotvrde.AllowUserToDeleteRows = false;
            this.dgwIzdavanjePotvrde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIzdavanjePotvrde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ime,
            this.prezime});
            this.dgwIzdavanjePotvrde.Location = new System.Drawing.Point(105, 136);
            this.dgwIzdavanjePotvrde.Name = "dgwIzdavanjePotvrde";
            this.dgwIzdavanjePotvrde.ReadOnly = true;
            this.dgwIzdavanjePotvrde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwIzdavanjePotvrde.Size = new System.Drawing.Size(343, 279);
            this.dgwIzdavanjePotvrde.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "OIB";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // _11frmIzdavanjePotvrde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Autoskola.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(814, 492);
            this.Controls.Add(this.dgwIzdavanjePotvrde);
            this.Controls.Add(this.pbIzdajPotvrdu);
            this.Controls.Add(this.lblIzdajPotvrdu);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.lblIzdavanje);
            this.Name = "_11frmIzdavanjePotvrde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NadJos - Izdavanje potvrde";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._11aForma_FormClosed);
            this.Load += new System.EventHandler(this._11frmIzdavanjePotvrde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIzdajPotvrdu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIzdavanjePotvrde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzdavanje;
        public System.Windows.Forms.PictureBox pbBack;
        public System.Windows.Forms.PictureBox pbIzdajPotvrdu;
        public System.Windows.Forms.Label lblIzdajPotvrdu;
        public System.Windows.Forms.DataGridView dgwIzdavanjePotvrde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
    }
}