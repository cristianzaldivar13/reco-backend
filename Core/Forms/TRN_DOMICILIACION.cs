using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Forms
{
    public class TRN_DOMICILIACION
    {
        public int NO_CUENTA { get; set; }
        public DateTime FECHA_ALTA_DOMI { get; set; }
        public int ID_BANCO { get; set; }
        public int ID_CUENTA { get; set; }
        public string NO_CTA_BANCARIA { get; set; }
        public char NOMBRE_TITULAR { get; set; }
        public decimal IMPORTE_MAXIMO { get; set; }
        public char STATUS_DOMI { get; set; }
        public DateTime FECHA_BAJA_DOMI { get; set; }
        public string USUARIO_ALTA { get; set; }
        public string USUARIO_BAJA { get; set; }
    }
}
