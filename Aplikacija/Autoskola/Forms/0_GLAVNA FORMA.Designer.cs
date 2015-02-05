namespace Autoskola
{
    partial class _0frmGlavnaForma
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
            this.lblKIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtKIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.pnUgasi = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnUgasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKIme
            // 
            this.lblKIme.AutoSize = true;
            this.lblKIme.BackColor = System.Drawing.Color.Transparent;
            this.lblKIme.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKIme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKIme.Location = new System.Drawing.Point(279, 240);
            this.lblKIme.Name = "lblKIme";
            this.lblKIme.Size = new System.Drawing.Size(131, 23);
            this.lblKIme.TabIndex = 1;
            this.lblKIme.Text = "Korisničko ime:";
            this.lblKIme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKIme.UseCompatibleTextRendering = true;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.BackColor = System.Drawing.Color.Transparent;
            this.lblLozinka.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLozinka.Location = new System.Drawing.Point(279, 264);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(74, 23);
            this.lblLozinka.TabIndex = 2;
            this.lblLozinka.Text = "Lozinka:";
            this.lblLozinka.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLozinka.UseCompatibleTextRendering = true;
            // 
            // txtKIme
            // 
            this.txtKIme.BackColor = System.Drawing.Color.Honeydew;
            this.txtKIme.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKIme.Location = new System.Drawing.Point(439, 240);
            this.txtKIme.Name = "txtKIme";
            this.txtKIme.Size = new System.Drawing.Size(93, 20);
            this.txtKIme.TabIndex = 3;
            // 
            // txtLozinka
            // 
            this.txtLozinka.BackColor = System.Drawing.Color.Honeydew;
            this.txtLozinka.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLozinka.Location = new System.Drawing.Point(439, 265);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(93, 20);
            this.txtLozinka.TabIndex = 4;
            this.txtLozinka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.Thistle;
            this.btnPrijava.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijava.Location = new System.Drawing.Point(375, 302);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(90, 32);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnUgasi
            // 
            this.pnUgasi.BackColor = System.Drawing.Color.Transparent;
            this.pnUgasi.BackgroundImage = global::Autoskola.Properties.Resources.izlazz;
            this.pnUgasi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnUgasi.ErrorImage = null;
            this.pnUgasi.InitialImage = global::Autoskola.Properties.Resources._018513_glossy_black_3d_button_icon_symbols_shapes_power_button3;
            this.pnUgasi.Location = new System.Drawing.Point(752, 12);
            this.pnUgasi.Name = "pnUgasi";
            this.pnUgasi.Size = new System.Drawing.Size(50, 45);
            this.pnUgasi.TabIndex = 6;
            this.pnUgasi.TabStop = false;
            this.pnUgasi.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::Autoskola.Properties.Resources.logo_za_aplik;
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogo.Location = new System.Drawing.Point(12, 29);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 58);
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // _0frmGlavnaForma
            // 
            this.AcceptButton = this.btnPrijava;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Autoskola.Properties.Resources.Driving_School___CopyCopy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 492);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnUgasi);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKIme);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKIme);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "_0frmGlavnaForma";
            this.Text = "NadJos ";
            this.Enter += new System.EventHandler(this.button1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pnUgasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtKIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.PictureBox pnUgasi;
        private System.Windows.Forms.PictureBox pbLogo;
        public System.Windows.Forms.Button btnPrijava;
    }
}

