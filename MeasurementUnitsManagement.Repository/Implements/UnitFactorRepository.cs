using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MeasurementUnitsManagement.Models.Entities;
using MeasurementUnitsManagement.Repository.Contracts;

namespace MeasurementUnitsManagement.Repository.Implements
{
    public class UnitFactorRepository : Repository<UnitFactorModel>, IUnitFactorRepository
    {
        private IEnumerable<UnitFactorModel> MockUnitFactorModel = new List<UnitFactorModel>()
        {
            new UnitFactorModel()
            {
                Id = 1,
                Symbol = "mm",
                UnitNameEn = "Millimeter",
                UnitNameFa = "میلی متر",
                RatioToTheBaseUnit = 0.001
            },
            new UnitFactorModel()
            {
                Id = 2,
                Symbol = "cm",
                UnitNameEn = "Centimeter",
                UnitNameFa = "سانتی متر",
                RatioToTheBaseUnit = 0.01
            },
            new UnitFactorModel()
            {
                Id = 3,
                Symbol = "km",
                UnitNameEn = "Kilometer",
                UnitNameFa = "کیلو متر",
                RatioToTheBaseUnit = 1000
            }
        };


        public new async Task<IEnumerable<UnitFactorModel>> GetList(CancellationToken cancellationToken)
        {
            return MockUnitFactorModel.ToList();
        }
    }
}