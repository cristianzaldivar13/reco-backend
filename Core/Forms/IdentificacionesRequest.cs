namespace Core.Forms
{
    public class IdentificacionesRequest
    {
        public string Reverso { get; set; }
        public string Anverso { get; set; }
        public string IneBase64 { get; set; }
        public string SelfieBase64 {  get; set; }
        public string FirmaDigitalBase64 { get; set; }

        public IdentificacionesRequest()
        {
            Reverso = string.Empty;
            Anverso = string.Empty;
            IneBase64 = string.Empty;
            SelfieBase64 = string.Empty;
            FirmaDigitalBase64 = string.Empty;
        }
    }
}
