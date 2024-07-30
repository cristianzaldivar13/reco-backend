using Core.Enums;

namespace Core.Vistas
{
    public class ViParametro : ViShared
    {
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public string LimiteInferior { get; set; }
        public string LimiteSuperior { get; set; }
        public bool Editable { get; set; }
        public EnumDato CveTipo { get; set; }
        public string Tipo { get { return CveTipo.ToString(); } }

        public ViParametro()
        {
            Clave = string.Empty;
            Nombre = string.Empty;
            Valor = string.Empty;
            Descripcion = string.Empty;
            LimiteInferior = string.Empty;
            LimiteSuperior = string.Empty;
        }
    }
}
