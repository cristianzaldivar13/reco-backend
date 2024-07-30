namespace Core.Configuraciones
{
    public class EmailConfig
    {
        public string Usuario { get; set; }
        public string Direccion { get; set; }
        public string Password { get; set; }
        public string Servidor { get; set; }
        public int Puerto { get; set; }
        public bool SSL { get; set; }

        public EmailConfig()
        {
            Usuario = string.Empty;
            Direccion = string.Empty;
            Password = string.Empty;
            Servidor = string.Empty;
            SSL = false;
        }
    }
}
