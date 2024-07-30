using Core.Dtos;
using Core.Enums;
using Core.Forms;
using Core.Vistas;

namespace Core.Interfaces.UnidadDeTrabajo
{
    public interface IUsuario
    {
        /// <summary>
        /// Lista de registros con paginación de usuarios delimitada por empresa
        /// </summary>
        /// <param name="paginacion">Caracteristicas de la consulta</param>
        /// <returns></returns>
        Task<GridDto<ViUsuario>> Consulta(PaginarDto paginacion);

        /// <summary>
        /// Registro de usuario delimitado por empresa
        /// </summary>
        /// <param name="usuarioId">Identificador del usuario</param>
        /// <returns></returns>
        Task<ViUsuarioDetalle> Detalle(long usuarioId);

        /// <summary>
        /// Creación de un registro de usuario delimitado por empresa
        /// </summary>
        /// <param name="form">Formulario</param>
        /// <returns></returns>
        Task<long> Crear(CrearUsuario form);

        /// <summary>
        /// Edición de un registro de usuario delimitado por empresa
        /// </summary>
        /// <param name="usuarioId">Identificador del usuario</param>
        /// <param name="form">Formulario</param>
        /// <returns></returns>
        Task<bool> Editar(long usuarioId, EditarUsuario form);

        /// <summary>
        /// Cambio de estatus de un registro de usuario delimitado por empresa
        /// </summary>
        /// <param name="usuarioId">Identificador del usuario</param>
        /// <param name="estatus">Nuevo estatus (activo o inactivo)</param>
        /// <returns></returns>
        Task<bool> CambiarEstatus(long usuarioId, int estatus);

        /// <summary>
        /// Eliminación de un registro de usuario delimitado por empresa
        /// </summary>
        /// <param name="usuarioId">Identificador del usuario</param>
        /// <returns></returns>
        Task<bool> Eliminar(long usuarioId);

        /// <summary>
        /// Lista de registros sin paginación de usuarios delimitada por empresa
        /// </summary>
        /// <param name="paginacion">Caracteristicas de la consulta</param>
        /// <returns></returns>
        Task<IEnumerable<ViUsuario>> Exportar(PaginarDto paginacion);


        /// <summary>
        /// Realiza el desbloqueo de un usuario delimitiado por empresa
        /// </summary>
        /// <param name="usuarioId">Identificador del usuario</param>
        /// <returns></returns>
        Task<bool> Desbloquear(long usuarioId);

        /// <summary>
        /// Registro con la información personal del usuario delimitado por empresa
        /// </summary>
        /// <param name="usuarioId">Identificador del usuario</param>
        /// <returns></returns>
        Task<ViUsuarioPerfil> Perfil(long usuarioId);

        /// <summary>
        /// Actualiza la contraseña del usuario ya sea por recuperar, cambiar o restablecerla
        /// </summary>
        /// <param name="usuarioId">Identificador del usuario</param>
        /// <param name="password">Nueva contraseña</param>
        /// <returns></returns>
        Task<bool> ActualizarPassword(long usuarioId, string password, bool activar);


        /// <summary>
        /// Valida la existencia de un registro de usuario delimitado por empresa
        /// </summary>
        /// <param name="usuarioId">Identificador del usuario</param>
        /// <returns></returns>
        Task<bool> Existe(long usuarioId);

        /// <summary>
        /// Valida si el username capturado esta siendo utilizado por un usuario delimitado por empresa
        /// </summary>
        /// <param name="username">Nombre de usuario</param>
        /// <returns></returns>
        Task<bool> UsernameUtilizado(string username);

        /// <summary>
        /// Valida si el correo electrónico capturado esta siendo utilizado por un usuario delimitado por empresa
        /// </summary>
        /// <param name="email">Correo electrónico</param>
        /// <param name="usuarioId">Identificador del usuario</param>
        /// <returns></returns>
        Task<bool> EmailUtilizado(string email, long usuarioId);

        /// <summary>
        /// Registro de usuario localizado por email delimitado por alias de empresa
        /// </summary>
        /// <param name="alias">Alias de la empresa</param>
        /// <param name="email">Correo electrónico</param>
        /// <returns></returns>
        Task<ViUsuario> Consulta(string email);

        /// <summary>
        /// Actualiza el nombre de la imagen para el usuario
        /// </summary>
        /// <param name="usuarioId">Identificador del usuario</param>
        /// <param name="nombre">Nombre de la imagen con extensión</param>
        /// <returns></returns>
        Task<bool> ActualizarImagen(long usuarioId, string nombre);

        /// <summary>
        /// Lista de registros de usuarios delimitada por empresa, para llenar combobox
        /// </summary>
        /// <param name="usuarioId">Identificador del usuario</param>        
        /// <returns></returns>
        Task<IEnumerable<OpcionDto>> Opciones(long usuarioId);

        /// <summary>
        /// Lista de registros de usuarios delimitada por empresa, para llenar combobox
        /// </summary>
        /// <param name="tipoUsuario">Identificador del tipo de usuario</param> 
        /// <returns></returns>
        Task<IEnumerable<OpcionDto>> Opciones(EnumUsuario[] tipoUsuario);
    }
}
