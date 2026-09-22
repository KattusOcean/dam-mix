namespace R01E07_AlexVT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            string? nombre, apellidos;
            int? edad;

            // ENTRADA
            Console.Write("Introduce tu nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Introduce tus apellidos: ");
            apellidos = Console.ReadLine();


            /* Hay tres métodos para convertir un string a un int:
             * 
             * Parse -> Devuelve excepciones (pensado una conversión asegurada)
             * TryParse -> No devuelve excepciones (pensado para controlar errores de entrada. Ej. 19e o 300ç)
             * Convert -> Maneja excepciones devolviendo un valor 0 por defecto
             */
            Console.Write("Introduce tu edad: ");
            // --- Parse
            //edad = int.Parse(Console.ReadLine());

            // --- TryParse (habría que hacer ajustes con las variables para que funcione)
            //bool numeroValido = int.TryParse(Console.ReadLine(), out int edadTransformada);
            //if (numeroValido) edad = edadTransformada;
            //else Console.WriteLine("Edad invalida");

            // --- Convert (Int8 = 8bit | Int16 = 16bit | Int32 = 32bit | Int64 = 64bit)
            edad = Convert.ToInt32(Console.ReadLine());

            // PROCESO

            // SALIDA
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellidos: {apellidos}");
            Console.WriteLine($"Edad: {edad}");
        }
    }
}
