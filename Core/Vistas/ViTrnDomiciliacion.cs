namespace Core.Vistas
{
    public class ViTrnDomiciliacion
    {
        public int _NO_CUENTA { get; set; }
        public DateTime FECHA_ALTA_DOMI { get; set; }
        public int ID_BANCO { get; set; }
        public int ID_CUENTA { get; set; }
        public string NO_CTA_BANCARIA { get; set; }
        public string NOMBRE_TITULAR { get; set; }
        public decimal IMPORTE_MAXIMO { get; set; }
        public int STATUS_DOMI { get; set; }
        public DateTime FECHA_BAJA_DOMI { get; set; }
        public string USUARIO_ALTA { get; set; }
        public string USUARIO_BAJA { get; set; }

        public ViTrnDomiciliacion()
        {
            _NO_CUENTA = 0;
            FECHA_ALTA_DOMI = new DateTime();
            ID_BANCO = 0;
            ID_CUENTA = 0;
            NO_CTA_BANCARIA = string.Empty;
            NOMBRE_TITULAR = string.Empty;
            IMPORTE_MAXIMO = 0.0m;
            STATUS_DOMI = 0;
            FECHA_BAJA_DOMI = new DateTime();
            USUARIO_ALTA = string.Empty;
            USUARIO_BAJA = string.Empty;
        }
    }
}
