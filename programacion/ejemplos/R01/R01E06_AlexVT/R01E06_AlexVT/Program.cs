namespace R01E06_AlexVT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            /* 
             * Al poner una `?` al final del tipo de variable, el compilador nos deja de mostrar
             * un posible "System.NullReferenceException" ya que se le está indicando que la variable puede ser nula
             */
            string? nombreUsuario = null;

            // ENTRADA
            /* 
             * `Write()` permite escribir en la misma línea
             * `WriteLine()` hace un salto de línea por defecto
             */
            Console.Write("Introduce tu nombre de usuario: ");
            nombreUsuario = Console.ReadLine();

            // PROCESO

            // SALIDA
            Console.WriteLine($"Usuario: {nombreUsuario}");
        }
    }
}
