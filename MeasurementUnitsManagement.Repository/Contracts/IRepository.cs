using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MeasurementUnitsManagement.Models.Entities;

namespace MeasurementUnitsManagement.Repository.Contracts
{
    public interface IRepository<TEntity> 
        where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetList(CancellationToken cancellationToken);
        
        Task<TEntity> Get(object id, CancellationToken cancellationToken);    
        
    }
}