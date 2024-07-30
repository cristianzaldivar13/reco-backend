using Core.Dtos;

namespace Core.Interfaces.Motores
{
    public interface IMoFecha
    {
        /// <summary>
        /// Convierte un número a un objeto con hora, minuto y segundo.
        /// </summary>
        /// <param name="tiempo">Número entre -23.9999 y 23.9999</param>
        /// <returns></returns>
        TiempoDto ConvertirNumeroATiempo(double tiempo);

        /// <summary>
        /// Convierte un objeto con hora, minuto y segundo a número
        /// </summary>
        /// <param name="tiempo">Objeto con hora, minuto y segundo</param>
        /// <returns></returns>
        double ConvertirTiempoANumero(TiempoDto tiempo);

        /// <summary>
        /// Convierte un formato de hora (HH:mm:ss o HH:mm) a número
        /// </summary>
        /// <param name="tiempo">formato de hora (HH:mm:ss o HH:mm)</param>
        /// <returns></returns>
        double ConvertirTiempoANumero(string tiempo);

        /// <summary>
        /// Convierte una cadena con los nombres de los días de la semana a una lista de número de día equivalente
        /// </summary>
        /// <param name="dias">Nombre de días</param>
        /// <returns></returns>
        IEnumerable<int> ConvertirNombresDiasANumerosDias(string dias, char separador = '|');


        /// <summary>
        /// Evalua si el año con mes indicado, forma parte del periodo histórico.
        /// </summary>
        /// <param name="anualidad">Año del periodo</param>
        /// <param name="mensualidad">Mes del periodo</param>
        /// <returns></returns>
        bool EsPeriodoHistorico(int anualidad, int mensualidad);

        /// <summary>
        /// Obtiene los días de diferencia absolutos entre dos fechas
        /// </summary>
        /// <param name="fechaInicial">Fecha inicial</param>
        /// <param name="fechaFinal">Fecha final</param>
        /// <returns></returns>
        int DiasDeDiferencia(DateTime fechaInicial, DateTime fechaFinal);
    }
}
