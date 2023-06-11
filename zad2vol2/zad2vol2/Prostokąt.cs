using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2vol2
{
    public class Prostokąt
    {
        private double bokA;
        private double bokB;
        private static double pierwiastekZDwóch = Math.Sqrt(2);
        public Prostokąt(double x, double y)
        {
            bokA = x;
            bokB = y;
        }
        private Boolean czyLiczbaJestWiększaOdZeraLubSkonczona(double value)
        {
            if (value < 0 || Double.IsInfinity(value))
            {
                return true;
            }
            return false;

        }
        public double BokA
        {
            set
            {
                if (czyLiczbaJestWiększaOdZeraLubSkonczona(value))
                {
                    throw new ArgumentException("Liczba jest mniejsza od zera lub nieskończona");
                }
                else
                {
                    bokA = value;
                }
            }
            get { return bokA; }
        }

        public double BokB
        {
            set
            {
                if (czyLiczbaJestWiększaOdZeraLubSkonczona(value))
                {
                    throw new ArgumentException("Liczba jest mniejsza od zera lub nieskończona");
                }
                else
                {
                    bokB = value;
                }
            }
            get { return bokB; }
        }
        static public Dictionary<char, decimal> wysokośćArkusza0 = new()
        {
            ['A'] = 1189,
            ['B'] = 1414,
            ['C'] = 1297
        };
        public static Prostokąt ArkuszPapieru(string format)
        {
            char X = format[0];
            byte i = Convert.ToByte(format[1]);
            if (format.Length < 2 || !char.IsLetter(X))
                throw new ArgumentException("Niepoprawny format arkusza papieru.");

  
            if (!wysokośćArkusza0.ContainsKey(X))
                throw new ArgumentException("Niepoprawny klucz szeregu arkuszy papieru.");

            decimal bazowaWysokość = wysokośćArkusza0[X];
            double bokA = (double)bazowaWysokość / Math.Pow(pierwiastekZDwóch, i);
            double bokB = bokA / pierwiastekZDwóch;

            return new Prostokąt(bokA, bokB);
        }
    }
    
}
