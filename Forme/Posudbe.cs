using Knjiznica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Knjiznica.Forme
{
    public partial class DetaljiPosudbe : Form
    {
        public Posudba Posudba;

        public PodatkovniKontekst kontekst;
        public DetaljiPosudbe(PodatkovniKontekst kontekst)
        {
            InitializeComponent();
            this.kontekst = kontekst;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Posudbe_Load(object sender, EventArgs e)
        {
            OsvjeziUcenike();
            OsvjeziKnjige();

            if(this.Posudba != null)
            {
                lbUcenici.SelectedItem = this.Posudba.ucenik;
                lbKnjige.SelectedItem = this.Posudba.knjiga;
                dtpDatumPosudbe.Value = this.Posudba.DatumPosudbe;
                nudBRDana.Value = this.Posudba.BrojDana;

            }
        }

        public void OsvjeziUcenike()
        {
            Helper.PrikaziListuULB<Ucenik>(this.kontekst.ucenici,lbUcenici);
        }
        private void OsvjeziKnjige()
        {
            Helper.PrikaziListuULB<Knjiga>(this.kontekst.knjige, lbKnjige);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(lbUcenici.SelectedItem == null || lbKnjige.SelectedItem == null )
            {
                MessageBox.Show("molim te odaberi knjigu ili ucenika");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if(this.Posudba == null)
                {
                    this.Posudba = new Posudba();
                }
                this.Posudba.ucenik = (Ucenik)lbUcenici.SelectedItem;
                this.Posudba.knjiga = (Knjiga)lbKnjige.SelectedItem;
                this.Posudba.DatumPosudbe = dtpDatumPosudbe.Value;
                this.Posudba.BrojDana = (int)nudBRDana.Value;

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
