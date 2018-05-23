using System;
using DAB4.Modeller;

public class UnitOfWork : IUnitOfWork
{
    private DAB4.Modeller.Context.DBContext _context;

    public UnitOfWork(DAB4.Modeller.Context.DBContext context)
    {
        _context = context;
    }

	//Delete this default constructor if using an IoC container
	public UnitOfWork()
	{
		_context = new DAB4.Modeller.Context.DBContext();
	}
	
    public IProsumerRepository Prosumers
    {
        get { return new ProsumerRepository(_context); }
    }

    public IAdresseRepository Adresses
    {
        get { return new AdresseRepository(_context); }
    }

    public IEnergilagerRepository EnergiLagers
    {
        get { return new EnergilagerRepository(_context); }
    }

    public ITransaktionRepository Transaktions
    {
        get { return new TransaktionRepository(_context); }
    }

    public IForventetdataRepository ForventetDatas
    {
        get { return new ForventetdataRepository(_context); }
    }

    public IMinismartgridRepository MiniSmartGrids
    {
        get { return new MinismartgridRepository(_context); }
    }

    public IMinismartgridmeterRepository MiniSmartGridMeters
    {
        get { return new MinismartgridmeterRepository(_context); }
    }

    public IMinismartgridmeterdataRepository MiniSmartGridMeterDatas
    {
        get { return new MinismartgridmeterdataRepository(_context); }
    }

    public ITransaktionslisteRepository TransaktionsListes
    {
        get { return new TransaktionslisteRepository(_context); }
    }
    
    public void Save()
    {
        _context.SaveChanges();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }
        }
    }
}
