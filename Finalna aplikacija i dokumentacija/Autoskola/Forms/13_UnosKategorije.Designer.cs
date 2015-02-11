namespace Autoskola
{
    partial class _13frmUnosKat
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
            this.lblKatID = new System.Windows.Forms.Label();
            this.txtKatID = new System.Windows.Forms.TextBox();
            this.lblUnosKat = new System.Windows.Forms.Label();
            this.lblOdustani = new System.Windows.Forms.Label();
            this.pbOdustani = new System.Windows.Forms.PictureBox();
            this.lblPohrani = new System.Windows.Forms.Label();
            this.pbPohrani = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOdustani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPohrani)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKatID
            // 
            this.lblKatID.AutoSize = true;
            this.lblKatID.BackColor = System.Drawing.Color.Transparent;
            this.lblKatID.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKatID.Location = new System.Drawing.Point(296, 167);
            this.lblKatID.Name = "lblKatID";
            this.lblKatID.Size = new System.Drawing.Size(94, 18);
            this.lblKatID.TabIndex = 0;
            this.lblKatID.Text = "Kategorija ID";
            // 
            // txtKatID
            // 
            this.txtKatID.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKatID.Location = new System.Drawing.Point(432, 167);
            this.txtKatID.Name = "txtKatID";
            this.txtKatID.Size = new System.Drawing.Size(100, 20);
            this.txtKatID.TabIndex = 2;
            // 
            // lblUnosKat
            // 
            this.lblUnosKat.AutoSize = true;
            this.lblUnosKat.BackColor = System.Drawing.Color.Transparent;
            this.lblUnosKat.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUnosKat.Location = new System.Drawing.Point(138, 29);
            this.lblUnosKat.Name = "lblUnosKat";
            this.lblUnosKat.Size = new System.Drawing.Size(538, 49);
            this.lblUnosKat.TabIndex = 3;
            this.lblUnosKat.Text = "UNOS KATEGORIJE VOZILA";
            this.lblUnosKat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUnosKat.UseCompatibleTextRendering = true;
            // 
            // lblOdustani
            // 
            this.lblOdustani.AutoSize = true;
            this.lblOdustani.BackColor = System.Drawing.Color.Transparent;
            this.lblOdustani.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdustani.Location = new System.Drawing.Point(451, 331);
            this.lblOdustani.Name = "lblOdustani";
            this.lblOdustani.Size = new System.Drawing.Size(68, 18);
            this.lblOdustani.TabIndex = 44;
            this.lblOdustani.Text = "Odustani";
            // 
            // pbOdustani
            // 
            this.pbOdustani.BackgroundImage = global::Autoskola.Properties.Resources.pohrana_odustani_gumb;
            this.pbOdustani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOdustani.Location = new System.Drawing.Point(447, 352);
            this.pbOdustani.Name = "pbOdustani";
            this.pbOdustani.Size = new System.Drawing.Size(75, 70);
            this.pbOdustani.TabIndex = 43;
            this.pbOdustani.TabStop = false;
            this.pbOdustani.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblPohrani
            // 
            this.lblPohrani.AutoSize = true;
            this.lblPohrani.BackColor = System.Drawing.Color.Transparent;
            this.lblPohrani.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPohrani.Location = new System.Drawing.Point(305, 331);
            this.lblPohrani.Name = "lblPohrani";
            this.lblPohrani.Size = new System.Drawing.Size(60, 18);
            this.lblPohrani.TabIndex = 42;
            this.lblPohrani.Text = "Pohrani";
            // 
            // pbPohrani
            // 
            this.pbPohrani.BackColor = System.Drawing.Color.White;
            this.pbPohrani.BackgroundImage = global::Autoskola.Properties.Resources.pohrana_spremi_gumb;
            this.pbPohrani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPohrani.Location = new System.Drawing.Point(299, 352);
            this.pbPohrani.Name = "pbPohrani";
            this.pbPohrani.Size = new System.Drawing.Size(75, 70);
            this.pbPohrani.TabIndex = 41;
            this.pbPohrani.TabStop = false;
            this.pbPohrani.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // _13frmUnosKat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Autoskola.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(814, 492);
            this.Controls.Add(this.lblOdustani);
            this.Controls.Add(this.pbOdustani);
            this.Controls.Add(this.lblPohrani);
            this.Controls.Add(this.pbPohrani);
            this.Controls.Add(this.lblUnosKat);
            this.Controls.Add(this.txtKatID);
            this.Controls.Add(this.lblKatID);
            this.Name = "_13frmUnosKat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NadJos - Unos kategorije";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._13aForma_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbOdustani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPohrani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnosKat;
        public System.Windows.Forms.TextBox txtKatID;
        public System.Windows.Forms.Label lblKatID;
        public System.Windows.Forms.Label lblOdustani;
        public System.Windows.Forms.PictureBox pbOdustani;
        public System.Windows.Forms.Label lblPohrani;
        public System.Windows.Forms.PictureBox pbPohrani;
    }
}