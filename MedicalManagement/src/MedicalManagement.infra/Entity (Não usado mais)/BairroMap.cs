using MedicalManagement.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MedicalManagement.infra.Entity
{
    public class BairroMap : EntityTypeConfiguration<Bairro>
    {
        public BairroMap()
        {
            ToTable("Bairro");

            HasKey(pk => pk.BairroId);

            Property(d => d.Descricao)
                .IsRequired()
                .HasMaxLength(70)
                .HasColumnName("Descricao");

            Property(u => u.CidadeId)
                .IsRequired()
                .HasColumnName("CidadeId");

            //Relacionamento => 1:N (Uma UF tem muitas cidades)
            HasRequired(pu => pu.Cidade)
                .WithMany() //uma Uf tem muitas cidades
                .HasForeignKey(fk => fk.CidadeId)
                .WillCascadeOnDelete(false);
        }
    }
}
