namespace Core.Annotations
{
    public class Labelannotation
    {
        public string Mid { get; set; }
        public string Description { get; set; }
        public float Score { get; set; }
        public float Topicality { get; set; }

        public Labelannotation() {
            Mid = string.Empty;
            Description = string.Empty;
            Score = 0;
            Topicality = 0;
        }
    }

}
