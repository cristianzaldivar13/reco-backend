using Core.Annotations.Modelos;
using Core.Enums;
using Core.Vistas;
using Microsoft.AspNetCore.Http;
using System.Drawing;

namespace Core.Interfaces.Motores
{
    public interface IMoHerramienta
    {
        /// <summary>
        /// Transforma un texto al formato camelCase; "TextO TransFormado" regresará "textoTransformado"
        /// </summary>
        /// <param name="palabra">Texto a transformar</param>
        /// <returns></returns>
        string CamelCase(string palabra);

        /// <summary>
        /// Transforma un texto al formato PascalCase; "TextO TransFormado" regresará "TextoTransformado"
        /// </summary>
        /// <param name="palabra">Texto a transformar</param>
        /// <returns></returns>
        string PascalCase(string palabra);

        /// <summary>
        /// Genera un identificador con la estructura Guid, ya sea de 13 caracteres (corto) o predeterminado
        /// </summary>
        /// <param name="largo">Indica si el identificador será predeterminado (true) o de longitud corta (false)</param>
        /// <returns></returns>
        string GenerarIdentificador(bool largo = true);

        /// <summary>
        /// Obtiene una cadena de un número aleatorio entre 1 y 999999 a seis dígitos.
        /// </summary>
        /// <returns></returns>
        string NumeroAleatorio();

        /// <summary>
        /// Obtiene el mensaje de error correspondiente como resultado del proceso de inicio de sesión
        /// </summary>
        /// <param name="mensaje">Mensaje obtenido de la ejecución del stored procedure de inicio de sesión</param>
        /// <returns></returns>
        string MensajeDeInicioDeSesion(string mensaje);

        /// <summary>
        /// Realiza el intercambio de estaus de activo => inactivo o viceversa
        /// </summary>
        /// <param name="estatus">Enum de tipo de estatus actual a cambiar</param>
        /// <returns></returns>
        int IntercambiarEstatus(EnumEstatus estatus);

        /// <summary>
        /// Asigna un nombre al archivo a cargar al servidor
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        string NombrarArchivo(EnumTipoArchivo nombreArchivo, params long[] parametros);

        /// <summary>
        /// Determina si será posible realizar la eliminación de un registro dependiente del tipo de eliminación.
        /// </summary>
        /// <param name="validarEstatus">Determina si se validará el estatus del registro antes de eliminar (el registro debe estar inactivo)</param>
        /// <param name="estatus">Enum de tipo de estatus actual del registro</param>
        /// <returns></returns>
        bool PermitirEliminacion(bool validarEstatus, EnumEstatus estatus);

        /// <summary>
        /// Convierte el valor de un parámetro binario a booleano
        /// </summary>
        /// <param name="valor">Valor del parámetro</param>
        /// <returns></returns>
        bool ValorParametroABool(string valor);

        /// <summary>
        /// Determina si el organigrama de un puesto es válido
        /// </summary>
        /// <param name="nivel1">Nivel uno</param>
        /// <param name="nivel2">Nivel dos</param>
        /// <param name="nivel3">Nivel tres</param>
        /// <param name="nivel4">Nivel cuatro</param>
        /// <param name="nivel5">Nivel cinco</param>
        /// <returns></returns>
        bool OrganigramaValido(int nivel1, int nivel2, int nivel3, int nivel4, int nivel5);

        /// <summary>
        /// Determina si una cadena esta constituida por texto
        /// </summary>
        /// <param name="cadena">cadena a evaluar</param>
        /// <returns></returns>
        bool EsTexto(string cadena);

        /// <summary>
        /// Determina si una cadena esta constituida por números
        /// </summary>
        /// <param name="cadena">cadena a evaluar</param>
        /// <returns></returns>
        bool EsNumero(string cadena);

        /// <summary>
        /// Obtiene la ubicación de la celda de excel en una carga masiva, basado en entidad, la columna y fila;
        /// </summary>
        /// <param name="entidad">Entidad correspondiente a la carga masiva</param>
        /// <param name="key">Propiedad a evaluar</param>
        /// <param name="fila">Número de fila del archivo</param>
        /// <returns></returns>
        string ObtenerCelda(string entidad, string key, out int fila);

        /// <summary>
        /// Obtiene un link para restablecer la contraseña, que será enviado mediante correo electrónico.
        /// </summary>
        /// <param name="empresaId">Identificador del cliente</param>
        /// <param name="usuarioId">Identificador del usuario</param>
        /// <param name="identificador">Identificador del registro que restablecimiento de password para control de tiempo de validez del link</param>
        /// <returns></returns>
        string Link(long empresaId, long usuarioId, string identificador);

        /// <summary>
        /// Encriptación de cadenas
        /// </summary>
        /// <param name="cadena">Cadena a encriptar</param>
        /// <returns></returns>
        string EncriptarCadena(string cadena);

        /// <summary>
        /// Desencriptación de cadenas
        /// </summary>
        /// <param name="cadena">Cadena a desencriptar</param>
        /// <returns></returns>
        string DesencriptarCadena(string cadena);

        /// <summary>
        /// Convierte un archivo a base 64
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        string ConvierteABase64(IFormFile file);

        string ObtenerExtensionDeVideo(string base64String);

        string ObtenerExtensionDeImagen(string base64String);

        string ObtenerExtensionDeArchivo(IFormFile file);

        string ObtenerExtensionDeArchivoPorNombre(string fileName);

        void GuardarArchivo(string pathTemp, string nameFile, string base64Content);

        void GuardarArchivos(string pathTemp, IFormFile imageFile, IFormFile videoFile);

        string RandomString(int length);

        bool GenerarImagenDeVideo(string inputArchivo, string nombreArchivo, string urlFFmpeg);

        double BuscarSimilitud(string textoCompare, string textCompare);

        string LeerArchivo(string path);

        string ObtenerTipoIne(RespuestaGoogle respuestaGoogleAnverso);

        string Filtro(string v);

        Rectangle ObtenerPuntosImagen(string responseGoogle);

        string ObtenerIneFoto(string imageUrl, Rectangle rectangleToCrop);
    }
}
