                
using DAB4.Modeller;
              
public class MinismartgridRepository : Repository<MiniSmartGrid>, IMinismartgridRepository
{
    private DAB4.Modeller.Context.DBContext _context;

    public MinismartgridRepository(DAB4.Modeller.Context.DBContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IMinismartgridRepository.cs file
}
