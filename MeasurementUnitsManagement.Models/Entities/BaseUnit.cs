namespace MeasurementUnitsManagement.Models.Entities
{
    public class BaseUnit : BaseEntity<int>
    {
        public string UnitNameFa { get; set; }

        public string UnitNameEn { get; set; }

        public string Symbol { get; set; }
    }
}