namespace FIT.Data
{
    public class Uloga
    {
        public int Id { get; set; }
        public string Naziv {  get; set; }

        // public List<Student> Student {  get; set; } = new List<Student>(); // moze i instanciranje u Ctoru-u 
         public ICollection<Student> Student {  get; set; } = new HashSet<Student>(); // moze i instanciranje u Ctoru-u 
    }
}
