using BIRC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIRC.Models.Configuration
{
    public class VwLogUpdateConfiguration : IEntityTypeConfiguration<VwLogUpdate>
    {
        public void Configure(EntityTypeBuilder<VwLogUpdate> builder)
        {
            builder.ToTable("VW_LOG_SPAREPART_RC");
            builder.Property(p => p.Id).HasColumnName("REGISTRO");
            builder.Property(p => p.CodProduto).HasColumnName("COD_PRODUTO");
            builder.Property(p => p.NomeProduto).HasColumnName("PRODUTO");
            builder.Property(p => p.MovimentacaoSaldo).HasColumnName("MOVIMENTACAO");
            builder.Property(p => p.CategoriaProduto).HasColumnName("CATEGORIA");
            builder.Property(p => p.SaldoAtual).HasColumnName("SALDO_ATUAL");
            builder.Property(p => p.NomeUsuario).HasColumnName("USUARIO");
            builder.Property(p => p.DataMovimentacao).HasColumnName("DATA_MOVIMENTACAO");
            builder.Property(p => p.LocalUsed).HasColumnName("LOCAL_USADO");
            builder.Property(p => p.minimumQuantity).HasColumnName("QUANTIDADE_MINIMA");

        }
    }
}
