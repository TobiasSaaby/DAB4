using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAB4.Modeller
{
    public class MiniSmartGrid
    {
        [Key]
        public int Id { get; set; }

        public List<Prosumer> Prosumere { get; set; }
        public virtual List<MiniSmartGridMeter> MiniSmartGridMetre { get; set; }
        public virtual EnergiLager EnergiLager { get; set; }

        public MiniSmartGrid()
        {
            Prosumere = new List<Prosumer>();
            MiniSmartGridMetre = new List<MiniSmartGridMeter>();
        }
    }
}