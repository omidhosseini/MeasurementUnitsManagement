using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MeasurementUnitsManagement.Models.Entities;
using MeasurementUnitsManagement.Repository.Contracts;

namespace MeasurementUnitsManagement.Services.Contracts
{
    public interface IUnitFactorService : IBaseService<UnitFactorModel,IUnitFactorRepository>
    {
        Task<List<UnitFactorModel>> GetUnitList(CancellationToken cancellationToken);
        Task<UnitFactorModel> GetUnit(int id, CancellationToken cancellationToken);
    }
}