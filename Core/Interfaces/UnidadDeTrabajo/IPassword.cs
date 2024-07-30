namespace Core.Interfaces.UnidadDeTrabajo
{
    public interface IPassword
    {
        /// <summary>
        /// Creación o edición de las contraseñas históricas y usuario
        /// </summary>
        /// <param name="usuarioId">Identificador del usuario</param>
        /// <param name="password">Contraseña</param>
        /// <returns></returns>
        Task<bool> Actualizar(long usuarioId, string password);

        /// <summary>
        /// Válida la existencia de una contraseña y usuario
        /// </summary>
        /// <param name="usuarioId">Identificador del usuario</param>
        /// <param name="password">Contraseña</param>
        /// <returns></returns>
        Task<bool> Existe(long usuarioId, string password);
    }
}
