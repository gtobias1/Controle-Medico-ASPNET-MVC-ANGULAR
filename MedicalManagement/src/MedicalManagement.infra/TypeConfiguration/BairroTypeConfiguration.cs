using MedicalManagement.Common.Entity;
using MedicalManagement.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalManagement.infra.TypeConfiguration
{
    class BairroTypeConfiguration : MedicalEntityAbstractConfig<Bairro>
    {
        protected override void ConfigFields()
        {
            Property(pk => pk.BairroId)
                .IsRequired()
                .HasColumnName("BairroId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(d => d.Descricao)
                .IsRequired()
                .HasMaxLength(70)
                .HasColumnName("Descricao");

            Property(u => u.CidadeId)
                .IsRequired()
                .HasColumnName("CidadeId");
        }

        protected override void ConfigForeignKey()
        {
            //Relacionamento => 1:N (Uma UF tem muitas cidades)
            HasRequired(pu => pu.Cidade)
                .WithMany() //uma Uf tem muitas cidades
                .HasForeignKey(fk => fk.CidadeId)
                .WillCascadeOnDelete(false);
        }

        protected override void ConfigPrimaryKey() => HasKey(pk => pk.BairroId);

        protected override void ConfigTable() => ToTable("TLB_Bairro");
    }
}
