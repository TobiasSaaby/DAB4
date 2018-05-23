using System.ComponentModel.DataAnnotations;

namespace DAB4.Modeller
{
    public class ForventetData
    {
        [Key]
        public int Id { get; set; }

        public int Forbrug { get; set; }
        public int Produktion { get; set; }
        public string StartTidspunkt { get; set; }
        public string SlutTidspunkt { get; set; }
    }
}