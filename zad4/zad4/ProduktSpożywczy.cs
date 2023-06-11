using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using zad4;
using zad4.Słowniki;
using StawkiVAT = zad4.StawkiVAT;

namespace zad4
{
    public class ProduktSpożywczy : Produkt
    {
        string nazwa = "";
        decimal cenaNetto;
        string? kategoriaVAT;
        string? krajPochodzenia;
        HashSet<string>? alergeny;
        int kalorie = 0;


        public int Kalorie
        {
            get
            {
                return kalorie;
            }
            set
            {
                kalorie = value;
            }
        }
        public HashSet<string>? Alergeny
        {
            get => alergeny;
            set
            {
                alergeny = value;
            }
        }

        public double GetStawkaVat()
        {
            return StawkiVAT.WeźStawkęDlaProduktuSpożywczego(kategoriaVAT);
        }
        public new string Nazwa
        {
            get
            {
                return nazwa;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Nazwa nie może być pusta");
                }
                nazwa = value;
            }

        }
        public string KrajePochodzenia
        {
            get => krajPochodzenia;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Kraj pochodzenia nie moze być pusty");
                }
                krajPochodzenia = value;
            }

        }
        public decimal CenaNetto
        {
            get => cenaNetto;
            set
            {
                cenaNetto = value;
            }
        }
    }
}
