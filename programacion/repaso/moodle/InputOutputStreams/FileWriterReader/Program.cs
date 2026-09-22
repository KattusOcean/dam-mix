using System.Reflection;

namespace FileWriterReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STRING READER
            string text = "Some number of characters";
            char[] characters = new char[125];

            StringReader sequence = new StringReader(text);
            sequence.Read(characters, 0, 14);
            sequence.Close();

            Console.WriteLine(characters);

            Console.WriteLine("\n--------------------------------------------------------\n");

            // STREAM READER + WRITER
            string? line;
            string path = "C:\\Users\\kattus\\Dam\\programacion\\repaso\\moodle\\InputOutputStreams\\FileWriterReader\\output.txt";
            int i = 1;

            while (Path.Exists(path)) {
                path = $"C:\\Users\\kattus\\Dam\\programacion\\repaso\\moodle\\InputOutputStreams\\FileWriterReader\\output{i}.txt";
                i++;
            }

            // Writes a new file output.txt with sample.txt
            try {
                StreamReader sr = new StreamReader("C:\\Users\\kattus\\Dam\\programacion\\repaso\\moodle\\InputOutputStreams\\FileWriterReader\\sample.txt");
                StreamWriter sw = new StreamWriter(path);
                line = sr.ReadLine();

                while (line != null) {
                    sw.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                
                sw.WriteLine("\nThis is a NOT a new addition!!!!!!!!");
                sw.Close();
            }
            catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }

            // Reads the new file (content copied from sample.txt)
            try {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();

                while (line != null) {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();

            }
            catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.WriteLine("\n--------------------------------------------------------\n");

            // FILE
            try {
                Console.WriteLine("File exists?: " + File.Exists(path));
            }
            catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.WriteLine("\n--------------------------------------------------------\n");

            // DIRECTORY (not functionall, it does not find the path)
            try {
                string dirPath = "C:\\Users\\kattus\\Dam\\programacion\\repaso\\moodle\\InputOutputStreams\\FileWriterReader\\pills";
                Directory.CreateDirectory(dirPath);

                Directory.Move($"{dirPath}\\bluePill", dirPath);
                Directory.Move($"{dirPath}\\redPill", dirPath);

                File.Create($"{dirPath}\\bluePill\\Cypher.txt");
                File.Create($"{dirPath}\\redPill\\Neo.txt");

            }
            catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
