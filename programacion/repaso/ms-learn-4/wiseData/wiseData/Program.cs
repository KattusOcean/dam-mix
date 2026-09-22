namespace wiseData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Signed integral types:");
            Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short   : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int     : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long    : {long.MinValue} to {long.MaxValue}");

            Console.WriteLine("\nUnsigned integral types:");
            Console.WriteLine($"byte    : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort  : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint    : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong   : {ulong.MinValue} to {ulong.MaxValue}");

            Console.WriteLine("\nFloating point types:");
            Console.WriteLine($"float   : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double  : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

            Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");

            int first = 2;
            //int second = "4";
            string second = "4";
            string result = first + second;
            Console.WriteLine(result);
            Console.WriteLine();

            decimal myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");
            int myInt = (int)myDecimal;
            Console.WriteLine($"int: {myInt}");
            Console.WriteLine();

            // Constraint Conversion
            decimal myDecimal2 = 1.23456789m;
            float myFloat = (float) myDecimal2;
            Console.WriteLine($"Decimal: {myDecimal2}");
            Console.WriteLine($"Float  : {myFloat}");
            Console.WriteLine();

            // TO STRING
            int third = 5;
            int fourth = 7;
            float fifth = 3.14F;
            string message = third.ToString() + fourth.ToString() + fifth.ToString();
            Console.WriteLine("To string: " + message);
            Console.WriteLine();

            // PARSE
            string sixth = "5";
            string seventh = "7";
            int sum = int.Parse(sixth) + int.Parse(seventh);
            Console.WriteLine("Parse: " + sum);
            Console.WriteLine();

            // CONVERT
            string value1 = "5";
            string value2 = "7";
            int valueResult = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine("Convert: " + valueResult);
            Console.WriteLine();

            // TRY PARSE
            string value3 = "3";
            string value4 = "5";
            bool parsedValue1 = int.TryParse(value3, out int val3);
            bool parsedValue2 = int.TryParse(value4, out int val4);
            int parsedValueResult = val3 * val4;
            Console.WriteLine("TryParse: " + parsedValueResult);
            Console.WriteLine();

            // CAST (TRUNCATE) VS. CONVERT (ROUNDS UP)
            int valueCast = (int) 1.5m; // casting truncates
            Console.WriteLine("(int) 1.5M: " + valueCast);

            int valueConvert = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine("Convert.ToInt32(1.5M): " + valueConvert);
            Console.WriteLine();

            // IMPOSSIBLE TRY PARSE
            string word = "bad";
            int numResult = 0;

            if (int.TryParse(word, out numResult)) Console.WriteLine($"Measurement: {numResult}");
            else Console.WriteLine("Unable to report the measurement.");
            Console.WriteLine();

            Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");

            string[] codes = ["B14", "A11", "B12", "A13", "B14", "C19", "A17"];

            // SORT
            Console.WriteLine("Sorted...");
            Array.Sort(codes);
            int i = 0;
            foreach (var code in codes) {
                Console.WriteLine($"P.{i} = {code}");
                i++;
            }
            Console.WriteLine("\n");

            // INDEX OF
            Console.WriteLine("First index of...");
            Console.WriteLine("- B14: " + Array.IndexOf(codes, "B14"));
            Console.WriteLine("- A11: " + Array.IndexOf(codes, "A11"));
            Console.WriteLine("- A13: " + Array.IndexOf(codes, "A13"));
            Console.WriteLine("- Z99: " + Array.IndexOf(codes, "Z99"));
            Console.WriteLine("\n");

            // LAST INDEX OF
            Console.WriteLine("Last index of...");
            Console.WriteLine("- B14: " + Array.LastIndexOf(codes, "B14"));
            Console.WriteLine("- Z99: " + Array.LastIndexOf(codes, "Z99"));
            Console.WriteLine("- A11: " + Array.LastIndexOf(codes, "A11"));
            Console.WriteLine("\n");

            // REVERSE
            Console.WriteLine("Reversed...");
            Array.Reverse(codes);
            i = 0;
            foreach (string code in codes) {
                Console.WriteLine($"P.{i} = {code}");
                i++;
            }

            Console.WriteLine("\n");

            // RESIZE
            Console.WriteLine("Resized...");
            Console.WriteLine("Before: " + codes.Length);
            Array.Resize(ref codes, 10);
            Console.WriteLine("After 2: " + codes.Length);

            codes[8] = "X74";
            i = 0;
            foreach (string code in codes) {
                Console.WriteLine($"P.{i} = " + code);
                i++;
            }

            Console.WriteLine("\n");

            // CLEAR
            Console.WriteLine("Cleared...");
            Console.WriteLine("Original:");
            i = 0;
            foreach (string code in codes) {
                Console.WriteLine($"P.{i} = " + code);
                i++;
            }
            Console.WriteLine("\n");

            Console.WriteLine("Modified:");
            i = 0;
            Array.Clear(codes, 1, 5);
            foreach (string code in codes) {
                Console.WriteLine($"P.{i} = " + code);
                i++;
            }
            Console.WriteLine("\n");

            // RESIZE 2
            Console.WriteLine("Resized (again)...");
            Array.Resize(ref codes, 3);
            Console.WriteLine("After: " + codes.Length);

            i = 0;
            foreach (string code in codes) {
                Console.WriteLine($"P.{i} = {code}");
                i++;
            }

            Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");

            // TO CHAR ARRAY
            string word2 = "abc123";
            char[] charArray = word2.ToCharArray();
            foreach (char letter in charArray) {
                Console.Write(letter + " | ");
            }
            Console.WriteLine("\n");

            // CHAR ARRAY TO STRING
            Array.Reverse(charArray);
            string charResult = new string(charArray);
            Console.WriteLine(charResult);

            // JOIN
            charResult = string.Join("-", charArray);
            Console.WriteLine(charResult);

            // SPLIT
            //string[] items = charResult.Split("|"); // Will not work since it does not math the separator
            string[] items = charResult.Split("-");
            foreach (string item in items) {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");

            // FORMAT
            string part1 = "Hello";
            string part2 = "World";
            string partsResult = string.Format("{0} {1}!", part1, part2);
            Console.WriteLine(partsResult);
            Console.WriteLine("{0} {0} {0}!", part1, part2);
            Console.WriteLine("{0} {1}!", part1, part2);
            Console.WriteLine();

            // PADDING
            string input = "!!!!!!";
            Console.WriteLine("Hello" + input.PadLeft(15) + "Bye");
            Console.WriteLine("Hello" + input.PadRight(15) + "Bye");

            Console.WriteLine("Hello" + input.PadLeft(15, '-') + "Bye");
            Console.WriteLine("Hello" + input.PadRight(15, '-') + "Bye");
            Console.WriteLine();

            Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");

            // INDEX OF + SUBSTRING (PART 1)
            string holyMessage = "Find what is (inside the parentheses)";
            int openingPosition = holyMessage.IndexOf('(');
            int closingPosition = holyMessage.IndexOf(')');

            openingPosition += 1; // Because of the '(' space
            int substringLength = closingPosition - openingPosition;
            string intermediateMessage = holyMessage.Substring(openingPosition, substringLength);
            Console.WriteLine(intermediateMessage);

            // INDEX OF + SUBSTRING (PART 2)
            holyMessage = "What is the value <span>between the tags</span>?";
            openingPosition = holyMessage.IndexOf("<span>");
            closingPosition = holyMessage.IndexOf("</span>");

            openingPosition += 6; // Because of the larger word in "IndexOf"
            substringLength = closingPosition - openingPosition;
            Console.WriteLine(holyMessage.Substring(openingPosition, substringLength));

            Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");

            // REPLACE
            string evilMessage = "Big Dog";
            evilMessage = evilMessage.Replace("B", "D");
            Console.WriteLine(evilMessage);

            // REMOVE
            evilMessage = "This--is--ex-amp-le--da-ta";
            evilMessage = evilMessage.Remove(4, 19);
            Console.WriteLine(evilMessage);
        }
    }
}
