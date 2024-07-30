using Core.Enums;
using Core.Forms.DataAnnotations;
using Core.Forms.Resource;
using System.ComponentModel.DataAnnotations;

namespace Core.Forms
{
    public class CrearNotificacion
    {
        public EnumNotificacion Tipo { get; set; }

        [Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.AsuntoRequerido))]
        [MaxLength(100, ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.AsuntoLongitud))]
        public string Asunto { get; set; }

        [Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.MensajeRequerido))]
        [MaxLength(250, ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.MensajeLongitud))]
        public string Mensaje { get; set; }

        public CrearNotificacion()
        {
            Asunto = string.Empty;
            Mensaje = string.Empty;
        }
    }
}
