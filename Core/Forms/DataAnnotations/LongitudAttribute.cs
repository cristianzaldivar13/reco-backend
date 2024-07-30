using System.ComponentModel.DataAnnotations;

namespace Core.Forms.DataAnnotations
{
    public class LongitudAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            value ??= "0";

            if (!decimal.TryParse(value.ToString(), out decimal longitude))
                return false;

            return longitude >= -180 && longitude <= 180;
        }
    }
}
