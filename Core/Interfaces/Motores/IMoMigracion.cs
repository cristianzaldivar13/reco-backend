using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Motores
{
    public interface IMoMigracion
    {
        /// <summary>
        /// Migracion de archovos a tablas
        /// </summary>
        /// <param name="tabla"></param>
        /// <returns></returns>
        Task<bool> Migracion(string tabla);
    }
}
