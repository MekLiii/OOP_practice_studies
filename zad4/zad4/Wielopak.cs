using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Wielopak
    {

        Produkt Produkt = new();
        public ushort Ilość { get; set; }
        public decimal CenaNetto { get; set; }
        public double CenaBrutto { get => Produkt.CenaBrutto * Ilość; }
        public string KategoriaVat {get => Produkt.KategoriaVat;}
        public string KrajPochodzenia { get => Produkt.KrajPochodzenia; }
    }
}
