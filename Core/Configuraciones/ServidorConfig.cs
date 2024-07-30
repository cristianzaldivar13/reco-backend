namespace Core.Configuraciones
{
    public class ServidorConfig
    {
        public string UrlDefaultWebSite { get; set; }
        public string PathDefaultWebSite { get; set; }
        public string UrlWebService { get; set; }
        public string PathWebService { get; set; }
        public string UrlBackOffice { get; set; }
        public string PathBackOfficeAssets { get; set; }
        public string PathAmbiente { get; set; }

        public ServidorConfig()
        {
            UrlDefaultWebSite = string.Empty;
            PathDefaultWebSite = string.Empty;
            UrlWebService = string.Empty;
            PathWebService = string.Empty;
            UrlBackOffice = string.Empty;
            PathBackOfficeAssets = string.Empty;
            PathAmbiente = string.Empty;
        }
    }
}
