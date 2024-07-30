using System.ComponentModel.DataAnnotations;

namespace Core.Forms.DataAnnotations
{
    public class NumeroRequerido : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            value ??= string.Empty;

            string? strValue = value.ToString();

            switch (value.GetType().Name)
            {
                case "Decimal":
                    if (!decimal.TryParse(strValue, out decimal decimalNum))
                        return false;

                    return decimalNum > 0;
                case "Long":
                case "Int64":
                    if (!long.TryParse(strValue, out long longNum))
                        return false;

                    return longNum > 0;
                case "Int":
                case "Int32":
                    if (!int.TryParse(strValue, out int intNum))
                        return false;

                    return intNum > 0;
                default:
                    return false;
            }
        }
    }
}
