namespace logicInPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a" == "a"); // True
            Console.WriteLine("a" == "a "); // False

            string character1 = "A ";
            string character2 = " a";
            Console.WriteLine(character2.ToLower().Trim() == character1.ToLower().Trim()); // True

            Console.WriteLine("-----------------------------------------------------------------");
            
            Console.WriteLine($"Is 100 bigger than 500?: {(100 > 500 ? true : false)}");

            Console.WriteLine("-----------------------------------------------------------------");

            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;

            foreach (int number in numbers) {
                total += number;
                if (number == 42) found = true;
            }

            if (found) Console.WriteLine("Set contains 42");

            Console.WriteLine($"Total: {total}");

            Console.WriteLine("-----------------------------------------------------------------");

            int option = 4;

            switch (option) {

                case 1:
                    Console.WriteLine(1);
                    break;

                case 2:
                    Console.WriteLine(2);
                    break;

                case 3:
                    Console.WriteLine(3);
                    break;

                case 4:
                    Console.WriteLine(4);
                    break;

                default:
                    Console.WriteLine("Default");
                    break;
            }

            Console.WriteLine("-----------------------------------------------------------------");


        }
    }
}
