using SzabaduloszobaKezelo;
List<Jatek> jelen = new List<Jatek>();
foreach (var sor in File.ReadAllLines("foglalasok.txt").Skip(1))
{
    jelen.Add(new Jatek(sor));
}
Console.WriteLine("Rögzített szabadulószoba játékok:");
foreach (var sor in jelen)
{
    Console.WriteLine(sor);
}
Console.WriteLine("\nÖsszesített statisztika:");

Console.WriteLine($"Szabadulószoba teljes bevétele: {jelen.Sum(a=>a.FizetendoOsszeg())} Ft");
Console.WriteLine($"Összes játékos létszáma: {jelen.Sum(a=>a.JatekosokSzama)} fő");
Console.WriteLine($"Átlagos kijutási idő: {jelen.Average(a=>a.IdotartamPerc):f0} perc");
var leg = jelen.MaxBy(a => a.FizetendoOsszeg());
Console.WriteLine($"Legtöbbet fizető csapat: {leg.CsapatNev} ({leg.FizetendoOsszeg()} Ft)");
