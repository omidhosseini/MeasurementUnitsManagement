using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MeasurementUnitsManagement.Models.Entities.UnitEnums;
using MeasurementUnitsManagement.Services.Contracts;

namespace MeasurementUnitsManagement.Services.Utils
{
    public class UnitConverter : IUnitConverter
    {
        public IUnitFactorService UnitFactorService { get; }


        public UnitConverter(IUnitFactorService unitFactorService)
        {
            UnitFactorService = unitFactorService;
        }


        public async Task<double> ConvertLength
            (LengthEnum from, LengthEnum to, double value, CancellationToken cancellationToken)
        {
            if (value == 0)
            {
                return 0;
            }

            var units = await UnitFactorService.GetUnitList(cancellationToken);

            var fromFactor = units
                .FirstOrDefault(x => x.Symbol == from.ToString())?.RatioToTheBaseUnit ?? 0;

            var toFactor = units?
                .FirstOrDefault(x => x.Symbol == to.ToString())?.RatioToTheBaseUnit ?? 0;

            if (fromFactor.Equals(toFactor))
                return value;


            if (fromFactor > toFactor)
            {
                return (value * fromFactor) / toFactor;
            }

            return (value * fromFactor) * toFactor;
        }
    }
}