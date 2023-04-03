using BIRC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIRC.Models.Configuration
{
    public class SpareRepairerConfiguration : IEntityTypeConfiguration<SpareRepairer>
    {
        public void Configure(EntityTypeBuilder<SpareRepairer> builder)
        {
            builder .ToTable("SPARE_REPAIRER_RC");
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.ProductName).HasColumnName("PRODUCT_NAME");
            builder.Property(p => p.DescProduct).HasColumnName("DESC_PRODUCT");
            builder.Property(p => p.Quantity).HasColumnName("QUANTITY");
            builder.Property(p => p.StorageBin).HasColumnName("STORAGE_BIN");
            builder.Property(p => p.DtIn).HasColumnName("DT_IN");
            builder.Property(p => p.DtValidate).HasColumnName("DT_VALIDATE");
            builder.Property(p => p.PurchaseOrder).HasColumnName("PURCHASE_ORDER");
            builder.Property(p => p.UnitMeasure).HasColumnName("UNIT_MEASURE");
            builder.Property(p => p.TypeOperation).HasColumnName("TYPE_OPERATION");
            builder.Property(P => P.LocalUsed).HasColumnName("LOCAL_USED");
            builder.Property(p => p.minimumQuantity).HasColumnName("MINIMUM_QUANTITY");
            builder.Property(p => p.UserId).HasColumnName("USER_ID");
        }
    }
}
