using Core.Enums;

namespace Core.Vistas
{
    public class ViParametroDetalle : ViSharedDetalle
    {
        public string Nombre { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public string LimiteInferior { get; set; }
        public string LimiteSuperior { get; set; }
        public EnumParametro CveTipo { get; set; }

        public ViParametroDetalle()
        {
            Nombre = string.Empty;
            Valor = string.Empty;
            Descripcion = string.Empty;
            LimiteInferior = string.Empty;
            LimiteSuperior = string.Empty;
        }
    }
}
