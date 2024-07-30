using System.Text;

namespace Core.Configuraciones
{
    public class TokenJwtConfig
    {
        public string LlaveSecreta { get; set; }
        public bool RequiereHttpsMetadata { get; set; }

        public byte[] LlaveCodificada => Encoding.ASCII.GetBytes(LlaveSecreta);

        public TokenJwtConfig()
        {
            LlaveSecreta = string.Empty;
            RequiereHttpsMetadata = false;
        }
    }
}
