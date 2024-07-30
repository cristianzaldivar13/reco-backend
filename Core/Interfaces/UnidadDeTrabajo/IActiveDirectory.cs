using Core.Configuraciones;
using Core.Forms;
using Core.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.UnidadDeTrabajo
{
	public interface IActiveDirectory
    {
		Task<long> Session(ReenvioEmail reenvioEmail);
	}
}
