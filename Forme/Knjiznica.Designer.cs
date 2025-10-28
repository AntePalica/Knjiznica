namespace Knjiznica.Forme
{
    partial class frmKnjiznica
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
            System.Windows.Forms.Label label1;
            this.lbPosudbe = new System.Windows.Forms.ListBox();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPosudbe
            // 
            this.lbPosudbe.FormattingEnabled = true;
            this.lbPosudbe.Location = new System.Drawing.Point(53, 46);
            this.lbPosudbe.Name = "lbPosudbe";
            this.lbPosudbe.Size = new System.Drawing.Size(384, 290);
            this.lbPosudbe.TabIndex = 0;
            // 
            // btnPosudi
            // 
            this.btnPosudi.Location = new System.Drawing.Point(562, 46);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(96, 51);
            this.btnPosudi.TabIndex = 1;
            this.btnPosudi.Text = "Posudi";
            this.btnPosudi.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(562, 225);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(96, 51);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(562, 136);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(96, 51);
            this.btnUredi.TabIndex = 3;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(50, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 13);
            label1.TabIndex = 4;
            label1.Text = "Posudjene knjige : ";
            // 
            // frmKnjiznica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPosudi);
            this.Controls.Add(this.lbPosudbe);
            this.Name = "frmKnjiznica";
            this.Text = "Knjiznica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPosudbe;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnUredi;
    }
}