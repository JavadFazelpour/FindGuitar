using System.Text;

namespace FindGuitar;

internal class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        InitializeInventory(inventory);

        Guitar whatErinLikes = new Guitar("", 0, Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder);
        List<Guitar> guitars = inventory.Search(whatErinLikes);
        if (guitars != null)
        {
            Console.WriteLine("Erin, you might like these guitars:\n");

            foreach (Guitar guitar in guitars)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("We have a ");
                sb.Append(guitar.Builder);
                sb.Append(" ");
                sb.Append(guitar.Model);
                sb.Append(" ");
                sb.Append(guitar.Type);
                sb.Append(" guitar:\n");
                sb.Append(guitar.BackWood);
                sb.Append(" back and sides, \n");
                sb.Append(guitar.TopWood);
                sb.Append(" top.\nYou can have it for only $");
                sb.Append(guitar.Price);
                sb.Append("!\n---");
                Console.WriteLine(sb); 
            }
        }
        else
            Console.WriteLine("Sorry, Erin, we have nothing for you.");
    }

    private static void InitializeInventory(Inventory inventory)
    {
        inventory.AddGuitar("V95693", 1499.95m, Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder);
        inventory.AddGuitar("V9512", 1549.95m, Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder);
    }
}
