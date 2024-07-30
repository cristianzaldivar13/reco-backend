using Core.Clases;
using Core.Configuraciones;
using Core.Dtos;
using Core.Interfaces.Motores;
using Core.Vistas;

namespace Core
{
    /// <summary>
    /// Clase que contiene las propiedades de configuración del sistema, que se cargan al iniciar el proyecto o cada que se realiza una petición
    /// </summary>
    public static class CFG
    {
        /// <summary>
        /// Valores de la sesión actual.
        /// </summary>
        public static ViSesion? Sesion { get; set; } = null;

        /// <summary>
        /// Datos para la configuración de rutas servidor.
        /// </summary>
        public static ServidorConfig ServidorConfig { get; set; } = new ServidorConfig();

        /// <summary>
        /// Datos para la configuración del token Jwt.
        /// </summary>
        public static TokenJwtConfig TokenJwtConfig { get; set; } = new TokenJwtConfig();

        /// <summary>
        /// Datos para la configuración del rutas para archivos.
        /// </summary>
        public static ArchivoConfig ArchivoConfig { get; set; } = new ArchivoConfig();

        /// <summary>
        /// Datos para la configuración para la bitácora.
        /// </summary>
        public static LogConfig LogConfig { get; set; } = new LogConfig();

        /// <summary>
        /// Datos para la configuración de caracteres permitidos en el sistema.
        /// </summary>
        public static CaracterConfig CaracterConfig { get; set; } = new CaracterConfig();
        /// <summary>
        /// Datos para la configuración de base de datos.
        /// </summary>
        public static BaseDeDatosConfig BaseDeDatosConfig { get; set; } = new BaseDeDatosConfig();

        /// <summary>
        /// Datos de configuracion Recompensas
        /// </summary>
        public static RecompensasConfig RecompensasConfig { get; set; } = new RecompensasConfig();

        /// <summary>
        /// Datos para la configuración de envío de correo electrónico.
        /// </summary>
        public static EmailConfig EmailConfig { get; set; } = new EmailConfig();

        /// <summary>
        /// Datos para la configuración de envío de SMS
        /// </summary>
        public static SmsConfig SmsConfig { get; set; } = new SmsConfig();

        /// <summary>
        /// Datos para la configuración de versiones del sistema.
        /// </summary>
        public static IEnumerable<VersionConfig> Versiones { get; set; } = new List<VersionConfig>();

        /// <summary>
        /// Datos para la configuración de origines de solicitud de peticiones.
        /// </summary>
        public static string[] Origenes { get; set; } = { "" };

        /// <summary>
        /// Datos para la configuración de lectura de textos.
        /// </summary>
        public static ClsDiccionario Diccionario { get; set; } = new ClsDiccionario();

        /// <summary>
        /// Datos para la configuración de lectura de la última versión del sistema.
        /// </summary>
        public static VersionConfig VersionActual
        {
            get
            {
                if (Versiones == null)
                    return new VersionConfig();

                if (!Versiones.Any())
                    return new VersionConfig();

                return Versiones.Last();
            }
        }

#pragma warning disable CS8618 // Las asignaciones de estas propiedades se realizan en Program.cs
        public static IMoBitacora ILog { get; set; }
        public static IMoArchivo IArchivo { get; set; }
        public static IMoEmail IEmail { get; set; }
        public static IMoFecha IFecha { get; set; }
        public static IMoHerramienta IHerramienta { get; set; }
        public static IMoPassword IPassword { get; set; }
        public static IMoTokenJwt ITokenJwt { get; set; }
        public static IMoGoogle IGoogle { get; set; }
        public static IMoApiLuxand IApiLuxand { get; set; }
        public static IMoSms ISms {  get; set; }
#pragma warning restore CS8618 // Las asignaciones de estas propiedades se realizan en Program.cs
    }
}
