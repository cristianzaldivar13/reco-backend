using Core.Vistas;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Core.Interfaces.Motores
{
    public interface IMoTokenJwt
    {
        /// <summary>
        /// Generá un nuevo token Jwt a partir de la sesión actual.
        /// </summary>
        /// <param name="tiempoDeSesion">Determina el tiempo de expiración, en minutos, del nuevo token (mínimo 10 minutos)</param>
        /// <returns></returns>
        string Codificar(double tiempoDeSesion);

        /// <summary>
        /// Obtiene la configuración de la sesión establecida en el token Jwt
        /// </summary>
        /// <param name="httpContext">Contexto de la petición Http</param>
        /// <returns></returns>
        List<Claim> Decodificar(HttpContext httpContext);

        /// <summary>
        /// Determina si la sesión que realizó la solicitud es válida.
        /// </summary>
        /// <param name="httpContext">Contexto de la petición Http</param>
        /// <returns></returns>
        ViSesion? ValidarSesion(HttpContext httpContext);

        /// <summary>
        /// Obtiene la estructura del token Jwt
        /// </summary>
        /// <param name="httpContext">Contexto de la petición Http</param>
        /// <returns></returns>
        JwtSecurityToken? Consultar(HttpContext httpContext);
    }
}
