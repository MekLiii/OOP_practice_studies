using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4.Słowniki
{
    internal class Alergeny
    {
        private static Dictionary<string, string[]> WykazAlergenow { get; } = new Dictionary<string, string[]>
    {
        { "Jajka", new[] { "Albumina", "Luteina" } },
        { "Orzechy", new[] { "Orzech laskowy", "Orzech włoski" } },
        { "Mleko", new[] { "Laktoza", "Białko mleka krowiego" } }
    };

        public static Dictionary<string, string[]> WeźWykazAlergenow(string[] alergenty) 
        {  
            foreach (var alergen in alergenty)
            {
                if (!WykazAlergenow.ContainsKey(alergen))
                {
                    throw new Exception($"Nie ma takiego alergenu {alergen}");
                }
            }
            return WykazAlergenow;
        }
        
    }
}
