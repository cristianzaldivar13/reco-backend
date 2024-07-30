using Core.Dtos;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Core.Forms.DataAnnotations
{
    public class ListaRequeridaAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
                return false;

            switch (value)
            {
                case List<long>:
                    List<long> longList = (List<long>)value;
                    return longList.Any();

                case List<string>:
                    List<string> stringList = (List<string>)value;
                    return stringList.Any();

                case List<object>:
                    List<object> objectList = (List<object>)value;
                    return objectList.Any();

                case List<Permiso>:
                    List<Permiso> permisoList = (List<Permiso>)value;
                    return permisoList.Any();

                case List<OpcionDto>:
                    List<OpcionDto> opcionList = (List<OpcionDto>)value;
                    return opcionList.Any();

                case List<IFormFile>:
                    List<IFormFile> fileList = (List<IFormFile>)value;
                    return fileList.Any();

                case IEnumerable<Pantalla>:
                    IEnumerable<Pantalla> pantallaList = (IEnumerable<Pantalla>)value;
                    return pantallaList.Any();

                default:
                    return false;
            }
        }
    }
}
