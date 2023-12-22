using FIT.Data;

namespace FIT.Infrastructure
{
    public class InMemoryDb
    {
        public static List<Korisnik> Korisnici = GenerisiKorisnike();
        public static List<Student> Studenti = GenerisiStudente();
        public static List<Semestar> Semestri = GenerisiSemestre();

        private static List<Semestar> GenerisiSemestre()
        {
            return new List<Semestar>()
            {
                new Semestar() { Id = 1, Aktivan = true, Oznaka = "1. SEM", Opis = "Prvi semestar I ciklusa studija" },
                new Semestar() { Id = 2, Aktivan = true, Oznaka = "2. SEM", Opis = "Drugi semestar I ciklusa studija" },
                new Semestar() { Id = 3, Aktivan = true, Oznaka = "3. SEM", Opis = "Treci semestar I ciklusa studija" },
                new Semestar() { Id = 4, Aktivan = true, Oznaka = "4. SEM", Opis = "Cetvrti semestar I ciklusa studija" }
            };
        }

        private static List<Student> GenerisiStudente()
        {
            return new List<Student>() {
                new Student()
                {
                    Id = 1,
                    Aktivan = true,
                    Email = "denis@edu.fit.ba",
                    Ime = "Denis",
                    Indeks = "IB230032",
                    Lozinka = "denis",
                    Prezime = "Music",
                    DatumRodjenja = new DateTime(2000,2,2),
                    Slika = null,
                    Semestar = 1
                },
                new Student()
                {
                    Id = 2,
                    Aktivan = true,
                    Email = "jasmin@edu.fit.ba",
                    Ime = "Jasmin",
                    Indeks = "IB230033",
                    Lozinka = "jasmin",
                    Prezime = "Azemovic",
                    DatumRodjenja = new DateTime(2000,1,1),
                    Slika = null,
                    Semestar = 2
                },
            };
        }

        private static List<Korisnik> GenerisiKorisnike()
        {
            /*
            var korisnik = new Korisnik()
            {
                Id = 1,
                Aktivan = true,
                Email = "admin@edu.fit.ba",
                Ime = "Denis",
                KorisnickoIme = "admin",
                Lozinka = "admin",
                Prezime = "Music"
            };
            List<Korisnik> lista = new List<Korisnik>();
            lista.Add(korisnik);
            return lista;
            */

            return new List<Korisnik>() {
                new Korisnik()
                {
                        Id = 1,
                        Aktivan = true,
                        Email = "admin@edu.fit.ba",
                        Ime = "Denis",
                        KorisnickoIme = "admin",
                        Lozinka = "admin",
                        Prezime = "Music"
                }
            };
        }
    }
}