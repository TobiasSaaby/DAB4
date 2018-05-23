using System.Data.Entity;

namespace DAB4.Modeller.Context
{
    public class DBContext : DbContext
    {
        public DBContext()
            : base("HandIn4_I4DABGr3")
        {
        }
        public DbSet<Adresse> Adresser { get; set; }
        public DbSet<EnergiLager> EnergiLagre { get; set; }
        public DbSet<ForventetData> ForventetDatas { get; set; }
        public DbSet<MiniSmartGrid> MiniSmartGridde { get; set; }
        public DbSet<MiniSmartGridMeter> MiniSmartGridMetre { get; set; }
        public DbSet<MiniSmartGridMeterData> MiniSmartGridMeterDatas { get; set; }
        public DbSet<Prosumer> Prosumere { get; set; }
        public DbSet<Transaktion> Transaktioner { get; set; }
        public DbSet<TransaktionsListe> TransaktionsLister { get; set; }
    }
}
