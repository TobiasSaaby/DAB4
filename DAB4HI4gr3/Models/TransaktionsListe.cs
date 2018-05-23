using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAB4.Modeller
{
    public class TransaktionsListe
    {

        [Key]
        public int Id { get; set; }

        public int Periode { get; set; }
        public string StartTidspunkt { get; set; }
        public string SlutTidspunkt { get; set; }
        public int Pris { get; set; }
        public int MSGridId { get; set; }
        public int TransaktionsSum { get; set; }
        public virtual List<Transaktion> Transaktioner { get; set; }

        public TransaktionsListe()
        {
            Transaktioner = new List<Transaktion>();
        }
    }
}