namespace Core.Clases
{
	public class ClsServiceResponse
	{
		/// <summary>
		/// Código de respuesta si es de error o de exitoso de tipo entero
		/// </summary>
		public int CodigoRespuesta { get; set; }

		/// <summary>
		/// Descripcion del código de respuesta de tipo cadena
		/// </summary>
		public required string Mensaje { get; set; }

		/// <summary>
		/// /Retornara los valores devueltos por la ejecucion del metodo de tipo objeto
		/// </summary>
		public object? Datos { get; set; }
	}
}
