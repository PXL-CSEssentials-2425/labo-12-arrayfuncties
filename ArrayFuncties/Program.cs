internal class Program
{
    private static void Main(string[] args)
    {
        string[] names =
            new string[10] { "Peter", "Tom", "Piet", "Ahmed", "Benny", "Anna", "Jane", "Ali", "John", "Tom" };

        Deel1(names);

        Deel2(names);

        Deel3(names);
    }

    private static void Deel1(string[] names)
    {
        Console.Write("Naam: ");
        string name = Console.ReadLine();

        int index = Array.IndexOf(names, name);

        if(index == -1)
        {
            Console.WriteLine($"De naam {name} komt niet voor in de reeks.");
        }
        else
        {
            Console.WriteLine($"De naam {name} staat op positie {index}.");
        }
    }

    private static void Deel2(string[] names)
    {
        Console.Write("Letter: ");
        string key = Console.ReadLine();

        string first = Array.Find(names, n => n.StartsWith(key));

        string[] all = Array.FindAll(names, n => n.StartsWith(key.ToUpper()));

        //Console.Write($"Namen die beginnen met de letter \"{key}\":");
        //foreach (string name in all)
        //{
        //    Console.Write(name + ", ");
        //}
        //Console.WriteLine();
        Console.WriteLine($"Namen die beginnen met de letter \"{key}\": {string.Join(',', all)}");
    }

    private static void Deel3(string[] names)
    {
        int index = -1;
        do
        {
            Console.Write("Index: ");
            if (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index > names.Length - 1)
            {
                Console.WriteLine("Ongeldige index");
                index = -1;
            }
        } while (index == -1);

        int length = -1;
        do
        {
            Console.Write("Lengte: ");
            if (!int.TryParse(Console.ReadLine(), out length) || length < 1 || length > names.Length - index)
            {
                Console.WriteLine("Ongeldige lengte");
                length = -1;
            }
        } while (length == -1);

        Console.WriteLine($"Ongesorteerde reeks: {string.Join(',', names)}");
        Array.Sort(names, index, length);
        Console.WriteLine($"Gesorteerde reeks: {string.Join(',', names)}");
    }
}