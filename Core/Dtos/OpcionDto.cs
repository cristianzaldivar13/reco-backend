namespace Core.Dtos
{
    public class OpcionDto
    {
        public long Id { get; set; }
        public string Valor { get; set; }

        public OpcionDto()
        {
            Valor = string.Empty;
        }
    }
}
