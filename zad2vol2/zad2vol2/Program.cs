using zad2vol2;

Prostokąt prostokąt = new(2, 3);
double bokA = prostokąt.BokA;
double bokB = prostokąt.BokB;
prostokąt.BokA = 2;

Prostokąt arkuszA3 = Prostokąt.ArkuszPapieru("A2");

Console.WriteLine($"Bok A to {bokA}, bok B to {bokB}");
Console.WriteLine($"Arkusz: Bok A to {arkuszA3.BokA}, bok B to {arkuszA3.BokB}");
