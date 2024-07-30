using Core.Enums;

namespace Core.Vistas
{
    public class ViUsuarioDetalle : ViSharedDetalle
    {
        public EnumUsuario TipoId { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Imagen { get; set; }
        public string UrlImagen
        {
            get { return CFG.IArchivo.RutaExterna(EnumCarpeta.Usuarios, Imagen); }
        }

        public int GeneroId { get; set; }
        public string Genero { get; set; }
        public long PerfilId { get; set; }
        public string Perfil { get; set; }
        public bool EstaBloqueado { get; set; }
        public bool PrimerAcceso { get; set; }

        public bool ControlTotal { get; set; }

        public ViUsuarioDetalle()
        {
            Tipo = string.Empty;
            Perfil = string.Empty;
            Nombre = string.Empty;
            ApellidoPaterno = string.Empty;
            ApellidoMaterno = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Imagen = string.Empty;
            Genero = string.Empty;
            Username = string.Empty;
            Telefono = string.Empty;
            ControlTotal = false;
        }
    }
}
