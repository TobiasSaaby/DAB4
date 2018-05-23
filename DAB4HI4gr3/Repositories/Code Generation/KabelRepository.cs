                
using DAB4.Modeller;
              
public class KabelRepository : Repository<Kabel>, IKabelRepository
{
    private DAB4.Modeller.Context.DBContext _context;

    public KabelRepository(DAB4.Modeller.Context.DBContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IKabelRepository.cs file
}
