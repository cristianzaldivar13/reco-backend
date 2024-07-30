using Core.Dtos;
using Core.Enums;

namespace Core.Interfaces.Motores
{
    public interface IMoPassword
    {
        /// <summary>
        /// Genera una contraseña a partir de los parámetros de configuración de un cliente
        /// </summary>
        /// <param name="configuracion">Valores de los parámetros de configuración de contraseña</param>
        /// <returns></returns>
        string Generar(PasswordDto configuracion);

        /// <summary>
        /// Determina si una contraseña tiene una estructura válida de acuerdo con los parámetros de configuración de un cliente
        /// </summary>
        /// <param name="password">Constraseñ a evaluar</param>
        /// <param name="configuracion">Valores de los parámetros de configuración de contraseña</param>
        /// <returns></returns>
        bool EsValido(string password, PasswordDto configuracion);

        /// <summary>
        /// Determina si el parámetro configuración corresponde a uno de contraseña
        /// </summary>
        /// <param name="parametroId">Nombre del parámetro de configuración</param>
        /// <returns></returns>
        bool AplicaParametro(EnumParametro parametroId);

        /// <summary>
        /// Determina si el valor establecido para un parámetro de contrase es válido de acuerdo con los parámetros de configuración de un cliente
        /// </summary>
        /// <param name="parametroId">Nombre del parámetro de configuración</param>
        /// <param name="valor">Valor del parámetro de configuración</param>
        /// <param name="configuracion">Valores de los parámetros de configuración de contraseña</param>
        /// <returns></returns>
        public bool EsValorValido(EnumParametro parametroId, string valor, PasswordDto configuracion);
    }
}
