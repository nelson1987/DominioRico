using Merleta.PagamentoContext.Domain.Commands;

namespace Merleta.PagamentoContext.Domain.Handlers
{
    public interface ICommandHandler<TCommand>
    {
        CommandResult Handle(TCommand command);
    }
}
