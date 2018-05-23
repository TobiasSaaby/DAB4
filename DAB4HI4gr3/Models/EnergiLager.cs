using System.ComponentModel.DataAnnotations;

namespace DAB4.Modeller
{
    public class EnergiLager
    {
        [Key]
        public int Id { get; set; }
        public int Kapacitet { get; set; }
        public int EnergiBrugt { get; set; }
    }
}