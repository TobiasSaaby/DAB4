                
using DAB4.Modeller;
              
public class EnergilagerRepository : Repository<EnergiLager>, IEnergilagerRepository
{
    private DAB4.Modeller.Context.DBContext _context;

    public EnergilagerRepository(DAB4.Modeller.Context.DBContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IEnergilagerRepository.cs file
}
