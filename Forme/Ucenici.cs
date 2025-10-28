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
            lbUcenici.Items.Clear();
            this.kontekst.ucenici.Sort();
            foreach(Ucenik trenutniUcenik in this.kontekst.ucenici)
            {
                lbUcenici.Items.Add(trenutniUcenik);
            }
        }
    }
}
