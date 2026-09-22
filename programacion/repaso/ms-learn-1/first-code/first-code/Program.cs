namespace first_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Print decimal numbers
             * 
             * Float (F) -> between 6 - 9 digits
             * Double (default) -> between 15 - 19 digits
             * Decimal (m) -> between 28 - 29 digits
             * 
             * 1. 0,25794825 (8 digits + rounded)
             * 2. 0,25794823748273493 (17 digits + rounded)
             * 3. 0,2579482374827349273974234983 (28 digits + rounded)
             */
            Console.WriteLine(0.257948237482734927397423498273482973F);
            Console.WriteLine(0.257948237482734927397423498273482973);
            Console.WriteLine(0.257948237482734927397423498273482973M);
            Console.WriteLine();

            //-----------------------------------------------------------
            //-----------------------------------------------------------

            string user = "Bob";
            short messagesQuantity = 3;
            float temperature = 34.4F;

            Console.WriteLine($"Hello, {user}! You have {messagesQuantity} messages in your inbox. The temperature is {temperature} celsius.");
            Console.WriteLine();
            
            //-----------------------------------------------------------
            //-----------------------------------------------------------
            
            Console.WriteLine("Hello \"World\"!"); // output -> "Hello "World"!"
            Console.WriteLine("C:\\source\\repos"); // output -> "C:\source\repos"

            // output -> "   C:\source\repos
            //                  (code...) (more code...)"
            Console.WriteLine(@"    C:\source\repos
        (code...) (more code...)");

            // Kon'nichiwa World
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

            // Combination of `@` and `$`
            string userDir = "kattus";
            Console.WriteLine($@"C:\users\{userDir}\Data");
            Console.WriteLine();

            //-----------------------------------------------------------
            //-----------------------------------------------------------

            /* ~int~ */ decimal decimalQuotientA = 7 / 5.0m;
            /* ~int~ */ decimal decimalQuotientB = 7.0m / 5;
            /* ~int~ */ decimal decimalQuotientC = 7.0m / 5.0m;
            decimal decimalQuotientD = 7 / 5;
            Console.WriteLine($"{decimalQuotientA} | {decimalQuotientB} | {decimalQuotientC} | {decimalQuotientD}");
            Console.WriteLine();
            
            //-----------------------------------------------------------
            //-----------------------------------------------------------

            /* Pre / post increment
             * 
             * `value++` -> "Queues" an increment
             * `++value` -> Directly increments the value
             * 
             * 1. Value was set and used before the "queued" increment. Out = 2
             * 2. Same as the previous line but this time "queues" an increment for the next use. Out = 2
             * 3. Since the variable has a "queued" increment (previous line), it is applied now. Out = 3
             * 4. Value should not change from 3, but since we used `++value`, the value increases without "queueing". Out = 4
             */
            int value = 1;
            value++;
            Console.WriteLine("First: " + value);
            Console.WriteLine($"Second: {value++}");
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));
            Console.WriteLine();
        }
    }
}
