using System.ComponentModel;

namespace Core.Enums
{
    public enum EnumResultadoCode
    {
        [Description("Sin parámetros que validar sin datos del INE ni CURP")]
        NONE = 0,
        [Description("OK")]
        OK = 1,
        [Description("El nombre, apellido paterno y apellido materno obtenidos por medio del OCR del imagen del anverso no coinciden con los que fueron recibidos en los parámetros de entrada.")]
        NOMBRES_NO_COINCIDEN = 2,
        [Description("Parámetros incompletos, Base64Anverso nulo.")]
        URL_ANVERSO_OBLIGATORIO = 4,
        [Description("Parámetros incompletos, Base64Reverso nulo.")]
        URL_REVERSO_OBLIGATORIO = 5,
        [Description("El documento presentado, no es una identificaciòn vàlida.")]
        IDENTIFICACION_NO_VALIDA = 6,
        [Description("No concuerda el reverso con el anverso del documento presentado.")]
        DOCUMENTO_NO_VALIDO = 8,
        [Description("No se pudo extraer la información de la identificación (Reverso), favor de verificar que sea una identificación válida.")]
        EXTRACCION_DATOS_INCORRECTA = 7,
        [Description("La identificación trasera presentada no corresponde a la identificación delantera.")]
        IDENTIFICACION_NO_COINCIDE = 9,
        [Description("El CURP identificado no es legible o es inválido.")]
        CURP_NO_VALIDA = 10,
        [Description("Error de formato en parámetro Base64Anverso.")]
        FORMAT_INVALIDO,
        [Description("Sin parámetros que validar.")]
        MODELO_NO_VALIDO,
        [Description("El Token ha expirado/inválido")]
        TOKEN_EXPIRADO,
        [Description(" Error de formato en parámetro Base64Anverso.")]
        MODELO_NO_VALIDO_ANVERSO,
        [Description(" Error de formato en parámetro Base64Reverso.")]
        MODELO_NO_VALIDO_REVERSO,
        [Description("Similitud no válida")]
        SIMILITUD_NO_VALIDA,
    }
}
