using System.ComponentModel.DataAnnotations;

namespace Core.Forms.DataAnnotations
{
    public class DineroAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            value ??= string.Empty;

            string? strValue = value.ToString();

            if (!decimal.TryParse(strValue, out decimal amount))
                return false;

            string number = amount.ToString();

            int indexDot = number.IndexOf('.');

            if (indexDot == -1)
                return amount > 0;

            string decimals = number[(indexDot + 1)..];

            return amount > 0 && decimals.Length <= 2;
        }
    }
}
