using Core.Enums;
using Core.Forms;
using Core.Vistas;

namespace Core.Interfaces.Motores
{
    public interface IMoIdentificacion
    {
        EnumResultadoCode GuardarINE(IdentificacionesRequest identificaciones);
        EnumResultadoCode ValidarExtension(IdentificacionesRequest viewModel);
        void GuardarIneSelfie(IdentificacionesRequest identificaciones);
        Identificaciones ValidacionIneSelfie();
        void GuardarFirmas(FirmaRequest identificaciones);
        Identificaciones ValidarFirmas(FirmaRequest viewModel);
        EnumResultadoCode ValidarFirmaExtension(FirmaRequest viewModel);
    }
}
