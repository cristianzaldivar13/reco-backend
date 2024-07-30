namespace Core.Annotations.Modelos
{
    public class Respons
    {
        public Faceannotation[] faceAnnotations { get; set; }
        public Logoannotation[] logoAnnotations { get; set; }
        public Labelannotation[] labelAnnotations { get; set; }
        public Textannotation[] textAnnotations { get; set; }
        public Fulltextannotation fullTextAnnotation { get; set; }
        public Webdetection webDetection { get; set; }
    }

}
