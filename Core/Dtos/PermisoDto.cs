using Core.Enums;

namespace Core.Dtos
{
    public class PermisoDto
    {
        public string Modulo { get; set; }
        public EnumPantalla PantallaId { get; set; }
        public string Pantalla { get; set; }
        public EnumFuncion FuncionId { get; set; }
        public string Funcion { get; set; }
        public bool EstaActivado { get; set; }
        public bool EstaPermitido { get; set; }
        public EnumPlataforma SistemaOperativo { get; set; }

        public PermisoDto()
        {
            Modulo = string.Empty;
            Pantalla = string.Empty;
            Funcion = string.Empty;
        }
    }
}
