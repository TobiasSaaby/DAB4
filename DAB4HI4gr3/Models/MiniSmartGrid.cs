using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAB4.Modeller
{
    public class MiniSmartGrid
    {
        [Key]
        public int Id { get; set; }

        public int AntalEnhederPrivat { get; set; }
        public int AntalEnhederErhverv { get; set; }
        public int Energi { get; set; }
        public virtual List<MiniSmartGridMeter> MiniSmartGridMetre { get; set; }
        public virtual Kabel KabelInformation { get; set; }
        public virtual EnergiLager EnergyStorage { get; set; }

        public MiniSmartGrid()
        {
            MiniSmartGridMetre = new List<MiniSmartGridMeter>();
        }
    }
}