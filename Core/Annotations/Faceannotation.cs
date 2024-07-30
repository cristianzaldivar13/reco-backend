using Core.Annotations.Modelos;

namespace Core.Annotations
{
    public class Faceannotation
    {
        public Boundingpoly BoundingPoly { get; set; }
        public Fdboundingpoly FdBoundingPoly { get; set; }
        public Landmark[] Landmarks { get; set; }
        public float RollAngle { get; set; }
        public float PanAngle { get; set; }
        public float TiltAngle { get; set; }
        public float DetectionConfidence { get; set; }
        public float LandmarkingConfidence { get; set; }
        public string JoyLikelihood { get; set; }
        public string SorrowLikelihood { get; set; }
        public string AngerLikelihood { get; set; }
        public string SurpriseLikelihood { get; set; }
        public string UnderExposedLikelihood { get; set; }
        public string BlurredLikelihood { get; set; }
        public string HeadwearLikelihood { get; set; }

        public Faceannotation()
        {
            BoundingPoly = new Boundingpoly();
            FdBoundingPoly = new Fdboundingpoly();
            Landmarks = [];
            RollAngle = 0;
            PanAngle = 0;
            TiltAngle = 0;
            DetectionConfidence = 0;
            LandmarkingConfidence = 0;
            JoyLikelihood = string.Empty;
            SorrowLikelihood = string.Empty;
            AngerLikelihood = string.Empty;
            SurpriseLikelihood = string.Empty;
            UnderExposedLikelihood = string.Empty;
            BlurredLikelihood = string.Empty;
            HeadwearLikelihood = string.Empty;
        }
    }

}
