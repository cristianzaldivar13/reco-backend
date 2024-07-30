namespace Core.Configuraciones
{
	public class RecompensasConfig
	{
		public string Dispositivos { get; set; }
		public string LogsApi { get; set; }
		public string RutadeArchivos { get; set; }
		public string RutaImagenUsuario { get; set; }
		public string DominioServidor { get; set; }
		public string DominioApi { get; set; }
		public string DominioSinVinculo { get; set; }
		public string RutaGrafico { get; set; }
		public string LabelEncuestasNoPonderadas { get; set; }
		public string VersionApp { get; set; }
		public int validarApk { get; set; }
		public string URLMicroservicios { get; set; }
		public string ApplicationID { get; set; }
		public string ApplicationPassword { get; set; }
		public string TipoAmbiente { get; set; }
		public string CarpetaImagenes { get; set; }
		public string TokenLuxand {  get; set; }
		public string TokenGoogleApi { get; set; }
		public string CurpApiToken { get; set; }
		public string TokenNubarium { get; set; }

        public RecompensasConfig()
		{
			Dispositivos = string.Empty;
			LogsApi = string.Empty;
			RutadeArchivos = string.Empty;
			RutaImagenUsuario = string.Empty;
			DominioServidor = string.Empty;
			DominioApi = string.Empty;
			DominioSinVinculo = string.Empty;
			RutaGrafico = string.Empty;
			LabelEncuestasNoPonderadas = string.Empty;
			VersionApp = string.Empty;
			validarApk = 0;
			URLMicroservicios = string.Empty;
			ApplicationID = string.Empty;
			ApplicationPassword = string.Empty;
			TipoAmbiente = string.Empty;
			CarpetaImagenes = string.Empty;
            TokenLuxand = string.Empty;
			TokenGoogleApi = string.Empty;
			CurpApiToken = string.Empty;
			TokenNubarium = string.Empty;
        }

		public string[] Split(char delimiter)
		{
			string[] dispositivoArray = Dispositivos.Split(delimiter);
			return dispositivoArray.Where(s => !string.IsNullOrEmpty(s)).ToArray();
		}
	}
}
