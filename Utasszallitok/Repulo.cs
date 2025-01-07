using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utasszallitok
{
    internal class Repulo
    {
        public string Típus { get; set; }
        public int Év { get; set; }
        public string Utas { get; set; }
        public string Szemelyzet { get; set; }
        public int UtazoSebbeseg { get; set; }
        public int Felszállótömeg { get; set; }
        public string Fesztáv { get; set; }

        public Repulo(string sor)
        {
            string[] s = sor.Split(';');

            Típus = s[0];
            Év =int.Parse( s[1]);
            Utas = s[2];
            Szemelyzet = s[3];
            UtazoSebbeseg = int.Parse(s[4]);
            Felszállótömeg = int.Parse(s[5]);
            Fesztáv = s[6];

        }
    }

}
