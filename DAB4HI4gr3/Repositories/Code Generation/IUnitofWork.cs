            using System;

public interface IUnitOfWork : IDisposable
{
    IProsumerRepository Prosumers { get; }
    IAdresseRepository Adresses { get; }
    IEnergilagerRepository EnergiLagers { get; }
    ITransaktionRepository Transaktions { get; }
    IForventetdataRepository ForventetDatas { get; }
    IMinismartgridRepository MiniSmartGrids { get; }
    IMinismartgridmeterRepository MiniSmartGridMeters { get; }
    IMinismartgridmeterdataRepository MiniSmartGridMeterDatas { get; }
    ITransaktionslisteRepository TransaktionsListes { get; }
    IKabelRepository Kabels { get; }
    void Save();
}
