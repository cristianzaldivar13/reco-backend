using System.ComponentModel.DataAnnotations;

namespace Core.Forms.DataAnnotations
{
    public class CaracterEspecialAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            value ??= string.Empty;

            string strValue = (string)value;

            if (string.IsNullOrWhiteSpace(strValue))
                return true;

            foreach (char character in strValue)
                if (!CFG.CaracterConfig.Union.Contains(character))
                    return false;

            return true;
        }
    }
}
