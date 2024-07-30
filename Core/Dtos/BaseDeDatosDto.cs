namespace Core.Dtos
{
    public class BaseDeDatosDto
    {
        public string Tipo { get; set; }
        public string Servidor { get; set; }
        public string Catalogo { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }

        public BaseDeDatosDto() { 
            Tipo = string.Empty;
            Servidor = string.Empty;
            Catalogo = string.Empty;
            Usuario = string.Empty;
            Password = string.Empty;
        }
    }
}
