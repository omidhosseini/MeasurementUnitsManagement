using System.ComponentModel.DataAnnotations;

namespace MeasurementUnitsManagement.Models.Entities.UnitEnums
{
    public enum LengthEnum
    {
        [Display(Description = "Meter")]
        m,
        [Display(Description = "Millimeter")]
        mm,
        [Display(Description = "Centimeter")]
        cm,
        [Display(Description = "Kilometer")]
        km
        
    }
}