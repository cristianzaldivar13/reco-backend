using Core.Enums;
using Core.Forms.DataAnnotations;
using Core.Forms.Resource;
using System.ComponentModel.DataAnnotations;

namespace Core.Forms
{
    public class CrearUsuario
    {
        // Información de la persona
        [Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.NombreRequerido))]
        [MaxLength(50, ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.NombreLongitud))]
        public string Nombre { get; set; }

        [Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.ApellidoPaternoRequerido))]
        [MaxLength(50, ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.ApellidoPaternoLongitud))]
        public string ApellidoPaterno { get; set; }

        [Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.ApellidoMaternoRequerido))]
        [MaxLength(50, ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.ApellidoMaternoLongitud))]
        public string ApellidoMaterno { get; set; }

        [Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.EmailRequerido))]
        [MaxLength(80, ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.EmailLongitud))]
        [EmailAddress(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.EmailEstructura))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.TelefonoRequerido))]
        [MaxLength(10, ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.TelefonoLongitud))]
        public string Telefono { get; set; }

        [IdRequerido(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.GeneroRequerido))]
        public long GeneroId { get; set; }

        [IdRequerido(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.PerfilRequerido))]
        public long PerfilId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.UsernameRequerido))]
        [MaxLength(20, ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.UsernameLongitud))]
        public string Username { get; set; }

        [Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.PasswordRequerido))]
        [StringLength(32, MinimumLength = 8, ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.PasswordLongitud))]
        public string Password { get; set; }

        public CrearUsuario()
        {
            Username = string.Empty;
            Password = "MiEmpresa";
            Nombre = string.Empty;
            ApellidoPaterno = string.Empty;
            ApellidoMaterno = string.Empty;
            Email = string.Empty;
            PerfilId = 1;
            Telefono = string.Empty;
        }
    }
}
