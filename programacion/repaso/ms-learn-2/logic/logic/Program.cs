namespace logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int zero = 0, one = 0, two = 0, three = 0, four = 0, five = 0, six = 0, seven = 0, eight = 0;

            for (int i = 0; i < 20; i++) { 
                int roll = dice.Next(1, 7); // Includes 1 but not 7

                switch (roll) {
                    case 0:zero++;break;
                    case 1: one++; break;
                    case 2: two++; break;
                    case 3: three++; break;
                    case 4: four++; break;
                    case 5: five++; break;
                    case 6: six++; break;
                    case 7: seven++; break;
                    case 8: eight++; break;
                }
            }

            Console.WriteLine($"""
                --- RESULTS ---
                Zero:   {zero}
                One:    {one}
                Two:    {two}
                Three:  {three}
                Four:   {four}
                Five:   {five}
                Six:    {six}
                Seven:  {seven}
                """);

            Console.WriteLine("---------------------------------------------------------------");

            int firstValue = 500;
            int secondValue = 600;
            int largerValue;

            largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine(largerValue);

            Console.WriteLine("---------------------------------------------------------------");

            string[] classList = { "Alex", "Luis", "Paco" };

            foreach (string name in classList) {
                Console.WriteLine(name);
            }

            Console.WriteLine("---------------------------------------------------------------");

            /*  
             *  (i - left to right) ; (j | up to down)
             *  
             *  3 6 7
             *  7 3 7
             *  3 4 5
             *  
             *  Value in i = 0 and j = 0 is equal to 3
             *  Value in i = 0 and j = 1 is equal to 6
             *  Value in i = 0 and j = 2 is equal to 7
             *  
             *  Value in i = 1 and j = 0 is equal to 7
             *  Value in i = 1 and j = 1 is equal to 3
             *  Value in i = 1 and j = 2 is equal to 7
             *  
             *  Value in i = 2 and j = 0 is equal to 3
             *  Value in i = 2 and j = 1 is equal to 4
             *  Value in i = 2 and j = 2 is equal to 5
             */

            int[,] matrix = new int[3, 3];

            Random randomNum = new Random();
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j <= columns - 1; j++) {
                    matrix[i,j] = randomNum.Next(0, 8);
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j <= columns - 1; j++) {

                    if ((i == 0) && (j == 1)) Console.WriteLine($"\nValue in i = {i} and j = {j} is equal to {matrix[i, j]}");
                }
            }

            Console.WriteLine("---------------------------------------------------------------");

            string[] codes = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            Console.WriteLine(codes[0]);

            foreach (string code in codes) {
                if (code.StartsWith("C")) {
                    Console.WriteLine(code);
                }
            }
        }
    }
}
