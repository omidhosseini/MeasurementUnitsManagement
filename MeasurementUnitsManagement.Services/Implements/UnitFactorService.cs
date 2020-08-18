using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MeasurementUnitsManagement.Models.Entities;
using MeasurementUnitsManagement.Repository.Implements;
using MeasurementUnitsManagement.Services.Contracts;

namespace MeasurementUnitsManagement.Services.Implements
{
    public class UnitFactorService : BaseService<UnitFactorModel,Repository<UnitFactorModel>>, IUnitFactorService
    {
        public UnitFactorService(Repository<UnitFactorModel> repository)
            : base(repository)
        {
        }

        public async Task<List<UnitFactorModel>> GetUnitList(CancellationToken cancellationToken)
        {

            return await Repository.GetList(cancellationToken) as List<UnitFactorModel>;
        }

        public async Task<UnitFactorModel> GetUnit(int id, CancellationToken cancellationToken)
        {
            return await Repository.Get(id, cancellationToken);
        }
    }
}