using Core.Enums;
using Core.Forms.Resource;
using System.ComponentModel.DataAnnotations;

namespace Core.Forms
{
    public class EditarParametro
    {
        public EnumParametro Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.ValorRequerido))]
        [MaxLength(25, ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.ValorLongitud))]
        public string Valor { get; set; }

        public EditarParametro()
        {
            Valor = string.Empty;
        }
    }
}
