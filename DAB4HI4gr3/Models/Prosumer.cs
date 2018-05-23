using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB4.Modeller
{
    public class Prosumer
    {

        [Key]
        public int Id { get; set; }

        public string Navn { get; set; }
        public string Type { get; set; }
        public int Tokens { get; set; }
        public Adresse Adresse { get; set; }

        public virtual List<MiniSmartGridMeterData> MSGMData { get; set; }
        public virtual List<ForventetData> DataForventet { get; set; }

        public Prosumer()
        {
            MSGMData = new List<MiniSmartGridMeterData>();
            DataForventet = new List<ForventetData>();
        }

    }
}
