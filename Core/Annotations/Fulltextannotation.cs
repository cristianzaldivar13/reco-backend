using Core.Annotations.Modelos;

namespace Core.Annotations
{
    public class Fulltextannotation
    {
        public Page[] Pages { get; set; }
        public string Text { get; set; }

        public Fulltextannotation() { 
            Pages = [];
            Text = string.Empty;
        }
    }

}
