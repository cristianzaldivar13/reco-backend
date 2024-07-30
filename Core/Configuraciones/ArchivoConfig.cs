namespace Core.Configuraciones
{
    public class ArchivoConfig
    {
        public string CarpetaRaiz { get; set; }
        public List<string> Extensiones { get; set; }
        public List<string> TiposDeContenido { get; set; }

        public ArchivoConfig()
        {
            CarpetaRaiz = string.Empty;
            Extensiones = new List<string>();
            TiposDeContenido = new List<string>();
        }
    }
}
