using System.ComponentModel.DataAnnotations;

namespace Core.Enums
{
    public enum EnumCodigoRespuesta
    {
        [Display(Name = "Desconocido")]
        Desconocido = -1,

        [Display(Name = "Excepción")]
        Exception = 0,

        [Display(Name = "Proceso Correcto")]
        ProcesoCorrecto = 1,

        [Display(Name = "Función No Permitida")]
        FuncionNoPermitida = 2,

        [Display(Name = "Sesión Inválida")]
        SesionInvalida = 3,

        [Display(Name = "Modelo Incorrecto")]
        ModeloIncorrecto = 4,

        [Display(Name = "Acceso Database Denegado")]
        AccesoDatabaseDenegado = 5,

        [Display(Name = "Consulta Vacía")]
        ConsultaVacia = 6,

        [Display(Name = "Registro Inexistente")]
        RegistroInexistente = 7,

        [Display(Name = "Registro en Uso")]
        RegistroEnUso = 8,

        [Display(Name = "Detalle Incorrecto")]
        DetalleIncorrecto = 9,

        [Display(Name = "Creación Incorrecta")]
        CreacionIncorrecta = 10,

        [Display(Name = "Edición Incorrecta")]
        EdicionIncorrecta = 11,

        [Display(Name = "Cambiar Estatus Incorrecto")]
        CambiarEstatusIncorrecto = 12,

        [Display(Name = "Eliminación Incorrecta")]
        EliminacionIncorrecta = 13,

        [Display(Name = "Desbloqueo Incorrecto")]
        DesbloqueoIncorrecto = 14,

        [Display(Name = "Proceso Incorrecto")]
        ProcesoIncorrecto = 15,

        [Display(Name = "Usuario Desconocido")]
        UsuarioDesconocido = 16,

        [Display(Name = "Usuario Inactivo")]
        UsuarioInactivo = 17,

        [Display(Name = "Usuario Pendiente")]
        UsuarioPendiente = 18,

        [Display(Name = "Usuario Bloqueado")]
        UsuarioBloqueado = 19,

        [Display(Name = "Intentos de Usuario Superados")]
        UsuarioIntentosSuperados = 20,

        [Display(Name = "Contraseña de Usuario Incorrecta")]
        UsuarioPasswordIncorrecto = 21,

        [Display(Name = "Error de Configuración")]
        ErrorConfiguracion = 22,

        [Display(Name = "Error de Solicitud")]
        ErrorSolicitud = 23,

        [Display(Name = "Ok")]
        Ok = 200,
    }
}
