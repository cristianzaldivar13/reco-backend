namespace Core.Forms
{
    public class ReenvioEmail
	{
		/// <summary>
		/// Identificador de la ruta de ejecucion de tipo entero  
		/// </summary>
		public int idRutaEjecucion { get; set; }

		/// <summary>
		/// Identificador de la encuesta de tipo entero 
		/// </summary>
		public int idEncuesta { get; set; }

		/// <summary>
		/// Identificador de la tienda de tipo entero 
		/// </summary>
		public int idTienda { get; set; }

		/// <summary>
		/// Identificador del usuario de tipo entero  
		/// </summary>
		public int idUsuario { get; set; }

		/// <summary>
		/// Correo de la tienda a la cual sera enviada la encuesta de tipo cadena 
		/// </summary>
		public string correoTienda { get; set; }

		/// <summary>
		/// Correo del asesor de tipo cadena 
		/// </summary>
		public string correoAsesor { get; set; }

		/// <summary>
		/// Correo para enviar una copia de tipo cadena
		/// </summary>
		public string correoCC { get; set; }

		/// <summary>
		/// Nombre de la encuesta de tipo cadena
		/// </summary>
		public string? nombreEncuesta { get; set; }

		/// <summary>
		/// Tipo del formato del correo de tipo entero  
		/// </summary>
		public int tipoFormato { get; set; }
	}
}
