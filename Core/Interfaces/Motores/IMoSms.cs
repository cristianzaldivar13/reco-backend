using Core.Enums;
using Core.Forms;

namespace Core.Interfaces.Motores
{
    public interface IMoSms
    {
        /// <summary>
        /// Proceso para enviar un SMS
        /// </summary>
        /// <param name="sms"></param>
        /// <returns></returns>
        Task<bool> Enviar(Sms sms);
    }
}
