using System.Collections.Generic;

namespace MedicalManagement.Domain.Entities
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        public string Descricao { get; set; }
        public int UfId { get; set; }

        public virtual Uf Uf { get; set; } //Toda cidade pertence a uma UF (Uf é a tabela pai de cidade)
        public virtual ICollection<Bairro> Bairro { get; set; } //Todo bairro pertence a uma cidade (Cidade é a tabela pai de cidade)

    }
}
