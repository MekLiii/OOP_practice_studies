using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    public class StawkiVAT
    {
        private static readonly Dictionary<string, double> Stawki = new()
        {
            ["A"] = 0.00,
            ["B"] = 0.05,
            ["C"] = 0.08,
            ["D"] = 0.23,
        };
        
        public static Dictionary<string, double> StawkiVATSŁownik()
        {
           return Stawki;
        
        }
        public static double WeźStawkę(string stawka)
        {
            return Stawki[stawka];
        }
        private static Dictionary<string, double> StawkiDlaProduktuSpożywczego()
        {
            return Stawki.Skip(1).Take(1).ToDictionary(x => x.Key, x => x.Value);
        }
        public static double WeźStawkęDlaProduktuSpożywczego(string stawka)
        {
            if (!StawkiDlaProduktuSpożywczego().ContainsKey(stawka))
            {
                throw new Exception($"{stawka} nie istnieje");
            }
            return StawkiDlaProduktuSpożywczego()[stawka];
        }
 
    };
}
