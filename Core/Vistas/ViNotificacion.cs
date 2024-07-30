namespace Core.Vistas
{
	public class ViNotificacion : ViShared
	{
		/// <summary>
		/// Identificador de la notificacion de tipo entero
		/// </summary>
		public int IdNotificacion { get; set; }

		/// <summary>
		/// Identificador del negocio de tipo entero
		/// </summary>
		public int IdNegocio { get; set; }

		/// <summary>
		/// Identificador de tipo de notificacion de tipo entero
		/// </summary>
		public int IdTipoNotificacion { get; set; }

		/// <summary>
		/// Identificador del usuario que envia la notificacion de tipo entero
		/// </summary>
		public int IdUsuarioRemitente { get; set; }

		/// <summary>
		/// Identificador del usuario a quien esta destinada la notificacion de tipo entero
		/// </summary>
		public int IdUsuarioDestino { get; set; }

		/// <summary>
		/// Valida si ya esta leida la notificacion de tipo entero
		/// </summary>
		public int Leido { get; set; }

		/// <summary>
		/// Titulo de la notificacion de tipo cadena
		/// </summary>
		public string Titulo { get; set; }

		/// <summary>
		/// Contenido de la notificacion de tipo cadena
		/// </summary>
		public string Contenido { get; set; }

		/// <summary>
		/// Identificador de la referencia del registro afectado de tipo cadena
		/// </summary>
		public string IdReferencia { get; set; }

		/// <summary>
		/// Fecha de recibo de la notificacion de tipo cadena
		/// </summary>
		public string FechaHoraRecibido { get; set; }

		/// <summary>
		/// Fecha y hora de leida la notificacion de tipo cadena
		/// </summary>
		public string FechaHoraLeido { get; set; }

		/// <summary>
		/// Fecha y hora del alta del registro DE TIPO CADENA
		/// </summary>
		public string FechaHoraAlta { get; set; }

		public ViNotificacion()
		{
			IdNotificacion = 0;
			IdNegocio = 0;
			IdTipoNotificacion = 0;
			IdUsuarioRemitente = 0;
			IdUsuarioDestino = 0;
			Leido = 0;
			Titulo = string.Empty;
			Contenido = string.Empty;
			IdReferencia = string.Empty;
			FechaHoraRecibido = string.Empty;
			FechaHoraLeido = string.Empty;
			FechaHoraAlta = string.Empty;
		}
	}
}
