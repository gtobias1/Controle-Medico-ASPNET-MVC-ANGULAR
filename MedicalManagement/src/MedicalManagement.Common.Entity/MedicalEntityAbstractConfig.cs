using System.Data.Entity.ModelConfiguration;

namespace MedicalManagement.Common.Entity
{
    public abstract class MedicalEntityAbstractConfig<TEntity> : EntityTypeConfiguration<TEntity> 
        where TEntity : class //o Tipo recebido e será passado para o EntityTypeConfiguration tem que ser uma classe
    {
        public MedicalEntityAbstractConfig()
        {
            ConfigTable();
            ConfigFields();
            ConfigPrimaryKey();
            ConfigForeignKey();
        }

        protected abstract void ConfigForeignKey();

        protected abstract void ConfigPrimaryKey();

        protected abstract void ConfigFields();

        protected abstract void ConfigTable();
    }
}
