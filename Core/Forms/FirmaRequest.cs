using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Forms
{
    public class FirmaRequest
    {
        public required IFormFile Ine { get; set; }
        public required IFormFile FrirmaDigital { get; set; }
    }
}
