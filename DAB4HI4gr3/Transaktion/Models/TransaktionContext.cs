
using System.Data.Entity;
using DAB4.Modeller;


namespace Transaktion
{
    public class TransaktionContext : DbContext
    {
        public TransaktionContext()
            : base("HandIn4_I4DABGr3_Transaktion")
        {
        }
        public DbSet<DAB4.Modeller.Transaktion> Transaktioner { get; set; }
        public DbSet<TransaktionsListe> TransaktionsLister { get; set; }
    }
}