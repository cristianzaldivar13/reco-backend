namespace Core.Forms
{
    public class Registro_de_Contrato
    {
        public int Folio { get; set; }
        public string NIS { get; set; }
        public int Usuario_que_Registra { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int Numero_de_Solicitud { get; set; }
        public int Domicilio_del_Suministro { get; set; }
        public int Medidor_Asignado { get; set; }
        public int Numero_de_Expediente { get; set; }
        public int NIF { get; set; }
        public int Indicador_de_Levantamiento { get; set; }
        public int Estatus_Deuda_Cliente { get; set; }
        public int Estatus_Deuda_Servicio { get; set; }
        public int Cliente { get; set; }
        public string Informacion_del_Cliente { get; set; }
        public DateTime? Fecha_de_Ingreso { get; set; }
        public int Tipo_de_Contrato { get; set; }
        public int Anomalia { get; set; }
        public decimal Diametro_de_Agua_mm { get; set; }
        public decimal Diametro_de_Drenaje_mm { get; set; }
        public decimal Consumo_Estimado_m3 { get; set; }
        public decimal Construccion_m2 { get; set; }
        public int Giro { get; set; }
        public int Tarifa { get; set; }
        public string Grupo_Concepto { get; set; }
        public int Periodo_de_Facturacion { get; set; }
        public int Periodo_de_Lectura { get; set; }
        public int Estimacion { get; set; }
        public decimal Volumen_Contratado_m3 { get; set; }
        public string Tarifa_Aportacion { get; set; }
        public int Tipo_de_Recargo { get; set; }
        public decimal Tasa_de_Recargo { get; set; }
        public int No_Deptos { get; set; }
        public string Reg_Propiedad { get; set; }
        public DateTime? Fecha_Actual { get; set; }
        public int Estado_del_Suministro { get; set; }
        public DateTime? Fecha_de_Modificacion_de_Contrato { get; set; }
        public short Secuencial_de_Modificacion { get; set; }
        public DateTime? Fecha_de_Baja { get; set; }
        public int Tipo_de_Baja { get; set; }
        public string Comentarios { get; set; }
        public DateTime? Fecha_de_Corte { get; set; }
        public decimal Consumo_Fijo { get; set; }
        public string Hora_Util { get; set; }
        public DateTime? Fecha_Limite_de_Contrato { get; set; }
        public string Duracion_de_Contrato { get; set; }
        public string Numero_de_Plaza { get; set; }
        public int NIS_Solidario { get; set; }
        public int Codigo_de_Cliente_Solidario { get; set; }
        public short Secuencial_NIS_Solidario { get; set; }
        public int Tipo_de_Multa { get; set; }
        public decimal Tasa_de_Multa { get; set; }
        public string Grupo_Familiar { get; set; }
        public string Numero_de_Expedicion { get; set; }
        public string Tipo_de_Tarifa_Recaudacion { get; set; }
        public int Tipo_de_Sumistro { get; set; }
        public int Tipo_de_Asociado { get; set; }
        public decimal Impuesto_Derechos_de_Conexion { get; set; }
        public int Secuencial_de_Factura { get; set; }
        public int Secuencial_NIS { get; set; }
        public short Numero_de_Corte { get; set; }
        public short Contador_de_Lecturas_Diferentes { get; set; }
        public decimal Importe_de_la_Fianza { get; set; }
        public DateTime? Fecha_de_Devolucion_de_Fianza { get; set; }
        public DateTime? Fecha_de_Resolucion_del_Contrato { get; set; }
        public string Codigo_de_Recargos { get; set; }
        public int Anomalias_no_Detectables { get; set; }
        public int Programa { get; set; }
        public short Indicador_de_Bonificacion { get; set; }
        public int Bonificacion_Reactivada { get; set; }
        public string Contrato_Lectura_Representante { get; set; }
        public int Tipo_de_Asociacion { get; set; }
        public int Oficina_a_la_que_Pertenece_el_Sumistro { get; set; }
        public string Codigo_de_Anomalia { get; set; }
        public short Indicador_de_Control_de_Lectura { get; set; }
        public int Tipo_de_Distribucion_Anticipos { get; set; }
        public string Nombre_del_Representante_Legal { get; set; }
        public string RFC_del_Representante_Legal { get; set; }
        public string CURP_del_Representante_Legal { get; set; }
        public string Razon_Social { get; set; }
        public int Tipo_de_Conexion_de_Agua { get; set; }
        public int Tipo_de_Conexion_de_Drenaje { get; set; }
        public decimal Total { get; set; }

        public Registro_de_Contrato()
        {
            NIS = string.Empty;
            Hora_de_Registro = string.Empty;
            Informacion_del_Cliente = string.Empty;
            Grupo_Concepto = string.Empty;
            Tarifa_Aportacion = string.Empty;
            Reg_Propiedad = string.Empty;
            Comentarios = string.Empty;
            Hora_Util = string.Empty;
            Duracion_de_Contrato = string.Empty;
            Numero_de_Plaza = string.Empty;
            Grupo_Familiar = string.Empty;
            Numero_de_Expedicion = string.Empty;
            Tipo_de_Tarifa_Recaudacion = string.Empty;
            Codigo_de_Recargos = string.Empty;
            Contrato_Lectura_Representante = string.Empty;
            Codigo_de_Anomalia = string.Empty;
            Nombre_del_Representante_Legal = string.Empty;
            RFC_del_Representante_Legal = string.Empty;
            CURP_del_Representante_Legal = string.Empty;
            Razon_Social = string.Empty;
            Folio = 0;
            Usuario_que_Registra = 0;
            Fecha_de_Registro = DateTime.MinValue;
            Numero_de_Solicitud = 0;
            Domicilio_del_Suministro = 0;
            Medidor_Asignado = 0;
            Numero_de_Expediente = 0;
            NIF = 0;
            Indicador_de_Levantamiento = 0;
            Estatus_Deuda_Cliente = 0;
            Estatus_Deuda_Servicio = 0;
            Cliente = 0;
            Fecha_de_Ingreso = DateTime.MinValue;
            Tipo_de_Contrato = 0;
            Anomalia = 0;
            Diametro_de_Agua_mm = 0;
            Diametro_de_Drenaje_mm = 0;
            Consumo_Estimado_m3 = 0;
            Construccion_m2 = 0;
            Giro = 0;
            Tarifa = 0;
            Periodo_de_Facturacion = 0;
            Periodo_de_Lectura = 0;
            Estimacion = 0;
            Volumen_Contratado_m3 = 0;
            Tipo_de_Recargo = 0;
            Tasa_de_Recargo = 0;
            No_Deptos = 0;
            Estado_del_Suministro = 0;
            Secuencial_de_Modificacion = 0;
            Tipo_de_Baja = 0;
            Consumo_Fijo = 0;
            Fecha_Limite_de_Contrato = DateTime.MinValue;
            NIS_Solidario = 0;
            Codigo_de_Cliente_Solidario = 0;
            Secuencial_NIS_Solidario = 0;
            Tipo_de_Multa = 0;
            Tasa_de_Multa = 0;
            Tipo_de_Sumistro = 0;
            Tipo_de_Asociado = 0;
            Impuesto_Derechos_de_Conexion = 0;
            Secuencial_de_Factura = 0;
            Secuencial_NIS = 0;
            Numero_de_Corte = 0;
            Contador_de_Lecturas_Diferentes = 0;
            Importe_de_la_Fianza = 0;
            Indicador_de_Bonificacion = 0;
            Bonificacion_Reactivada = 0;
            Tipo_de_Asociacion = 0;
            Oficina_a_la_que_Pertenece_el_Sumistro = 0;
            Indicador_de_Control_de_Lectura = 0;
            Tipo_de_Distribucion_Anticipos = 0;
            Tipo_de_Conexion_de_Agua = 0;
            Tipo_de_Conexion_de_Drenaje = 0;
            Total = 0;
        }
    }
}
