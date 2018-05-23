using System.ComponentModel.DataAnnotations;

namespace DAB4.Modeller
{
    public class MiniSmartGridMeterData
    {
        [Key]
        public int Id { get; set; }

        public string StartTidspunkt { get; set; }
        public string SlutTidspunkt { get; set; }
        public int EnergiProduceret { get; set; }
        public int EnergiAnvendt { get; set; }
    }
}