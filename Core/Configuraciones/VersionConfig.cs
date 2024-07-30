namespace Core.Configuraciones
{
    public class VersionConfig
    {
        /// <summary>
        /// Indica el ambiente [1 degub | 2 dev | 3 qa | 4 prod]
        /// </summary>
        public int Major { get; set; }

        /// <summary>
        /// Incorporación de nuevas funcionalidades
        /// </summary>
        public int Minor { get; set; }

        /// <summary>
        /// Versión de base de datos
        /// </summary>
        public int DataBase { get; set; }

        /// <summary>
        /// Indica los cambios por alguna incidencia
        /// </summary>
        public int Revision { get; set; }

        public string Numero
        {
            get { return string.Format("v{0}.{1}.{2}.{3}", Major, Minor, DataBase, Revision); }
        }

        public string Autor { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Ticket { get; set; }

        public VersionConfig()
        {
            Major = 0;
            Minor = 0;
            DataBase = 0;
            Revision = 0;
            Autor = string.Empty;
            Descripcion = string.Empty;
            Fecha = DateTime.Now;
            Ticket = string.Empty;
        }
    }
}
