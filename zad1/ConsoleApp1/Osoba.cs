using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Osoba
    {
        string imię;
        string Nazwisko;
        public DateTime? DataUrodzenia = null;
        public DateTime? DataŚmierci = null;

        public Osoba(string imięNazwisko)
        {
            string[] rozdzieloneImieNazwisko = imięNazwisko.Split();
            imię = rozdzieloneImieNazwisko[0];
            Nazwisko = rozdzieloneImieNazwisko[1];
        }
        public string Imię
        {
            get { return imię; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Imię nie może być puste");
                }
                imię = value;
            }
        }
        public string ImięNazwisko
        {
            get { return $"{imię} {Nazwisko}"; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Imię nie może być puste");
                }
                string[] rozdzieloneImieNazwisko = value.Split();
                imię = rozdzieloneImieNazwisko[0];
                Nazwisko = rozdzieloneImieNazwisko.Length > 1 ? rozdzieloneImieNazwisko.ElementAt(-1) : "";
            }
        }
         public TimeSpan? Wiek
        {
            get
            {
                if (DataUrodzenia == null)
                {
                    return null;
                }
                DateTime dataŚmierci = DataŚmierci ?? DateTime.Now;
                return dataŚmierci - DataUrodzenia;
            }
        }

    }
}
