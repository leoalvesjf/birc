using BIRC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIRC.Models.Configuration
{
    public class LogUpdateConfiguration : IEntityTypeConfiguration<LogUpdate> 

    {
        public void Configure(EntityTypeBuilder<LogUpdate> builder)
        {
            builder.ToTable("LOG_SPARE_PARTS_RC");           
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.Alteration).HasColumnName("DATE_ALTERATION");
            builder.Property(p => p.Quantity).HasColumnName("QUANTITY_ALTERATION");
            builder.Property(p => p.minimumQuantity).HasColumnName("MINIMUM_QUANTITY");
            builder.Property(p => p.TypeEdtion).HasColumnName("TYPE_EDTION");
            builder.Property(p => p.Product).HasColumnName("PRODUCT_NAME");
            builder.Property(p => p.UserId).HasColumnName("USER_ID");
            builder.Property(p => p.ModelAlteration).HasColumnName("MODEL_ALTERATION");
            builder.Property(p => p.CurrentBalance).HasColumnName("CURRENT_BALANCE");
            builder.Property(p => p.LocalUsed).HasColumnName("LOCAL_USED");

            //implementar mais um campo para mostrar esta alocado o material usado
        }
    }
}
