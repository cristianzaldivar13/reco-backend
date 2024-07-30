namespace Core.Forms
{
    public class Registro_de_Inmueble
    {
        public int Folio { get; set; }
        public string Domicilio { get; set; }
        public int Usuario_que_Registra { get; set; }
        public DateTime Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public string Domicilio_Escrituras { get; set; }
        public int Estado { get; set; }
        public int Ciudad { get; set; }
        public int Calle { get; set; }
        public int Colonia { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Departamento { get; set; }
        public int Codigo_Postal { get; set; }
        public int No_Oficial { get; set; }
        public int Bis { get; set; }
        public int Lote { get; set; }
        public int Manzana { get; set; }
        public int Edificacion { get; set; }
        public int Regimen { get; set; }
        public string Referencia { get; set; }
        public int Valor_X { get; set; }
        public int Valor_Y { get; set; }
        public int Valor_Z { get; set; }
        public int Numero_de_Puerta { get; set; }
        public string Numero_Auxiliar { get; set; }
        public string Duplicador { get; set; }
        public int Oficina_Comercial { get; set; }
        public int Area { get; set; }
        public string Numero_de_Padron { get; set; }
        public string Acceso_de_Finca { get; set; }
        public int Estado_de_Inmueble { get; set; }
        public int Tipo_de_Inmueble { get; set; }
        public DateTime Fecha_de_Instalacion { get; set; }
        public int Estado_de_Instalacion { get; set; }
        public DateTime Fecha_de_Baja { get; set; }
        public int Ruta { get; set; }
        public decimal Area_de_Terreno { get; set; }
        public decimal Superficie_de_Jardin { get; set; }
        public decimal Superficie_de_Cultivo { get; set; }
        public decimal Capacidad_de_Cisterna { get; set; }
        public decimal Capacidad_de_Tinaco { get; set; }
        public decimal Capacidad_de_Alberca { get; set; }
        public int Numero_de_Regaderas { get; set; }
        public int Numero_de_Inodoros { get; set; }
        public int Numero_de_Cuartos_de_Servicio { get; set; }
        public int Numero_de_Animales { get; set; }
        public int Tipo_de_Animales { get; set; }

        public Registro_de_Inmueble()
        {
            Folio = 0;
            Usuario_que_Registra = 0;
            Fecha_de_Registro = DateTime.MinValue;
            Hora_de_Registro = string.Empty;
            Domicilio_Escrituras = string.Empty;
            Domicilio = string.Empty;
            Estado = 0;
            Ciudad = 0;
            Calle = 0;
            Colonia = 0;
            Numero_Exterior = string.Empty;
            Numero_Interior = string.Empty;
            Departamento = string.Empty;
            Codigo_Postal = 0;
            No_Oficial = 0;
            Bis = 0;
            Lote = 0;
            Manzana = 0;
            Edificacion = 0;
            Regimen = 0;
            Referencia = string.Empty;
            Valor_X = 0;
            Valor_Y = 0;
            Valor_Z = 0;
            Numero_de_Puerta = 0;
            Numero_Auxiliar = string.Empty;
            Duplicador = string.Empty;
            Oficina_Comercial = 0;
            Area = 0;
            Numero_de_Padron = string.Empty;
            Acceso_de_Finca = string.Empty;
            Estado_de_Inmueble = 0;
            Tipo_de_Inmueble = 0;
            Fecha_de_Instalacion = DateTime.MinValue;
            Estado_de_Instalacion = 0;
            Fecha_de_Baja = DateTime.MinValue;
            Ruta = 0;
            Area_de_Terreno = 0;
            Superficie_de_Jardin = 0;
            Superficie_de_Cultivo = 0;
            Capacidad_de_Cisterna = 0;
            Capacidad_de_Tinaco = 0;
            Capacidad_de_Alberca = 0;
            Numero_de_Regaderas = 0;
            Numero_de_Inodoros = 0;
            Numero_de_Cuartos_de_Servicio = 0;
            Numero_de_Animales = 0;
            Tipo_de_Animales = 0;
        }
    }
}
