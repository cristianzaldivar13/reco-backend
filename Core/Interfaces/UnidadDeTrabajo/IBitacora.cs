using Core.Clases;
using Core.Dtos;
using Core.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.UnidadDeTrabajo
{
	public interface IBitacora
	{
		/// <summary>
		/// Creacion de bitacora
		/// </summary>
		/// <returns></returns>
		Task<long> Crear(CrearBitacora bitacora);
	}
}
