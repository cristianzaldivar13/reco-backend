using Core.Forms.Resource;
using System.ComponentModel.DataAnnotations;

namespace Core.Forms
{
    public class RecuperarPassword
    {
        [Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.EmailRequerido))]
        [MaxLength(80, ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.EmailLongitud))]
        [EmailAddress(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.EmailEstructura))]
        public string Email { get; set; }

        public RecuperarPassword()
        {
            Email = string.Empty;
        }
    }
}
