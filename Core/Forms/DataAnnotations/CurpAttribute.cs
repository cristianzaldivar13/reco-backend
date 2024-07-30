using System.ComponentModel.DataAnnotations;

namespace Core.Forms.DataAnnotations
{
    public class CurpAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            value ??= string.Empty;

            string strValue = (string)value;

            if (string.IsNullOrWhiteSpace(strValue))
                return true;

            if (strValue.Length != 18)
                return false;

            string seccion = strValue[..4];
            if (!CFG.IHerramienta.EsTexto(seccion))
                return false;


            seccion = strValue.Substring(4, 6);
            if (!CFG.IHerramienta.EsNumero(seccion))
                return false;

            seccion = strValue.Substring(10, 6);
            if (!CFG.IHerramienta.EsTexto(seccion))
                return false;

            seccion = strValue.Substring(16, 2);
            if (!CFG.IHerramienta.EsNumero(seccion))
                return false;

            return true;
        }
    }
}
