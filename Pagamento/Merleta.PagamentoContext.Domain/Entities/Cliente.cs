namespace Merleta.PagamentoContext.Domain.Entities
{
    public class Cliente : Fornecedor
    {
        public Cliente(string nome, string documento)
            : base(nome, documento)
        {

        }
    }
}
