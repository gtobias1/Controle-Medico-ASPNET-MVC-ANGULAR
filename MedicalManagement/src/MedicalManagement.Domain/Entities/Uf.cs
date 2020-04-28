using System.Collections.Generic;

namespace MedicalManagement.Domain.Entities
{
    public class Uf
    {
        public int UfId { get; set; }
        public string Sigla { get; set; }
        public string Estado { get; set; }
        public int CodigoEstado { get; set; }

        public virtual IEnumerable<Cidade> Cidade { get; set; }
    }
}
