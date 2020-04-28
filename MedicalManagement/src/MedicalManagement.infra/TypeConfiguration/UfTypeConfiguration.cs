using MedicalManagement.Common.Entity;
using MedicalManagement.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalManagement.infra.TypeConfiguration
{
    class UfTypeConfiguration : MedicalEntityAbstractConfig<Uf>
    {
        protected override void ConfigFields()
        {
            Property(pk => pk.UfId)
                .IsRequired()
                .HasColumnName("UfId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

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

        protected override void ConfigForeignKey()
        {
        }

        protected override void ConfigPrimaryKey() => HasKey(pk => pk.UfId);

        protected override void ConfigTable() => ToTable("TLB_Uf");
    }
}
