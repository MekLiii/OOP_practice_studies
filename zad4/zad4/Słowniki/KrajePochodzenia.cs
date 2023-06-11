using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4.Słowniki
{
    public class KrajePochodzenia
    {
        private static readonly List<string> krajePochodzenia = new() {"Polska","Wielka Brytania","Australia","USA"};

        public static List<string> ListaKrajePochodzenia
        {
            get
            {
                return krajePochodzenia;
            }
        }

    }
}
