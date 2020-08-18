using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MeasurementUnitsManagement.Models.Entities;
using MeasurementUnitsManagement.Repository.Contracts;
using MeasurementUnitsManagement.Repository.Implements;
using MeasurementUnitsManagement.Services.Contracts;

namespace MeasurementUnitsManagement.Services.Implements
{
    public class UnitFactorService : BaseService<UnitFactorModel,IUnitFactorRepository>, IUnitFactorService
    {
        public UnitFactorService(IUnitFactorRepository repository)
            : base(repository)
        {
        }

        public async Task<List<UnitFactorModel>> GetUnitList(CancellationToken cancellationToken)
        {

            return (await Repository.GetList(cancellationToken)).ToList();
        }

        public async Task<UnitFactorModel> GetUnit(int id, CancellationToken cancellationToken)
        {
            return await Repository.Get(id, cancellationToken);
        }
    }
}