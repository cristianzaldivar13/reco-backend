using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Core.Forms
{
    public class Registro_de_Cliente
    {
        public int Folio { get; set; }
        public int Usuario_que_Registra { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public bool Confidencial { get; set; }
        public int Codigo_de_Cliente { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre { get; set; }
        public string Nombre_Completo { get; set; }
        public int Tipo_de_Cliente { get; set; }
        public string Correo { get; set; }
        public string Persona_de_Contacto { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
        public string Telefono_1 { get; set; }
        public string Telefono_2 { get; set; }
        public int Identificacion { get; set; }
        public int Documento_de_Identificacion { get; set; }
        public string Numero_Fiscal { get; set; }
        public int Condicion_Fiscal { get; set; }
        public string Cualificacion { get; set; }
        public short Cantidad_Letras_Impagas { get; set; }
        public int Programa { get; set; }
        public DateTime? Fecha_de_Baja { get; set; }
        public short Numero_de_Reclamos_Hechos { get; set; }
        public short Numero_de_Reclamos_Hechos_Favorables { get; set; }
        public short Numero_de_Reclamos_Hechos_Pendientes { get; set; }
        public string Cuenta_Bancaria { get; set; }
        public int? Banco { get; set; }
        public int Usuario_que_da_de_Alta { get; set; }
        public DateTime? Fecha_de_Alta_de_Domiciliacion { get; set; }
        public int? Cuenta { get; set; }
        public string Nombre_del_Titular { get; set; }
        public decimal Importe_Maximo { get; set; }
        public int? Estatus_Domiciliacion { get; set; }
        public DateTime? Fecha_de_Baja_de_Domicializacion { get; set; }
        public int Usuario_que_da_de_Baja { get; set; }

        public Registro_de_Cliente()
        {
            Folio = 0;
            Usuario_que_Registra = 0;
            Fecha_de_Registro = null;
            Hora_de_Registro = string.Empty;
            Confidencial = false;
            Codigo_de_Cliente = 0;
            Apellido_Paterno = string.Empty;
            Apellido_Materno = string.Empty;
            Nombre = string.Empty;
            Nombre_Completo = string.Empty;
            Tipo_de_Cliente = 0;
            Correo = string.Empty;
            Persona_de_Contacto = string.Empty;
            CURP = string.Empty;
            RFC = string.Empty;
            Telefono_1 = string.Empty;
            Telefono_2 = string.Empty;
            Identificacion = 0;
            Documento_de_Identificacion = 0;
            Numero_Fiscal = string.Empty;
            Condicion_Fiscal = 0;
            Cualificacion = string.Empty;
            Cantidad_Letras_Impagas = 0;
            Programa = 0;
            Fecha_de_Baja = null;
            Numero_de_Reclamos_Hechos = 0;
            Numero_de_Reclamos_Hechos_Favorables = 0;
            Numero_de_Reclamos_Hechos_Pendientes = 0;
            Cuenta_Bancaria = string.Empty;
            Banco = null;
            Usuario_que_da_de_Alta = 0;
            Fecha_de_Alta_de_Domiciliacion = null;
            Cuenta = null;
            Nombre_del_Titular = string.Empty;
            Importe_Maximo = 0;
            Estatus_Domiciliacion = null;
            Fecha_de_Baja_de_Domicializacion = null;
            Usuario_que_da_de_Baja = 0;
        }
    }

}
