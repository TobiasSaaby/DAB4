using System.ComponentModel.DataAnnotations;

namespace DAB4.Modeller
{
    public class Adresse
    {
        [Key]
        public int Id { get; set; }

        public string Vejnavn { get; set; }
        public int Husnummer { get; set; }
        public string By { get; set; }

    }
}