using SzabaduloszobaKezelo;
List<Jatek> jelen = new List<Jatek>();
foreach (var sor in File.ReadAllLines("foglalasok.txt"))
{
    jelen.Add(new Jatek(sor));
}
