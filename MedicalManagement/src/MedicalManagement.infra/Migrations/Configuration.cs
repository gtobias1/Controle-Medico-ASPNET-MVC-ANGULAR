using MedicalManagement.infra.Data.ORM.EF;
using System.Data.Entity.Migrations;

namespace MedicalManagement.infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MMDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MMDbContext context)
        {
            //Inicializar o banco de produção
        }
    }
}
