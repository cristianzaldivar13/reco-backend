using Core.Annotations.Modelos;

namespace Core.Annotations
{
    public class Logoannotation
    {
        public string Mid { get; set; }
        public string Description { get; set; }
        public float Score { get; set; }
        public Boundingpoly1 BoundingPoly { get; set; }

        public Logoannotation()
        {
            Mid = string.Empty;
            Description = string.Empty;
            Score = 0;
            BoundingPoly = new Boundingpoly1();
        }
    }

}
