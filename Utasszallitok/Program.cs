namespace Utasszallitok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Repulo> Repulok = new();
            foreach (var sor in File.ReadAllLines("Utasszallitok.txt").Skip(1))
            {
                //4.feladat
                Repulok.Add(new Repulo(sor));
                Console.WriteLine($"4.feladat \t Adatsorok száma: {Repulok.Count()}");

                int db = 0;
                foreach (var b in Repulok)
                {
                    if (b.Típus == "")
                    {
                        db
                    }
                    //5.feladat
                    Console.WriteLine($"5.Feladat \t Boeing típusok száma: {db}");
                }
            }
        }
    }
}
