                
using DAB4.Modeller;
              
public class AdresseRepository : Repository<Adresse>, IAdresseRepository
{
    private DAB4.Modeller.Context.DBContext _context;

    public AdresseRepository(DAB4.Modeller.Context.DBContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IAdresseRepository.cs file
}
