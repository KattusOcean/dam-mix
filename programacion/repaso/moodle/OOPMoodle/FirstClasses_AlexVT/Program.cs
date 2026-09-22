namespace FirstClasses_AlexVT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bottle bottle = new Bottle(5, "None", "Water");
            Bottle limonade = new Bottle(10, "Fanta", "Limonade");
            Bottle coke = new Bottle(3, "CocaCola", "Coke");

            Console.WriteLine("----- BOTTLE 1 -----");
            bottle.LookBootle();
            Console.WriteLine("----- BOTTLE 2 -----");
            limonade.LookBootle();
            Console.WriteLine("----- BOTTLE 3 -----");
            coke.LookBootle();

            Console.WriteLine();

            Console.WriteLine("----- DRINK BOTTLE 2 -----");
            limonade.Drink(2);

            Console.WriteLine();

            Console.WriteLine("----- BOTTLE 2 (AFTER) -----");
            limonade.LookBootle();

        }
    }
}
