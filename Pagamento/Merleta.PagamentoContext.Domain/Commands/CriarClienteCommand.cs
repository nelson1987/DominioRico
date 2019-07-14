using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Merleta.PagamentoContext.Domain.Commands
{
    public class CriarClienteCommand : EventCommand
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Documento é obrigatório.")]
        [MinLength(5)]
        [MaxLength(255)]
        public string Documento { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Nome é obrigatório.")]
        [MinLength(5)]
        [MaxLength(255)]
        public string Nome { get; set; }

        public override void Validar()
        {
            var listagemErro = getValidationErros(this);
            if (listagemErro.Count == 0)
                SetIsValid();
        }

    }
}
