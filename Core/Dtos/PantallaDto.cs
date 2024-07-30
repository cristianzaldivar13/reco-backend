using Core.Enums;

namespace Core.Dtos
{
    public class PantallaDto
    {
        public string Modulo { get; set; }
        public EnumModulo ModuloId { get; set; }
        public EnumPantalla PantallaId { get; set; }
        public string Pantalla { get; set; }
        public bool EstaActivado { get; set; }
        public EnumPlataforma SistemaOperativo { get; set; }

        public PantallaDto()
        {
            Modulo = string.Empty;
            Pantalla = string.Empty;
        }
    }
}
