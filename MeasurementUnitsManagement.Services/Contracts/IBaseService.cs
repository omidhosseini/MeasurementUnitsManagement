using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MeasurementUnitsManagement.Models.Entities;
using MeasurementUnitsManagement.Repository.Contracts;

namespace MeasurementUnitsManagement.Services.Contracts
{
    public interface IBaseService<TEntity, TRepository>
        where TEntity : BaseEntity 
    where TRepository : IRepository<TEntity>

    {
        Task<TEntity> GetById(object id, CancellationToken cancellationToken);

        Task<IEnumerable<TEntity>> GetList(CancellationToken cancellationToken);
    }
}