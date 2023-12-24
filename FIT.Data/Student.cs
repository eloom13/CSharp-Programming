using System.Drawing;

namespace FIT.Data
{

    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }
        public Semestar Semestar { get; set; }
        public int SemestarId { get; set; }
       
        public ICollection<Uloga>Uloga { get; set; } = new HashSet<Uloga>();

        //public List<PolozeniPredmet> PolozeniPredmeti { get; set; }
        //---------------------------------------------------------

        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }
      
        //public Student()
        //{
        //    PolozeniPredmeti = new List<PolozeniPredmet>();
        //}

    }
}
