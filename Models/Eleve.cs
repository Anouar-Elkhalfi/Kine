using System.Collections.Generic;

namespace Models
{
    public class Eleve
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public List<Note> Notes { get; set; }

        public Eleve()
        {
            Notes = new List<Note>();
        }
    }

    public class Note
    {
        public string Cours { get; set; }
        public double Valeur { get; set; }
        public string Appreciation { get; set; }
    }
}
