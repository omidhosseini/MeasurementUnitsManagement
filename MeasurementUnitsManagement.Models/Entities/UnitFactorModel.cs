namespace MeasurementUnitsManagement.Models.Entities
{
    public class UnitFactorModel : BaseUnit
    {
        public decimal RatioToTheBaseUnit { get; set; }

        public int BaseUnitId { get; set; }
        public BaseUnitModel BaseUnitInfo { get; set; }
    }
}