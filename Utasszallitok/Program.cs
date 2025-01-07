namespace Utasszallitok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Repulo> Repulok = new();
            foreach (var sor in File.ReadAllLines("Utasszallitok.txt").Skip(1))
            {
                Repulok.Add(new Repulo(sor));
                Console.WriteLine($"4.feladat \t Adatsorok száma: {Repulok.Count()}");

                int db = 0;
                foreach (var b in Repulok)
                {
                    if (b.Típus == "")
                    {

                    }
                }
            }
        }
    }
}
