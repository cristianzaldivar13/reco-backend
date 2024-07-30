using Core.Enums;
using Core.Vistas;

namespace Core.Clases
{
    public class ClsRespuesta<T>
    {
        public EnumCodigoRespuesta Codigo { get; set; }
        public string Mensaje { get; set; }
        public T? Informacion { get; set; }

        public ClsRespuesta()
        {
            Codigo = EnumCodigoRespuesta.Desconocido;
            Mensaje = string.Empty;
        }

        /// <summary>
        /// Funcion para cuando el token jwt es invalido
        /// </summary>
        /// <returns></returns>
        public ClsRespuesta<T> SesionInvalida()
        {
            Codigo = EnumCodigoRespuesta.SesionInvalida;
            Mensaje = CFG.Diccionario.TokenInvalido;

            return this;
        }

        /// <summary>
        /// Funcion para cuando no se tiene el contexto de base de datos creado
        /// </summary>
        /// <returns></returns>
        public ClsRespuesta<T> AccesoDatabaseDenegado()
        {
            Codigo = EnumCodigoRespuesta.AccesoDatabaseDenegado;
            Mensaje = CFG.Diccionario.AccesoDatabaseDenegado;

            return this;
        }

        /// <summary>
        /// Funcion para cuando no se tienen los permisos necesarios
        /// </summary>
        /// <returns></returns>
        public ClsRespuesta<T> FuncionNoPermitida()
        {
            Codigo = EnumCodigoRespuesta.FuncionNoPermitida;
            Mensaje = CFG.Diccionario.FuncionNoPermitida;

            return this;
        }

        /// <summary>
        /// Funcion para resultados exitosos
        /// </summary>
        /// <param name="informacion"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public ClsRespuesta<T> Correcta(T informacion, string mensaje)
        {
            Codigo = EnumCodigoRespuesta.ProcesoCorrecto;
            Mensaje = mensaje;
            Informacion = informacion;

            return this;
        }

        /// <summary>
        /// Funcion para resultados de consultas con filtros sin información
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public ClsRespuesta<T> Vacia()
        {
            Codigo = EnumCodigoRespuesta.ConsultaVacia;
            Mensaje = CFG.Diccionario.FuncionConsultaVacia;

            return this;
        }

        /// <summary>
        /// Funcion para resultados no exitosos
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public ClsRespuesta<T> Incorrecta(EnumCodigoRespuesta codigoRespuesta = EnumCodigoRespuesta.ProcesoIncorrecto, string mensaje = "")
        {
            Codigo = codigoRespuesta;
            Mensaje = string.IsNullOrWhiteSpace(mensaje) ? CFG.Diccionario.Identerminado : mensaje;

            return this;
        }

        /// <summary>
        /// Funcion especifica para excepciones
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public ClsRespuesta<T> Excepcion(string mensaje)
        {
            Codigo = EnumCodigoRespuesta.Exception;
            Mensaje = mensaje;

            return this;
        }
    }
}
