using Core.Dtos;
using Core.Enums;
using Core.Forms;

namespace Core.Interfaces.UnidadDeTrabajo
{
    public interface IPermiso
    {
        /// <summary>
        /// Lista de registros de pantallas del sistema
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<PantallaDto>> PantallasSistema();

        /// <summary>
        /// Lista de registros de funciones del sistema asignadas por empresa
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<PantallaDto>> PantallasSistemaAsignadas();


        /// <summary>
        /// Lista de registros de funciones del sistema		
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<PermisoDto>> FuncionesSistema();

        /// <summary>
        /// Lista de registros de funciones del sistema asignadas por perfil
        /// </summary>
        /// <param name="perfilId">Identificador del perfil</param>
        /// <returns></returns>
        Task<IEnumerable<PermisoDto>> FuncionesSistemaAsignados(long perfilId);

        /// <summary>
        /// Lista de registros de permisos asignados a un perfil
        /// </summary>
        /// <param name="perfilId">Identificador del perfil</param>
        /// <returns></returns>
        Task<IEnumerable<PermisoDto>> Asignados(long perfilId);

        /// <summary>
        /// Valida si el usuario tiene el permiso para ejecutar una funcion
        /// </summary>
        /// <param name="perfilId">Identificador del perfil</param>
        /// <param name="pantallaId">Identificador de la pantalla</param>
        /// <param name="funcionId">Identificador de la función</param>
        /// <returns></returns>
        Task<bool> Habilitado(long perfilId, EnumPantalla pantallaId, EnumFuncion funcionId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="form">Formulario</param>
        /// <returns></returns>
        Task<bool> Editar(EditarModulo form);
    }
}
