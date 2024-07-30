namespace Core.Forms
{
    public class Identificaciones
    {
        public string Similitud { get; set; }
        public String CodigoResultado { get; set; }
        public bool Error { get; set; }
        public string DescripcionResultado { get; set; }

        public Identificaciones()
        {
            Similitud = string.Empty;
            CodigoResultado = string.Empty;
            Error = false;
            DescripcionResultado = string.Empty;
        }
    }
}
