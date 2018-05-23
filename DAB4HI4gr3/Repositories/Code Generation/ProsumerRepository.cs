
    
using DAB4.Modeller;
              
public class ProsumerRepository : Repository<Prosumer>, IProsumerRepository
{
    private DAB4.Modeller.Context.DBContext _context;

    public ProsumerRepository(DAB4.Modeller.Context.DBContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IProsumerRepository.cs file
}
