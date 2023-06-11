using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    public class Macierz<T> : IEquatable<Macierz<T>> where T : IComparable<T>
    {
      
        private T[,] tablica;
        public Macierz(int rozmiarWirszy,int rozmiarKolumn)
        {
            tablica = new T[rozmiarWirszy, rozmiarKolumn];
        }
        public T this[int wiersz,int kolumna]
        {
            get
            {
                return tablica[wiersz, kolumna];
            }
            set
            {
                tablica[wiersz, kolumna] = value;
            }
        }
        public bool SprawdzWymiarJestTakiSam(Macierz<T> macierz)
        {
            if(macierz == null)
            {
                return false;
                throw new ArgumentNullException("Macierz nie może być nullem");
            }
            if (tablica.GetLength(0) != macierz.tablica.GetLength(0) || tablica.GetLength(1) != macierz.tablica.GetLength(1))
            {
                return false;
            }
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    if (!EqualityComparer<T>.Default.Equals(tablica[i, j], macierz.tablica[i, j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator ==(Macierz<T> macierz1, Macierz<T> macierz2)
        {
            if (ReferenceEquals(macierz1, macierz2))
                return true;

            if (ReferenceEquals(macierz1, null) || ReferenceEquals(macierz2, null))
                return false;

            return macierz1.Equals(macierz2);
        }

        public static bool operator !=(Macierz<T> macierz1, Macierz<T> macierz2)
        {
            return macierz1 != macierz2;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Macierz<T>);
        }

        public bool Equals(Macierz<T>? other)
        {
            throw new NotImplementedException();
        }
    }
}
