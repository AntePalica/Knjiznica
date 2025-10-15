using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Knjiznica.Model
{
    public class Ucenik : IComparable 
    {
        public string OIB { get; set; }

        public string Ime { get; set; }
        
        public string Prezime { get; set; }
       
        public string Adresa { get; set; }

        public string Telefon { get; set; }
        
        public int Razred { get; set; }


    }
}
