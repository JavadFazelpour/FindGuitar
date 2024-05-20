
namespace FindGuitar;

internal class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        InitializeInventory(inventory);

        Guitar whatErinLikes = new Guitar("", 0, "fender", "Stratocastor", "electric", "Alder", "Alder");
        Guitar guitar = inventory.Search(whatErinLikes);
        if (guitar != null)
        {
            Console.WriteLine(guitar.Builder);
        }
        else
            Console.WriteLine("Sorry, Erin, we have nothing for you.");
    }

    private static void InitializeInventory(Inventory inventory)
    {
        inventory.AddGuitar("V95693", 1499.95m, "Fender", "Stratocastor", "electric", "Alder", "Alder");
    }
}
