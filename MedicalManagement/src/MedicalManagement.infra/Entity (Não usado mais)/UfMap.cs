using MedicalManagement.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MedicalManagement.infra.Entity
{
    public class UfMap : EntityTypeConfiguration<Uf>
    {
        public UfMap()
        {
            //tabela a ser mapeada
            ToTable("Uf");

            //PrimaryKey
            HasKey(pk => pk.UfId);

            //Properties
            Property(s => s.Sigla)
                .IsRequired()
                .HasMaxLength(2).IsFixedLength()
                .HasColumnName("Sigla");

            Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Estado");

            Property(ce => ce.CodigoEstado)
                .IsRequired()
                .HasColumnName("CodigoEstado");
        }
    }
}
