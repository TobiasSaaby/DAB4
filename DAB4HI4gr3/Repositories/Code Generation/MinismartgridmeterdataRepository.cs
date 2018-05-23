                
using DAB4.Modeller;
              
public class MinismartgridmeterdataRepository : Repository<MiniSmartGridMeterData>, IMinismartgridmeterdataRepository
{
    private DAB4.Modeller.Context.DBContext _context;

    public MinismartgridmeterdataRepository(DAB4.Modeller.Context.DBContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IMinismartgridmeterdataRepository.cs file
}
