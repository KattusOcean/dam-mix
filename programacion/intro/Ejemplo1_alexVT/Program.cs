namespace Ejemplo1_alexVT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare age
            int age = 20;
            if (age > 18) {
                for (int i = 0; i < 10; i++) {
                    Console.WriteLine($"Congrats! Your age is {age}");
                }
            } else {
                Console.WriteLine($"Get out! You are {age}");

            }

            Console.WriteLine("----------------------------------------");

            // Lower the age
            age = 17;
            if (age > 18)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Congrats! Your age is {age}");
                }
            }
            else
            {
                Console.WriteLine($"Get out! You are {age}");
            }
        }
    }
}
