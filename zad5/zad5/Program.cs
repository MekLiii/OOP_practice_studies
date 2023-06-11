// See https://aka.ms/new-console-template for more information
using zad5;
using Macierz = zad5.Macierz<int>;


Macierz macierz = new Macierz<int>(3, 3);

macierz[0, 0] = 1;
macierz.SprawdzWymiarJestTakiSam(macierz);
Console.WriteLine(macierz[0, 0]);
Console.WriteLine(macierz.SprawdzWymiarJestTakiSam(macierz));

