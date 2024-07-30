namespace Core.Dtos
{
    public class CargaMasivaDto
    {
        public string Celda { get; set; }
        public string Mensaje { get; set; }

        public CargaMasivaDto()
        {
            Celda = string.Empty;
            Mensaje = string.Empty;
        }
    }
}
