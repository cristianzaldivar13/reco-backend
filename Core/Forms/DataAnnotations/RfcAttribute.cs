using System.ComponentModel.DataAnnotations;

namespace Core.Forms.DataAnnotations
{
    public class RfcAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            value ??= string.Empty;

            string strValue = (string)value;

            if (string.IsNullOrWhiteSpace(strValue))
                return true;

            if (strValue.Length < 12 || strValue.Length > 13)
                return false;

            int lngSeccionUno = strValue.Length == 13 ? 4 : 3;

            string seccion = strValue[..lngSeccionUno];
            if (!CFG.IHerramienta.EsTexto(seccion))
                return false;

            seccion = strValue.Substring(lngSeccionUno, 6);
            if (!CFG.IHerramienta.EsNumero(seccion))
                return false;

            seccion = strValue.Substring(lngSeccionUno + 6, 3);
            if (seccion.Length != 3)
                return false;

            return true;
        }
    }
}
