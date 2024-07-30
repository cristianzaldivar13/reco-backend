using Core.Enums;
using System.Net.Mail;

namespace Core.Interfaces.Motores
{
    public interface IMoEmail
    {
        /// <summary>
        /// Proceso para enviar un correo electronico
        /// </summary>
        /// <param name="tipo">Indica que tipo de correo será el enviado</param>
        /// <param name="para">Indica a que correo o correos se realizará el envío</param>
        /// <param name="asunto">Indica el asunto del correo</param>
        /// <returns></returns>
        Task<bool> Enviar(EnumCorreo tipo, string para, string asunto, MailPriority prioridad = MailPriority.Normal, params object[] parametros);
    }
}
