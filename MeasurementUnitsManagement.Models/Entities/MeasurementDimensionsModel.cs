using System.Collections.Generic;

namespace MeasurementUnitsManagement.Models.Entities
{
    public class MeasurementDimensionsModel : BaseEntity<int>
    {
        public string MeasurementDimensionsNameFa { get; set; }

        public string MeasurementDimensionsNameEn { get; set; }

        public virtual ICollection<BaseUnitModel> BaseUnitList { get; set; }
    }
}