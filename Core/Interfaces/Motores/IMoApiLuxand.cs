using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Motores
{
    public interface IMoApiLuxand
    {
        decimal? ReconocimientoFacial(string token, string nombreINE, string fotoINE, string fotoSelfie);
    }
}
