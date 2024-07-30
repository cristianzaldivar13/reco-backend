namespace Core.Vistas
{
    public class ViUsuario : ViShared
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Username { get; set; }
        public string Perfil { get; set; }
        public bool EstaBloqueado { get; set; }
        public string Imagen { get; set; }
        public ViUsuario()
        {
            Nombre = string.Empty;
            Email = string.Empty;
            Telefono = string.Empty;
            Username = string.Empty;
            Perfil = string.Empty;
            Imagen = string.Empty;
        }
    }
}
