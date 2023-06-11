using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad4.Słowniki;


namespace zad4
{
    public class Produkt
    {
        private string nazwa = "";
        private string stawkaVAT = "";
        private double cenaNetto = 0;
        private string krajPochodzenia = "";
        private string kategoriaVAT = "";

        private string dostępneKraje = string.Join(" ", KrajePochodzenia.ListaKrajePochodzenia);

        public string Nazwa
        {
            get
            {
                return nazwa;
            }
            set
            {
                nazwa = value;
            }
        }
        public string StawkaVAT { get { return stawkaVAT; } set { stawkaVAT = value; } }
        public double CenaNetto
        {
            get { return cenaNetto; }
            set
            {
                Console.WriteLine("Cenna netto" + value);
                if (value > 0)
                {
                    cenaNetto = value;
                }
                else
                {
                    throw new Exception("Cena nie może być ujemna");
                }
            }
        }
        public virtual double CenaBrutto
        {
            get
            {
                if (!StawkiVAT.StawkiVATSŁownik().ContainsKey(stawkaVAT))
                {
                    throw new ArgumentException("Podana stawka VAT jest nieprawidłowa");
                }
                if (cenaNetto <= 0)
                {
                    throw new Exception("Cena netto nie może być mniejsza bądz równa 0");
                }

                return cenaNetto + cenaNetto * StawkiVAT.WeźStawkę(stawkaVAT);
            }

        }

        public string KrajPochodzenia
        {
            get
            {
                return krajPochodzenia;
            }
            set
            {
                if (!KrajePochodzenia.ListaKrajePochodzenia.Contains(krajPochodzenia.Trim()))
                {
                    throw new ArgumentException($"Podany kraj pochodzenia jest nieprawidłowy {value}, dostępne kraje to {dostępneKraje}");

                }
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Kraj pochodzenia jest wymagany");
                }
                krajPochodzenia = value;


            }
        }
        public string KategoriaVat
        {
            get => kategoriaVAT;
            set
            {
                if (StawkiVAT.StawkiVATSŁownik().ContainsKey(value))
                {
                    kategoriaVAT = value;
                }
                else
                {
                    throw new ArgumentException("Podana kategoria VAT jest nieprawidłowa");
                }

            }
        }

    }
}
