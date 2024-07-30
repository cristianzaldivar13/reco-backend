using Core.Enums;

namespace Core.Dtos
{
    public class PaginarFiltrosDto : PaginarDto
    {
        public int[] Ids { get; set; }
        public List<long> Usuarios { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }

        public PaginarFiltrosDto()
        {
            Ids = [];
            Usuarios = [];
            FechaInicial = DateTime.MinValue;
            FechaFinal = DateTime.MinValue;
        }
    }
}
