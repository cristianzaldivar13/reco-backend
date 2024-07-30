using Core.Dtos;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Core.Interfaces.Motores
{
    public interface IMoCargaMasiva<T> where T : class
    {
        /// <summary>
        /// Indica si al validar la información del archivo cargado hay errores de datos.
        /// </summary>
        bool HayErrores { get; }

        /// <summary>
        /// Devuelve la lista de registros que ha pasado las validaciónes correspondientes.
        /// </summary>
        IEnumerable<T> Informacion { get; }

        /// <summary>
        /// Establece y devuelve la lista de registros con errores indicando la celda y el mensaje de error correspondiente
        /// </summary>
        IEnumerable<CargaMasivaDto> Errores { get; set; }


        /// <summary>
        /// Ejecuta el proceso de validación de la información para establecer la información corrrecta y los errores que se hayan presentado en el módelo
        /// </summary>
        /// <param name="modelState"></param>
        void ValidarInformacion(ModelStateDictionary modelState);
    }
}
