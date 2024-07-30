namespace Core.Annotations.Modelos
{
    public class Block
    {
        public Property2 property { get; set; }
        public Boundingbox boundingBox { get; set; }
        public Paragraph[] paragraphs { get; set; }
        public string blockType { get; set; }
    }

}
