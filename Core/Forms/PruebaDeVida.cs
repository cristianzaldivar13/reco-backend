using Microsoft.AspNetCore.Http;

namespace Core.Forms
{
    public class PruebaDeVida
    {
        public string Video { get; set; }
        public string Selfie { get; set; }
        public string TextoComparativo { get; set; }

        public PruebaDeVida()
        {
            Video = string.Empty;
            Selfie = string.Empty;
            TextoComparativo = string.Empty;
        }
    }
}
