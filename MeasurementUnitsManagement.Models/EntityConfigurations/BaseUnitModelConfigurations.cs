using MeasurementUnitsManagement.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeasurementUnitsManagement.Models.EntityConfigurations
{
    public class BaseUnitModelConfigurations : IEntityTypeConfiguration<BaseUnitModel>
    {
        public void Configure(EntityTypeBuilder<BaseUnitModel> builder)
        {
            builder.ToTable("BaseUnit")
                .HasKey(x => x.Id);

            builder.HasIndex(x => new {x.UnitNameFa, x.UnitNameEn})
                .IsUnique();

            builder.HasOne(x => x.MeasurementDimensionsInfo)
                .WithMany(x => x.BaseUnitList)
                .HasForeignKey(x => x.MeasurementDimensionsId);
        }
    } 
}