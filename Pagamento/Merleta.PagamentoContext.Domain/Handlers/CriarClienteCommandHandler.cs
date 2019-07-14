using Merleta.PagamentoContext.Domain.Commands;
using Merleta.PagamentoContext.Domain.Entities;
using Merleta.PagamentoContext.Domain.Repositories;

namespace Merleta.PagamentoContext.Domain.Handlers
{
    public class CriarClienteCommandHandler : ICommandHandler<CriarClienteCommand>
    {
        private IClienteRepository _repository { get; set; }

        public CriarClienteCommandHandler(IClienteRepository clienteRepository)
        {
            this._repository = clienteRepository;
        }

        public virtual CommandResult Handle(CriarClienteCommand command)
        {
            command.Validar();

            if (!command.IsValid)
            {
                //TOOD: Adicionar Notificacao
                return new CommandResult(false, "Não foi possível incluir um cliente");
            }

            //TODO: Salvar o cliente
            Cliente clienteCriado = new Cliente(
                command.Nome, 
                command.Documento
                );
            _repository.Criar(clienteCriado);
            //TODO: Enviar email ao cliente

            return new CommandResult(true, "Cliente incluído com sucesso");
        }
    }
}
