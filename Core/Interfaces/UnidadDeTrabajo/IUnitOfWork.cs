namespace Core.Interfaces.UnidadDeTrabajo
{
    public interface IUnitOfWork
    {
        ISesion Sesion { get; }
        IUsuario Usuario { get; }
        IParametro Parametro { get; }
        IPassword Password { get; }
        IPermiso Permiso { get; }
    }
}
