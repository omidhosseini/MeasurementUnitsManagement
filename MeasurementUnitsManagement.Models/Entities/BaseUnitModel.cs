using System.Collections.Generic;

namespace MeasurementUnitsManagement.Models.Entities
{
    public class BaseUnitModel : BaseUnit
    {
        public int MeasurementDimensionsId { get; set; }
        public MeasurementDimensionsModel MeasurementDimensionsInfo { get; set; }

        public virtual ICollection<UnitFactorModel> UnitFactorList { get; set; }
    }
}