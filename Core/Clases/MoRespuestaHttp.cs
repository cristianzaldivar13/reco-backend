using Core.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Core.Clases
{
    public class MoRespuestaHttp(HttpResponse httpResponse)
    {
        private readonly HttpResponse httpResponse = httpResponse;

        /// <summary>
        /// Generá una respuesta Http con el código 200
        /// </summary>
        /// <param name="respuesta">Objeto que contiene los datos a enviar como respuesta en el body de la petición</param>
        /// <param name="token">Token JWT actualizado</param>
        /// <returns></returns>
        public ObjectResult Correcta<T>(ClsRespuesta<T> respuesta, string token)
        {
            EstablecerHttpStatusCode(HttpStatusCode.OK, token);

            return new ObjectResult(respuesta);
        }

        /// <summary>
        /// Generá una respuesta Http con el código 400
        /// </summary>
        /// <param name="error">Mensaje de error</param>
        /// <returns></returns>
        public ObjectResult Incorrecta(string error)
        {
            EstablecerHttpStatusCode(HttpStatusCode.BadRequest);

            ClsRespuesta<string> respuesta = new();

            return new ObjectResult(respuesta.Incorrecta(EnumCodigoRespuesta.ModeloIncorrecto, error));
        }

        /// <summary>
        /// Generá una respuesta Http con el código 401 indicando que la sesión es inválida
        /// </summary>
        /// <returns></returns>
        public ObjectResult SesionInvalida()
        {
            EstablecerHttpStatusCode(HttpStatusCode.Unauthorized);

            ClsRespuesta<string> respuesta = new();

            return new ObjectResult(respuesta.SesionInvalida());
        }

        /// <summary>
        /// Generá una respuesta Http con los códigos 404, 406 o 409 dependiendo del error generado.
        /// </summary>
        /// <param name="tipo">Tipo de excepción</param>
        /// <param name="mensage">Mensaje de error de excepción</param>
        /// <returns></returns>
        public ObjectResult Excepcion(string tipo, string mensage)
        {
            var httpStatusCode = tipo switch
            {
                "NullReferenceException" => HttpStatusCode.NotFound,
                "ArgumentNullException" => HttpStatusCode.NotAcceptable,
                "SqlNullException" => HttpStatusCode.NotAcceptable,
                _ => HttpStatusCode.Conflict,
            };

            EstablecerHttpStatusCode(httpStatusCode);

            ClsRespuesta<string> respuesta = new();

            return new ObjectResult(respuesta.Excepcion(mensage));
        }

        /// <summary>
        /// Estable el estatus de la respuesta Http así como el token jwt actualizado.
        /// </summary>
        /// <param name="statusCode">Valor del código de estatus determinado para la respuesta Http</param>
        /// <param name="token">Token JWT actualizado</param>
        private void EstablecerHttpStatusCode(HttpStatusCode statusCode, string token = "")
        {
            httpResponse.StatusCode = (int)statusCode;
            httpResponse.Headers.Add("token-jwt", token);
        }
    }
}
