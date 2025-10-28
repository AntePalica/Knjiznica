using Knjiznica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace Knjiznica.Forme
{
    public partial class Ucenici : Form
    {
        PodatkovniKontekst kontekst;
        public Ucenici(PodatkovniKontekst kontekst)
        {
            InitializeComponent();
            this.kontekst = kontekst;
        }

        private void Ucenici_Load(object sender, EventArgs e)
        {
            OsvjeziUcenike();
        }
        private void OsvjeziUcenike()
        {
            Helper.PrikaziListuULB<Ucenik>(this.kontekst.ucenici, lbUcenici);
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DetaljiUcenika detaljiucenika = new DetaljiUcenika();

            DialogResult dr = detaljiucenika.ShowDialog();

            if(dr == DialogResult.OK)
            {
                this.kontekst.DodajUcenika(detaljiucenika.Ucenik);
                OsvjeziUcenike();
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if(lbUcenici.SelectedItems == null)
            {
                MessageBox.Show("Molim te odaberi uceniak");
            }
            else
            {
                DetaljiUcenika detaljiucenika = new DetaljiUcenika();
                detaljiucenika.Ucenik = (Ucenik)lbUcenici.SelectedItem;

                if(detaljiucenika.ShowDialog()== DialogResult.OK)
                {
                    this.kontekst.spremiUcenike();
                    OsvjeziUcenike();
                }
            }
        }
    }
}
