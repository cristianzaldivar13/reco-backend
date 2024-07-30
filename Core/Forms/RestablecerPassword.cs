using Core.Forms.Resource;
using System.ComponentModel.DataAnnotations;

namespace Core.Forms
{
    public class RestablecerPassword
    {
        [Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.PasswordRequerido))]
        [StringLength(20, MinimumLength = 6, ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.PasswordLongitud))]
        public string Password { get; set; }

        public RestablecerPassword()
        {
            Password = string.Empty;
        }
    }
}
