using Core.Forms.Resource;
using Core.Vistas;
using System.ComponentModel.DataAnnotations;

namespace Core.Forms
{
    public class IniciarSesion
    {
        [Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.UsernameRequerido))]
        public string Username { get; set; }

        [Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.PasswordRequerido))]
        public string Password { get; set; }

        public IniciarSesion()
        {
            Username = string.Empty;
            Password = string.Empty;
        }
    }
}
