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
    public class FormularizedUnitModelConfigurations : IEntityTypeConfiguration<FormularizedUnitModel>
    {
        public void Configure(EntityTypeBuilder<FormularizedUnitModel> builder)
        {
            builder.ToTable("FormularizedUnit")
                .HasKey(x => x.Id);  
        }
    }
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