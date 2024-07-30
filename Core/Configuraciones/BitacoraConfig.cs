namespace Core.Configuraciones
{
    public class BitacoraConfig
    {
        public string Proyecto { get; set; }
        public string Aplicacion { get; set; }
        public string Origen { get; set; }

        public string NombreArchivo => string.Format("{0}_{1}_{2}.txt", DateTime.Now.ToString("yyyy-MM-dd"), Aplicacion, Origen);

        public BitacoraConfig()
        {
            Proyecto = string.Empty;
            Aplicacion = string.Empty;
            Origen = string.Empty;
        }
    }
}
