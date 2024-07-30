using System.ComponentModel.DataAnnotations;

namespace Core.Forms.DataAnnotations
{
    public class LatitudAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            value ??= "0";

            if (!decimal.TryParse(value.ToString(), out var latitude))
                return false;

            return latitude >= -90 && latitude <= 90;
        }
    }
}
