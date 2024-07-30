using Core.Enums;

namespace Core.Interfaces.Motores
{
    public interface IMoBitacora
    {

        /// <summary>
        /// Realiza el registro de log en la bitácora
        /// </summary>
        /// <param name="tipo">Tipo de mensaje a grabar (error, exito, advertencia, informativo)</param>
        /// <param name="clase">Clase donde ocurrio el log</param>
        /// <param name="metodo">Método o función donde se generó el log</param>
        /// <param name="mensaje">Mensaje descriptivo del log</param>
        void Escribir(EnumLog tipo, string clase, string metodo, string mensaje);
    }
}
