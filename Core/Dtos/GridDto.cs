namespace Core.Dtos
{
    public class GridDto<T> where T : class
    {
        public long Total { get; set; }
        public IEnumerable<T> Filas { get; set; }

        public GridDto()
        {
            Total = 0;
            Filas = new List<T>();
        }
    }
}
