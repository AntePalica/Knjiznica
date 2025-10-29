using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Knjiznica.Model
{
    public class PodatkovniKontekst
    {
        public List<Ucenik> ucenici;
        public List<Knjiga> knjige;
        public List<Posudba> posudbe;

        private string datUcenici = "ucenici.txt";
        private string datKnjige = "knjige.txt";
        private string datPosudbe = "posudbe.txt";

        public PodatkovniKontekst()
        {
            ucenici = UcitajUcenike();
            knjige = UcitajKnjige();
            posudbe = UcitajPosudbe();
        }

        public void DodajKnjigu(Knjiga knjiga)
        {
            this.knjige.Add(knjiga);
            SpremiKnjige();
        }

        public void BrisiKnjigu(Knjiga knjiga)
        {
            this.knjige.Remove(knjiga);
            SpremiKnjige();
        }

        public void DodajUcenika(Ucenik ucenik)
        {
            this.ucenici.Add(ucenik);
            spremiUcenike();
        }

        public void BrisiUcenika(Ucenik ucenik)
        {
            this.ucenici.Remove(ucenik);
            spremiUcenike();
        }
        public void DodajPosudbu(Posudba posudba)
        {
            this.posudbe.Add(posudba);
            spremiPosudbe();
        }

        public void BrisiPosudbu(Posudba posudba)
        {
            this.posudbe.Remove(posudba);
            spremiPosudbe();
        }

        public List<Knjiga> UcitajKnjige()
        {
            List<Knjiga> rezultat = new List<Knjiga>();

            if (File.Exists(datKnjige))
            {
                using (StreamReader sr = new StreamReader(datKnjige))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        Knjiga trenutnaKnjiga = new Knjiga();
                        string[] polja = linija.Split('|');
                        trenutnaKnjiga.ISBN = polja[0];
                        trenutnaKnjiga.Autor = polja[1];
                        trenutnaKnjiga.Naslov = polja[2];
                        trenutnaKnjiga.GodinaIzdanja = int.Parse(polja[3]);
                        trenutnaKnjiga.BrojPrimjeraka = int.Parse(polja[4]);

                        rezultat.Add(trenutnaKnjiga);

                    }
                }
            }

            return rezultat;
        }

        public void SpremiKnjige()
        {
            using (StreamWriter sw = new StreamWriter(datKnjige))
            {
                foreach (Knjiga trenutnaKnjiga in this.knjige)
                {
                    sw.WriteLine("{0}|{1}|{2}|{3}|{4}", trenutnaKnjiga.ISBN, trenutnaKnjiga.Autor, trenutnaKnjiga.Naslov, trenutnaKnjiga.GodinaIzdanja,
                    trenutnaKnjiga.BrojPrimjeraka);
                }
            }
        }

        public List<Ucenik> UcitajUcenike()
        {
            List<Ucenik> rezultat = new List<Ucenik>();
            
            if(File.Exists(datUcenici))
            {
                using (StreamReader sr = new StreamReader(datUcenici))
                {
                    while(!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        Ucenik trenutniUcenik = new Ucenik();
                        string[] polja = linija.Split('|');
                        trenutniUcenik.OIB = polja[0];
                        trenutniUcenik.Ime = polja[1];
                        trenutniUcenik.Prezime = polja[2];
                        trenutniUcenik.Adresa = polja[3];
                        trenutniUcenik.Telefon = polja[4];
                        trenutniUcenik.Razred = int.Parse(polja[5]);

                        rezultat.Add(trenutniUcenik);

                    }
                }
            }

            return rezultat;
        }

        public void spremiUcenike()
        {
            using (StreamWriter sw = new StreamWriter(datUcenici))
            {
                foreach(Ucenik trenutniUcenik in this.ucenici)
                {
                    sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}", trenutniUcenik.OIB, trenutniUcenik.Ime, trenutniUcenik.Prezime, trenutniUcenik.Adresa,
                    trenutniUcenik.Telefon, trenutniUcenik.Razred);
                }
            }
        }
        public List<Posudba> UcitajPosudbe()
        {
            List<Posudba> rezultat = new List<Posudba>();

            if (File.Exists(datPosudbe))
            {
                using (StreamReader sr = new StreamReader(datPosudbe))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        Posudba trenutnaPosudba = new Posudba();
                        string[] polja = linija.Split('|');
                        trenutnaPosudba.ucenik = this.ucenici.Find(
                            delegate(Ucenik ucenik)
                            {
                                return ucenik.OIB == polja[0];
                            });
                        trenutnaPosudba.knjiga = this.knjige.Find(
                            delegate (Knjiga knjiga)
                            {
                                return knjiga.ISBN == polja[1];
                            }
                            );
                        trenutnaPosudba.DatumPosudbe = DateTime.Parse(polja[2]);    
                        trenutnaPosudba.BrojDana = int.Parse(polja[3]);



                        rezultat.Add(trenutnaPosudba);

                    }
                }
            }

            return rezultat;
        }
        public void spremiPosudbe()
        {
            using (StreamWriter sw = new StreamWriter(datPosudbe))
            {
                foreach (Posudba p in this.posudbe)
                {
                    sw.WriteLine($"{p.ucenik.OIB}|{p.knjiga.ISBN}|{p.DatumPosudbe.ToShortDateString()}|{p.DatumVracanja}");
                }
            }
        }



    }
}
