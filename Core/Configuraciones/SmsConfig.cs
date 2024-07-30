namespace Core.Configuraciones
{
    public class SmsConfig
    {
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public string TwilioTelefono { get; set; }

        public SmsConfig()
        {
            ApiKey = string.Empty;
            ApiSecret = string.Empty;
            TwilioTelefono = string.Empty;
        }
    }
}
