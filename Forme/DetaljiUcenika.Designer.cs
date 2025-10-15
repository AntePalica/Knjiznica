namespace Knjiznica.Forme
{
    partial class DetaljiUcenika
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
            this.Ime = new System.Windows.Forms.Label();
            this.tbOIB = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.Prezime = new System.Windows.Forms.Label();
            this.Adresa = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.Razred = new System.Windows.Forms.Label();
            this.cbRazred = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OIB";
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(48, 67);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(24, 13);
            this.Ime.TabIndex = 1;
            this.Ime.Text = "Ime";
            // 
            // tbOIB
            // 
            this.tbOIB.Location = new System.Drawing.Point(101, 28);
            this.tbOIB.Name = "tbOIB";
            this.tbOIB.Size = new System.Drawing.Size(203, 20);
            this.tbOIB.TabIndex = 2;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(101, 67);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(203, 20);
            this.tbIme.TabIndex = 3;
            // 
            // Prezime
            // 
            this.Prezime.AutoSize = true;
            this.Prezime.Location = new System.Drawing.Point(48, 104);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(44, 13);
            this.Prezime.TabIndex = 4;
            this.Prezime.Text = "Prezime";
            // 
            // Adresa
            // 
            this.Adresa.AutoSize = true;
            this.Adresa.Location = new System.Drawing.Point(49, 140);
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(40, 13);
            this.Adresa.TabIndex = 5;
            this.Adresa.Text = "Adresa";
            this.Adresa.Click += new System.EventHandler(this.label3_Click);
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(49, 174);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(43, 13);
            this.Telefon.TabIndex = 6;
            this.Telefon.Text = "Telefon";
            this.Telefon.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(101, 101);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(203, 20);
            this.tbPrezime.TabIndex = 7;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(101, 137);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(203, 20);
            this.tbAdresa.TabIndex = 8;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(101, 171);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(203, 20);
            this.tbTelefon.TabIndex = 9;
            this.tbTelefon.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Razred
            // 
            this.Razred.AutoSize = true;
            this.Razred.Location = new System.Drawing.Point(51, 205);
            this.Razred.Name = "Razred";
            this.Razred.Size = new System.Drawing.Size(41, 13);
            this.Razred.TabIndex = 10;
            this.Razred.Text = "Razred";
            // 
            // cbRazred
            // 
            this.cbRazred.FormattingEnabled = true;
            this.cbRazred.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbRazred.Location = new System.Drawing.Point(101, 205);
            this.cbRazred.Name = "cbRazred";
            this.cbRazred.Size = new System.Drawing.Size(71, 21);
            this.cbRazred.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(97, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // DetaljiUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 347);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbRazred);
            this.Controls.Add(this.Razred);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.tbOIB);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.label1);
            this.Name = "DetaljiUcenika";
            this.Text = "Detalji Učenika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.TextBox tbOIB;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label Prezime;
        private System.Windows.Forms.Label Adresa;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label Razred;
        private System.Windows.Forms.ComboBox cbRazred;
        private System.Windows.Forms.Button btnSave;
    }
}