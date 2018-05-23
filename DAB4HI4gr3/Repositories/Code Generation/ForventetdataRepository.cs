                
using DAB4.Modeller;
              
public class ForventetdataRepository : Repository<ForventetData>, IForventetdataRepository
{
    private DAB4.Modeller.Context.DBContext _context;

    public ForventetdataRepository(DAB4.Modeller.Context.DBContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IForventetdataRepository.cs file
}
