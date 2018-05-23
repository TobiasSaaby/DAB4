using System.ComponentModel.DataAnnotations;

namespace DAB4.Modeller
{
    public class Kabel
    {
        [Key]
        public int Id { get; set; }

        public string Producent { get; set; }
        public string Model { get; set; }
        public int Diameter { get; set; }
        public string InstallationsDato { get; set; }
    }
}