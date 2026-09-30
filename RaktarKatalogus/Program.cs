using RaktarKatalogus;

Termek peldany1 = new Termek();
Termek peldany2 = new Termek();



List<Termek> osszes= new List<Termek>();
Console.WriteLine("=== Raktárkészlet Rögzítése ===\n");
for (int i = 0; i < 3; i++)
{

    Console.WriteLine($"Kérem az {i + 1}. termék adatai");
    Termek ujTermek = new Termek();
    Console.Write("\tNév: ");
    ujTermek.Nev = Console.ReadLine();
    Console.WriteLine("\tEgységár (Ft): ");
    ujTermek.Ar = int.Parse(Console.ReadLine());
    Console.Write("\tRaktárkészlet (db): ");
    ujTermek.Mennyiseg = int.Parse(Console.ReadLine());
    osszes.Add(ujTermek);
    Console.WriteLine();
}

//4. feladat
int teljesertek = 0;
int osszdb = 0;
double atlag = 0;
Console.WriteLine("Adatok feldolgozása...\n========================================\n");
Console.WriteLine("Rögzített termékek a raktárban:");

foreach(Termek t in osszes)
{
    teljesertek += t.Ar * t.Mennyiseg;
    osszdb += t.Mennyiseg;
    Console.WriteLine($"\t- {t.Nev}: {t.Ar} Ft/db ({t.Mennyiseg}db) -> Érték: {t.Ar*t.Mennyiseg} Ft");

}
atlag= teljesertek/osszdb;
Console.WriteLine("----------------------------------------");
Console.WriteLine($"Raktár teljes összértéke: {teljesertek} Ft");
Console.WriteLine($"Termékek átlagos egységára:{atlag} Ft");
Console.WriteLine("========================================");
