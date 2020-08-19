using MeasurementUnitsManagement.Models.Entities;

namespace MeasurementUnitsManagement.Models.EntityConfigurations
{
    public class FormularizedUnitModelConfigurations : IEntityTypeConfiguration<FormularizedUnitModel>
    {
        public void Configure(EntityTypeBuilder<FormularizedUnitModel> builder)
        {
            builder.ToTable("FormularizedUnit")
                .HasKey(x => x.Id);  
        }
    }
}