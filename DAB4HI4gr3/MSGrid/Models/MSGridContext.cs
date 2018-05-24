using System.Data.Entity;
using DAB4.Modeller;

namespace MSGrid
{
    public class MSGridContext : DbContext
    {

        public MSGridContext()
            : base("HandIn4_I4DABGr3_MSGrid")
        {
        }
        public DbSet<Adresse> Adresser { get; set; }
        public DbSet<EnergiLager> EnergiLagre { get; set; }
        public DbSet<ForventetData> ForventetDatas { get; set; }
        public DbSet<MiniSmartGrid> MiniSmartGridde { get; set; }
        public DbSet<MiniSmartGridMeter> MiniSmartGridMetre { get; set; }
        public DbSet<MiniSmartGridMeterData> MiniSmartGridMeterDatas { get; set; }
        public DbSet<Prosumer> Prosumere { get; set; }
    }


}
