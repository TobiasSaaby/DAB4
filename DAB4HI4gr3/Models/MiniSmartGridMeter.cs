using System.ComponentModel.DataAnnotations;

namespace DAB4.Modeller
{
    public class MiniSmartGridMeter
    {
        [Key]
        public int Id { get; set; }

        public string Model { get; set; }
        public string InstallationsDato { get; set; }
        public Adresse Adresse { get; set; }
    }
}