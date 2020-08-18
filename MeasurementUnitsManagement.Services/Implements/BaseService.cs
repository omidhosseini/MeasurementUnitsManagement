using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MeasurementUnitsManagement.Models.Entities;
using MeasurementUnitsManagement.Repository.Contracts;
using MeasurementUnitsManagement.Services.Contracts;

namespace MeasurementUnitsManagement.Services.Implements
{
    public class BaseService<TEntity, TRepository> : IBaseService<TEntity,TRepository>
        where TEntity : BaseEntity
        where TRepository : IRepository<TEntity>
    {
        public TRepository Repository { get; }

        public BaseService(TRepository repository)
        {
            Repository = repository;
        }

        public async Task<TEntity> GetById(object id, CancellationToken cancellationToken)
        {
            return await Repository.Get(id, cancellationToken);
        }

        public async Task<IEnumerable<TEntity>> GetList(CancellationToken cancellationToken)
        {
            return await Repository.GetList(cancellationToken);
        }
    }
}