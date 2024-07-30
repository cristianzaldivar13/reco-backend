namespace Core.Annotations.Modelos
{
    public class Webdetection
    {
        public Webentity[] webEntities { get; set; }
        public Fullmatchingimage[] fullMatchingImages { get; set; }
        public Partialmatchingimage[] partialMatchingImages { get; set; }
        public Pageswithmatchingimage[] pagesWithMatchingImages { get; set; }
        public Visuallysimilarimage[] visuallySimilarImages { get; set; }
        public Bestguesslabel[] bestGuessLabels { get; set; }
    }

}
