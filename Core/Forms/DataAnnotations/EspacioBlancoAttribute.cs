using System.ComponentModel.DataAnnotations;

namespace Core.Forms.DataAnnotations
{
    public class EspacioBlancoAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            value ??= string.Empty;

            string strValue = (string)value;

            if (string.IsNullOrWhiteSpace(strValue))
                return true;

            foreach (char character in strValue)
                if (character != ' ')
                    return true;

            return false;
        }
    }
}
