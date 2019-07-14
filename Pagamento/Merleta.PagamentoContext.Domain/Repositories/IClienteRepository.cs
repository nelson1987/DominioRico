using Merleta.PagamentoContext.Domain.Entities;

namespace Merleta.PagamentoContext.Domain.Repositories
{
    public interface IClienteRepository
    {
        void Criar(Cliente clienteCriado);
    }
}
