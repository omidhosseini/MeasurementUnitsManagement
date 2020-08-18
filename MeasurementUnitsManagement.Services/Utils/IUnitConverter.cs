using System.Threading;
using System.Threading.Tasks;
using MeasurementUnitsManagement.Models.Entities.UnitEnums;

namespace MeasurementUnitsManagement.Services.Utils
{
    public interface IUnitConverter
    {
        Task<double> ConvertLength(LengthEnum from, LengthEnum to, double value, CancellationToken cancellationToken);
    }
}