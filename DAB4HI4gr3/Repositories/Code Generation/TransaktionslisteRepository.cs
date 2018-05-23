                
using DAB4.Modeller;
              
public class TransaktionslisteRepository : Repository<TransaktionsListe>, ITransaktionslisteRepository
{
    private DAB4.Modeller.Context.DBContext _context;

    public TransaktionslisteRepository(DAB4.Modeller.Context.DBContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ITransaktionslisteRepository.cs file
}
