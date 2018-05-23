                
using DAB4.Modeller;
              
public class TransaktionRepository : Repository<Transaktion>, ITransaktionRepository
{
    private DAB4.Modeller.Context.DBContext _context;

    public TransaktionRepository(DAB4.Modeller.Context.DBContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ITransaktionRepository.cs file
}
