using MedicalManagement.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MedicalManagement.infra.Entity
{
    public class CidadeMap : EntityTypeConfiguration<Cidade>
    {
        public CidadeMap()
        {
            ToTable("Cidade");

            HasKey(pk => pk.CidadeId);

            Property(d => d.Descricao)
                .IsRequired()
                .HasMaxLength(70)
                .HasColumnName("Descricao");

            Property(u => u.UfId)
                .IsRequired()
                .HasColumnName("UfId");

            //Relacionamento => 1:N (Uma UF tem muitas cidades)
            HasRequired(pu => pu.Uf)
                .WithMany() //uma Uf tem muitas cidades
                .HasForeignKey(fk => fk.UfId)
                .WillCascadeOnDelete(false);
        }
    }
}
