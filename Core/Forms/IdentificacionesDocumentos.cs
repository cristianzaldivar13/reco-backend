using Microsoft.AspNetCore.Http;

namespace Core.Forms
{
    public class IdentificacionesDocumentos
    {
        public required IFormFile Anverso { get; set; }
        public required IFormFile Reverso { get; set; }
    }
}
