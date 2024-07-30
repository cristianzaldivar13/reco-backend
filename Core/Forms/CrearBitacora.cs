using Core.Forms.Resource;
using System.ComponentModel.DataAnnotations;

namespace Core.Forms
{
	public class CrearBitacora
	{
		/// <summary>
		/// Identificador de la bitacora de tipo entero
		/// </summary>
		public int id { get; set; }

		/// <summary>
		/// Error de tipo cadena
		/// </summary>
		[Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.ErrorRequerido))]
		public string error { get; set; }

		/// <summary>
		/// metodo de la bitacora de tipo cadena
		/// </summary>
		[Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.MetodoRequerido))]
		public string metodo { get; set; }

		/// <summary>
		/// fecha de la bitacora de tipo cadena
		/// </summary>
		[Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.FechaRequerida))]
		public string fecha { get; set; }

		/// <summary>
		/// Identificador del usuario de tipo entero
		/// </summary>
		[Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.UsuarioIdRequerido))]
		public int idUsuario { get; set; }

		/// <summary>
		/// Plataforma de tipo entero
		/// </summary>
		[Required(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.PlataformaRequerida))]
		public int plataforma { get; set; }
	}
}
