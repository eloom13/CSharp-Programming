using FIT.Data;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FIT.WinForms.Helpers
{
    public class Generator
    {
        public static string GetLozinka(int brojZnakova = 15)
        {
            string znakovi = "123456789qwertyuiop[]asdfghjkl;'zxcvbnm,./<>?*-";
            string lozinka = "";
            Random rand = new Random();
            for (int i = 0; i < brojZnakova; i++) 
            {
                int naredniZnak = rand.Next(0, znakovi.Length);
                lozinka += znakovi[naredniZnak];
            }
            return lozinka;
        }

        public static string GetNaredniBrojIndeksa()
        {
            return $"IB{(DateTime.Now.Year - 2000) * 10000 + InMemoryDb.Studenti.Count + 1}";
        }

        internal static string GetEmail(string ime, string prezime)
        {
            return $"{ime.ToLower()}.{prezime.ToLower()}{Resursi.Get(Kljucevi.EmailDomain)}";
        }
    }
}
