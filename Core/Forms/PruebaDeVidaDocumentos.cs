using Microsoft.AspNetCore.Http;

namespace Core.Forms
{
    public class PruebaDeVidaDocumentos
    {
        public required IFormFile Selfie { get; set; }
        public required IFormFile Video { get; set; }
        public required string TextoComparativo { get; set; }
    }
}
