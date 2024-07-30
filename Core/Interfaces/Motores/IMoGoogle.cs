namespace Core.Interfaces.Motores
{
    public interface IMoGoogle
    {
        string EjecutaApiGoogle(string data);
        string ObtenerCredencialesGoogleApi();
    }
}
