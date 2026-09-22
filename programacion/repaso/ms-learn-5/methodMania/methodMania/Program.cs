namespace methodMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            greet();

            // Variable passed by value (mod != applied | num == copy)
            int num = 10;
            addTwo(num);
            Console.WriteLine(num);
            Console.WriteLine(addTwo(num));

            Console.WriteLine("-------------");

            // Variable passed by reference (mod == applied | newNum != copy)
            int newNum = 10;
            addFive(ref newNum);
            Console.WriteLine(newNum);
            Console.WriteLine(addFive(ref newNum));
        }

        static void greet() {
            Console.WriteLine("Hello, World!");
        }

        static int addTwo(int n) {
            return n += 2;
        }

        static int addFive(ref int n) {
            return n += 5;
        }
    }
}
