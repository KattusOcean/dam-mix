namespace InheretedClasses_AlexVT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dad dad = new Dad("Luis", 3);
            dad.Run();

            Console.WriteLine("\n------------------------------\n");

            Mom mom = new Mom("Tania", 3);
            mom.Run();

            Console.WriteLine("\n------------------------------\n");

            Mom mom2 = new Mom("Ana", 1);
            mom2.Run();
        }
    }
}