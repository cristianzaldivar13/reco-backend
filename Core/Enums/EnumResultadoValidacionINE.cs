using System.ComponentModel;

namespace Core.Enums
{
    public enum EnumResultadoValidacionINE
    {
        [Description("Ocurrio algún error")]
        NONE = 0,
        [Description("OK")]
        OK = 1,
        [Description("Error de formato en parámetro INEBase64")]
        FORMATO_IMAGEN_NO_ADMITIDA_INE,
        [Description("Datos del modelo con errores, INE")]
        DATOS_ERRORES_INE,
        [Description("Error de formato en parámetro selfie")]
        FORMATO_IMAGEN_NO_ADMITIDA_SELFIE,
        [Description("Parámetros incompletos, INEBase64 nulo")]
        DATOS_FALTA_INE,
        [Description("Parámetros incompletos, SelfieBase64 nulo")]
        DATOS_FALTA_SELFIE,
        [Description("Sin parámetros que validar")]
        SIN_PARAMETROS,
    }
}
