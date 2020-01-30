using System.Data.Entity.ModelConfiguration;
using Quay.Domain.Entities;

namespace Quay.Infra.Data.EntityConfig
{
    public class PrevisaoConfiguration : EntityTypeConfiguration<Previsao>
    {
        public PrevisaoConfiguration()
        {
            HasKey(c => c.PrevisaoId);

            Property(c => c.Cidade)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Estado)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Atualizacao)
                .IsRequired();
            Property(c => c.Dia)
                .IsRequired();

            Property(c => c.Maxima)
                .IsRequired();
            Property(c => c.Minima)
                .IsRequired();

            Property(c => c.Ativo)
                .IsRequired();
        }
    }
}