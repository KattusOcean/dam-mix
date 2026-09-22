namespace R01E08_AlexVT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            string nombreVideojuego = "FIFA 2017";
            string desarrollador = "EA Sports";
            int pegi = 16;
            string plataforma = "PS4";
            int precio = 90;

            // ENTRADA

            // PROCESAMIENTO

            // SALIDA
            Console.WriteLine($"""
                Ficha del Videojuego
                    {nombreVideojuego} desarrollado por {desarrollador}
                    Recomendado a partir de {pegi}
                    Disponible para {plataforma} por tan solo {precio} Euros
                """);
        }
    }
}
