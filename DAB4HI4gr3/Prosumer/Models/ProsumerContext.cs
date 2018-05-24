using System.Data.Entity;
using DAB4.Modeller;

namespace Prosumer
{
    public class ProsumerContext : DbContext
    {
        public ProsumerContext()
            : base("HandIn4_I4DABGr3_Prosumer")
        {
        }
        public DbSet<Adresse> Adresser { get; set; }
        public DbSet<ForventetData> ForventetDatas { get; set; }
        public DbSet<DAB4.Modeller.Prosumer> Prosumere { get; set; }
    }
}