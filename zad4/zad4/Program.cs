

using zad4;



ProduktSpożywczyPaczka Jajka = new()
{
    Nazwa = "Jajka",
    CenaNetto = 10,
    StawkaVAT = "C",
    Kalorie = 200,
    KrajePochodzenia = "USA",
    Alergeny = new HashSet<string>() { "Jajka" }
};

Console.WriteLine($"Jajka nazwa: {Jajka.Nazwa}, Cena Netto {Jajka.CenaNetto} Cena brutto {Jajka.CenaBrutto}  , alergeny {Jajka.Alergeny}");

