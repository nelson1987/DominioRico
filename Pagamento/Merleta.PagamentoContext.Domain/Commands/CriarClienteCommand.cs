namespace Merleta.PagamentoContext.Domain.Commands
{
    public class CriarClienteCommand
    {
        public bool IsValid { get; internal set; }

        public void Validar()
        {
            IsValid = true;
        }
    }
}
