using Core.Enums;
using Microsoft.AspNetCore.Http;

namespace Core.Interfaces.Motores
{
    public interface IMoArchivo
    {
        /// <summary>
        /// Ruta predeterminada donde se ubicarán todos los archivos generales como correos, logs, etc.
        /// </summary>
        string RutaGeneral { get; }

        /// <summary>
        /// Obtiene la ruta completa de la carpeta o folder indicado
        /// </summary>
        /// <param name="carpeta">Nombre de la carpeta</param>
        /// <returns></returns>
        string RutaCarpeta(EnumCarpeta carpeta);

        /// <summary>
        /// Obtiene la ruta externa del archivo indicado
        /// </summary>
        /// <param name="carpeta">Nombre de la carpeta en donde se encuentra el archivo</param>
        /// <param name="nombreArchivo">Nombre del archivo</param>
        /// <returns></returns>
        string RutaExterna(EnumCarpeta carpeta, string nombreArchivo);

        /// <summary>
        /// Obtiene la ruta interna del archivo indicado
        /// </summary>
        /// <param name="carpeta">Nombre de la carpeta en donde se encuentra el archivo</param>
        /// <param name="nombreArchivo">Nombre del archivo</param>
        /// <returns></returns>
        string RutaInterna(EnumCarpeta carpeta, string nombreArchivo);

        /// <summary>
        /// Crea un archivo de texto en la carpeta indicada
        /// </summary>
        /// <param name="carpeta">Nombre de la carpeta en donde se encuentra el archivo</param>
        /// <param name="nombreArchivo">Nombre del archivo con extensión.</param>
        void Crear(EnumCarpeta carpeta, string nombreArchivo);

        /// <summary>
        /// Carga un archivo en la carpeta indicada
        /// </summary>
        /// <param name="archivo">Archivo a cargar</param>   
        /// <param name="carpeta">Nombre de la carpeta en donde se encuentra el archivo</param>
        /// <param name="nombreArchivo">Nombre del archivo con extensión.</param>
        EnumCodigoRespuestaArchivo Cargar(IFormFile archivo, EnumCarpeta carpeta, ref string nombreArchivo);

        /// <summary>
        /// Agrega una linea de texto al archivo de bitacora (cuando el log en el visor de eventos no existe)
        /// </summary>
        /// <param name="texto"></param>
        void EscribirLog(string texto);

        /// <summary>
        /// Obtiene el contenido del archivo indicado
        /// </summary>
        /// <param name="carpeta">Nombre de la carpeta en donde se encuentra el archivo</param>
        /// <param name="nombreArchivo">Nombre del archivo</param>
        /// <returns></returns>
        string LeerContenido(EnumCarpeta carpeta, string nombreArchivo);

        /// <summary>
        /// Determina si el Content Type del archivo esta permitido
        /// </summary>
        /// <param name="contentType">Content Type del archivo</param>
        /// <returns></returns>
        bool ContentTypePermitido(string contentType);

        /// <summary>
        /// Determina si la extensión del archivo esta permitida.
        /// </summary>
        /// <param name="nombreArchivo">Nombre del archivo</param>
        /// <returns></returns>
        bool ExtensionPermitida(string nombreArchivo);

        /// <summary>
        /// Lee archivos csv
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rutaArchivo"></param>
        /// <returns></returns>
        IEnumerable<T> LeerCsv<T>(string rutaArchivo) where T : new();
    }
}
