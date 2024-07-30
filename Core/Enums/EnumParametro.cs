namespace Core.Enums
{
    public enum EnumParametro
    {
        // General
        LimUsuarios = 1,

        // Contraseña
        LongitudMin = 2,
        LongitudMax = 3,
        LetrasMin = 4,
        LetrasMinMay = 5,
        DigitosMin = 6,
        CaracterEspMin = 7,
        LimHistorico = 8,
        TipoRecuperar = 9,

        // Bloqueo de usuarios
        ValBloqueo = 10,
        LimIntentos = 11,

        // Encuestas y Rutas
        LimEncuestas = 12,
        LimActividades = 13,
        ValReportePdfIndividual = 14,
        ValGeolocalizacion = 15,
        TolGeolocalizacion = 16,
        TempPinGeolocalizacion = 17,
        FrecReporteUbicacion = 18,
        ValCheckInCheckOut = 19,
        ValHorarioVisita = 20,

        // Layouts e inventario
        ValLayoutDepositos = 21,
        ValLayoutInventario = 22,
        ValInventarioAtm = 23,
        UrlInventario = 24,

        // Otro
        LimSemanas = 25,
        LimMeses = 26,
        LimDias = 27,
        TempExpiracion = 28,
        LimNotificaciones = 29,
        TipoEliminar = 30,
        TipoCargaMasiva = 31,
        LimCompresion = 32,
    }
}
