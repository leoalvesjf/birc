using BIRC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIRC.Models.Configuration
{
    public class SparePartsConfiguration : IEntityTypeConfiguration<SpareParts>
    {
        public void Configure(EntityTypeBuilder<SpareParts> builder)
        {
            builder.ToTable("SPARE_PARTS_RC");
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.PartNumber).HasColumnName("PARTNUMBER");
            builder.Property(p => p.Description).HasColumnName("DESCRIPTION");
            builder.Property(p => p.Quantity).HasColumnName("QUANTITY");
            builder.Property(p => p.DtIn).HasColumnName("DT_IN");
            builder.Property(p => p.Location).HasColumnName("LOCATION");
            builder.Property(p => p.PurchaseOrder).HasColumnName("PURCHASE_ORDER");
            builder.Property(p => p.LocalUsed).HasColumnName("LOCAL_USED");
            builder.Property (p => p.minimumQuantity).HasColumnName("MINIMUM_QUANTITY");
            builder.Property(p => p.UserId).HasColumnName("USER_ID");
        }
    }
}
