using Core.Enums;

namespace Core.Dtos
{
    public class PaginarDto
    {
        public string Busqueda { get; set; }
        public string ColumnaOrden { get; set; }
        public EnumOrdenamiento TipoOrdenamiento { get; set; }
        public EnumEstatus Estatus { get; set; }
        public int NumeroPagina { get; set; }
        public int MedidaPagina { get; set; }

        public PaginarDto()
        {
            Busqueda = string.Empty;
            ColumnaOrden = string.Empty;
            TipoOrdenamiento = EnumOrdenamiento.None;
            Estatus = EnumEstatus.Activo;
            NumeroPagina = 1;
            MedidaPagina = 10;
        }
    }
}
