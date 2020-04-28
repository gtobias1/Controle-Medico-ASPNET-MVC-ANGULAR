using MedicalManagement.Common.Entity;
using MedicalManagement.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalManagement.infra.TypeConfiguration
{
    class CidadeTypeConfiguration : MedicalEntityAbstractConfig<Cidade>
    {
        protected override void ConfigFields()
        {
            Property(t => t.CidadeId)
                .IsRequired()
                .HasColumnName("CidadeId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(70)
                .HasColumnName("Descricao");

            Property(t => t.UfId)
                .IsRequired()
                .HasColumnName("UfId");
        }

        protected override void ConfigForeignKey()
        {
            HasRequired(t => t.Uf)
                .WithMany() //uma Uf tem muitas cidades
                .HasForeignKey(t => t.UfId)
                .WillCascadeOnDelete(false);
        }

        protected override void ConfigPrimaryKey() => HasKey(t => t.CidadeId);

        protected override void ConfigTable() => ToTable("TLB_Cidade");
    }
}
