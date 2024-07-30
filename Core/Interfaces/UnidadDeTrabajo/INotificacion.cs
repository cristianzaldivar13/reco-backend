using Core.Forms;
using Core.Vistas;

namespace Core.Interfaces.UnidadDeTrabajo
{
    public interface INotificacion
    {
        /// <summary>
        /// Creación de un registro de notificación
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="form"></param>
        /// <returns></returns>
        Task<long> Crear(long usuarioId, CrearNotificacion form);

        /// <summary>
        /// Edición de un registro de notificación
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="notificationId"></param>
        /// <returns></returns>
        Task<bool> Editar(long usuarioId, long notificationId);

        /// <summary>
        /// Eliminación de un registro de notificación
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="notificationId"></param>
        /// <returns></returns>
        Task<bool> Eliminar(long usuarioId, long notificationId);

        /// <summary>
        /// Lista de registros de notificaciones delimitada por empresa
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <returns></returns>
        Task<IEnumerable<ViNotificacion>> Lista(long usuarioId);
    }
}
