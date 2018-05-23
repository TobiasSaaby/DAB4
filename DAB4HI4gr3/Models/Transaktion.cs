using System.ComponentModel.DataAnnotations;

namespace DAB4.Modeller
{
    public class Transaktion
    {
        [Key]
        public int Id { get; set; }

        public int EnergiProduceret { get; set; }
        public int EnergiAnvendt { get; set; }
        public int EnergiSamlet { get; set; }
        public int ProsumerId { get; set; }
    }
}