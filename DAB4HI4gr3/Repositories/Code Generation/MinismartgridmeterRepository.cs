                
using DAB4.Modeller;
              
public class MinismartgridmeterRepository : Repository<MiniSmartGridMeter>, IMinismartgridmeterRepository
{
    private DAB4.Modeller.Context.DBContext _context;

    public MinismartgridmeterRepository(DAB4.Modeller.Context.DBContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IMinismartgridmeterRepository.cs file
}
