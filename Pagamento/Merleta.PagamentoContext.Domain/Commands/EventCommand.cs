using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Merleta.PagamentoContext.Domain.Commands
{
    public abstract class EventCommand
    {
        public bool IsValid { get; private set; }

        public abstract void Validar();
        public void SetIsValid()
        {
            IsValid = true;
        }
        public List<ValidationResult> getValidationErros(object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            return resultadoValidacao;
        }
    }
}
