using Core.Enums;

namespace Core.Vistas
{
    public class ViUsuarioPerfil
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Perfil { get; set; }

        public string Imagen { get; set; }
        public string Avatar
        {
            get { return CFG.IArchivo.RutaExterna(EnumCarpeta.Usuarios, Imagen); }
        }

        public ViUsuarioPerfil()
        {
            Nombre = string.Empty;
            Telefono = string.Empty;
            Email = string.Empty;
            Perfil = string.Empty;
            Imagen = string.Empty;
        }
    }
}
