namespace Merleta.PagamentoContext.Domain.Entities
{
    public class Fornecedor
    {
        public Fornecedor(string nome, string documento)
        {
            Nome = nome;
            Documento = documento;
        }

        public string Nome { get; private set; }
        public string Documento { get; private set; }
    }
}
