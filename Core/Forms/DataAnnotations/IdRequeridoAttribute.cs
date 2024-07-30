using System.ComponentModel.DataAnnotations;

namespace Core.Forms.DataAnnotations
{
    public class IdRequeridoAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            value ??= "0";

            if (!long.TryParse(value.ToString(), out long id))
                return false;

            return id > 0;
        }
    }
}
