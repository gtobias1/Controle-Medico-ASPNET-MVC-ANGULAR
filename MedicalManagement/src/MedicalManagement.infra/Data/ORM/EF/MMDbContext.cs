using MedicalManagement.Domain.Entities;
using MedicalManagement.infra.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MedicalManagement.infra.Data.ORM.EF
{
    public class MMDbContext : DbContext
    {
        public MMDbContext() : base("name=MMDbContexto") //chama o construtor da classe base (DbContext)
        {

        }

        public DbSet<Uf> Uf { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Bairro> Bairro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Linha resposável por remover a convenção de pluralidade na hora da criação das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Nos relacionamentos um para muitos ele remove a convenção padrão de deletar em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //Nos relacionamentos de muitos para muitos ele remove a convenção padrão de deletar em cascata
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Add FluentApi Map
            modelBuilder.Configurations.Add(new UfMap());
            modelBuilder.Configurations.Add(new CidadeMap());
            modelBuilder.Configurations.Add(new BairroMap());

            //Sempre quando for encontrado um campo que tem o NOME da tabela com o sufixo Id ele deve
            //ser considerado chave primária
            modelBuilder.Properties()
                .Where(t => t.Name == t.ReflectedType.Name + "Id")
                .Configure(t => t.IsKey());

            //Toda vez que um campo for string e ele não tiver um DataAnotation definindo suas propriedades
            //essa linha diz que o campo é varchar
            modelBuilder.Properties<string>()
                .Configure(t => t.HasColumnType("varchar"));

            //Toda vez que um campo for string e ele não tiver um DataAnotation definindo suas propriedades
            //essa linha diz que o tamanho padrão da coluna será 80
            modelBuilder.Properties<string>()
                .Configure(t => t.HasMaxLength(80));

            base.OnModelCreating(modelBuilder);
        }
    }
}
