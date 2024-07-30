namespace Core.Configuraciones
{
    public class CaracterConfig
    {
        public string Alfabeto { get; set; }
        public string Numeros { get; set; }
        public string Acentos { get; set; }
        public string Especiales { get; set; }

        public string Union => string.Format("{0}{1}{2}{3}", Alfabeto, Numeros, Acentos, Especiales);

        public CaracterConfig()
        {
            Alfabeto = string.Empty;
            Numeros = string.Empty;
            Acentos = string.Empty;
            Especiales = string.Empty;
        }
    }
}
