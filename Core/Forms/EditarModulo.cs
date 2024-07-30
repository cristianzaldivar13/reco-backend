using Core.Forms.DataAnnotations;
using Core.Forms.Resource;
using Newtonsoft.Json;

namespace Core.Forms
{
    public class EditarModulo
    {
        [ListaRequerida(ErrorMessageResourceType = typeof(Error), ErrorMessageResourceName = nameof(Error.PermisosRequeridos))]
        public IEnumerable<Pantalla> Pantallas { get; set; }

        public string PantallasJson
        {
            get
            {
                if (!Pantallas.Any())
                    return "[]";

                return JsonConvert.SerializeObject(Pantallas).ToLower();
            }
        }

        public EditarModulo()
        {
            Pantallas = new List<Pantalla>();
        }
    }
}
