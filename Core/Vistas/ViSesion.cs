using Core.Enums;
using System.Security.Claims;

namespace Core.Vistas
{
    public class ViSesion
    {
        public string Id { get; set; }

        public string Nombre { get; set; }
        public string Clave_de_Acceso { get; set; }

        public EnumEstatus Activo { get; set; }
        public string idGrupoUsuarios { get; set; }

        public string Resultado { get; set; }

        public ViSesion()
        {
            Id = string.Empty;
            Nombre = string.Empty;
            Clave_de_Acceso = string.Empty;
            Activo = EnumEstatus.Inactivo;
            idGrupoUsuarios = string.Empty;
            Resultado = string.Empty;
        }

        public void Inicializar(List<Claim> claims)
        {
            foreach (Claim claim in claims)
            {
                switch (claim.Type)
                {
                    case nameof(Id):
                        if (string.IsNullOrWhiteSpace(claim.Value))
                            Id = string.Empty;

                        Id = claim.Value ?? string.Empty;
                        break;
                    case nameof(Activo):
                        if (string.IsNullOrWhiteSpace(claim.Value))
                            Activo = EnumEstatus.Activo;

                        Activo = (EnumEstatus)Enum.Parse(typeof(EnumEstatus), claim.Value ?? EnumEstatus.Inactivo.ToString());
                        break;
                    case nameof(Nombre):
                        if (string.IsNullOrWhiteSpace(claim.Value))
                            Nombre = string.Empty;

                        Nombre = claim.Value ?? string.Empty;
                        break;
                }
            }
        }
    }
}
