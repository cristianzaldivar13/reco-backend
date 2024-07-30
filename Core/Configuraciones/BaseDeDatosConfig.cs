using Core.Dtos;

namespace Core.Configuraciones
{
    public class BaseDeDatosConfig
    {
        public int ConexionTimeOut { get; set; }
        public int EjecucionTimeOut { get; set; }
        public BaseDeDatosDto Recompensas { get; set; }
        public BaseDeDatosConfig() { 
            Recompensas = new BaseDeDatosDto();
        }
    }
}
