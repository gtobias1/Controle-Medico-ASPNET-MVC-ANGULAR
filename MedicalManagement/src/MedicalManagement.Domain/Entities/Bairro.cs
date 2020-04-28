namespace MedicalManagement.Domain.Entities
{
    public class Bairro
    {
        public int BairroId { get; set; }
        public string Descricao { get; set; }
        public int CidadeId { get; set; }

        public virtual Cidade Cidade { get; set; }
    }
}
