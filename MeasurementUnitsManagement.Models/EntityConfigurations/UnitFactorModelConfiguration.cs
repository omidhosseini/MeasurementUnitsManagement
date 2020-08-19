using MeasurementUnitsManagement.Models.Entities;

namespace MeasurementUnitsManagement.Models.EntityConfigurations
{
    public class UnitFactorModelConfiguration : IEntityTypeConfiguration<UnitFactorModel>
    {
        public void Configure(EntityTypeBuilder<UnitFactorModel> builder)
        {
            builder.ToTable("UnitFactor")
                .HasKey(x => x.Id);

            builder.HasOne(x => x.BaseUnitInfo)
                .WithMany(x => x.UnitFactorList)
                .HasForeignKey(x => x.BaseUnitId);
        }
    }
}