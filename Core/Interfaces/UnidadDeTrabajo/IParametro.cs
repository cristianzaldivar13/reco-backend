using Core.Dtos;
using Core.Enums;
using Core.Forms;
using Core.Vistas;

namespace Core.Interfaces.UnidadDeTrabajo
{
    public interface IParametro
    {
        /// <summary>
        /// Detalle de un registro de parámetro
        /// </summary>
        /// <param name="parametroId">Identificador del parametro</param>
        /// <returns></returns>
        Task<ViParametroDetalle> Detalle(string parametroId);

        /// <summary>
        /// Edición de un registro de parámetro
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        Task<bool> Editar(EditarParametro form);

        /// <summary>
        /// Obtiene el valor de un parámetro
        /// </summary>
        /// <param name="parametroId"></param>
        /// <returns></returns>
        Task<string> Valor(EnumParametro parametroId);

        /// <summary>
        /// Obtiene la configuración de los parámetros de contraseña
        /// </summary>
        /// <returns></returns>
        Task<PasswordDto> Password();

        /// <summary>
        /// Lista de registros de parámetros
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ViParametro>> Lista();
    }
}
