using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    public class Wektor
    {
        double[] współrzędne;

        public Wektor(double[] współrzędne)
        {
            this.współrzędne = współrzędne;
        }
        public double Długość { get { return Długość; } }
        public double Wymiar { get { return współrzędne.Length; } }
        public byte this[byte index] { get { return (byte)współrzędne[index]; } set { współrzędne[index] = value; } }

        static double? IloczynSkalarny(Wektor V, Wektor W)
        {
            if (V.Wymiar != W.Wymiar)
            {
                return null;
            }
            double iloczynSkalarny = 0;
            for (byte i = 0; i < V.Wymiar; i++)
            {
                iloczynSkalarny += V[i] * W[i];
            }
            return iloczynSkalarny;

        }
        static double Suma(params Wektor[] Wektory) //dopytać o co chodzi, dlaczego ma być tutaj typ Wektor, skoro zwracamy sumę
        {
            if(Wektory.Length == 0)
            {
                throw new ArgumentException("Nie podano wektora");
            }

            double suma = 0;
            foreach (Wektor wektor in Wektory)
            {
                suma =+ wektor.Wymiar; 
            }
            return suma;

        }
       static public Wektor operator +(Wektor V,Wektor W)
        {
            double[] noweWspółrzędne = new double[(int)V.Wymiar];
            for (byte i = 0; i < V.Wymiar; i++)
            {
                noweWspółrzędne[i] = V[i] + W[i];
            }

            return new Wektor(noweWspółrzędne);
        }
        static public Wektor operator -(Wektor V,Wektor W)
        {

            double[] noweWspółrzędne = new double[(int)V.Wymiar];
            for (byte i = 0; i < V.Wymiar; i++)
            {
                noweWspółrzędne[i] = V[i] - W[i];
            }

            return new Wektor(noweWspółrzędne);
        }
        static public Wektor operator *(Wektor V, double k)
        {
            double[] noweWspółrzędne = new double[(int)V.Wymiar];
            for (byte i = 0; i < V.Wymiar; i++)
            {
                noweWspółrzędne[i] = V[i] * k;
            }

            return new Wektor(noweWspółrzędne);
        }

        static public Wektor operator *(double k, Wektor V)
        {
            return V * k;
        }
    }
}
