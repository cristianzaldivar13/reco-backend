using Core.Forms;
using Core.Vistas;

namespace Core.Interfaces.UnidadDeTrabajo
{
    public interface ISesion
    {
        /// <summary>
        /// Iniciar sesión
        /// </summary>
        /// <param name="form">Formualario</param>
        /// <returns></returns>
        Task<ViSesion> Iniciar(IniciarSesion form);
    }
}
