using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MeasurementUnitsManagement.Models.Entities;
using MeasurementUnitsManagement.Repository.Contracts;

namespace MeasurementUnitsManagement.Repository.Implements
{
    public class Repository<TEntity> : IRepository<TEntity> 
        where TEntity : BaseEntity, new()
    {
        //TODO:
        // Inject DbContext and UnitOfWork
        // Implement Repository CRUD
        
        
        public async Task<IEnumerable<TEntity>> GetList(CancellationToken cancellationToken)
        {
            return new List<TEntity>();
        }

      

        public async Task<TEntity> Get(object id, CancellationToken cancellationToken)
        {
            return new TEntity();
        }
    }
}