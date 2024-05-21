using System.Text;

namespace FindGuitar;

internal class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        InitializeInventory(inventory);

        GuitarSpec whatErinLikes = new(Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder);

        List<Guitar> guitars = inventory.Search(whatErinLikes);
        if (guitars != null)
        {
            Console.WriteLine("Erin, you might like these guitars:\n");

            foreach (Guitar guitar in guitars)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("We have a ");
                sb.Append(guitar.Spec.Builder);
                sb.Append(" ");
                sb.Append(guitar.Spec.Model);
                sb.Append(" ");
                sb.Append(guitar.Spec.Type);
                sb.Append(" guitar:\n");
                sb.Append(guitar.Spec.BackWood);
                sb.Append(" back and sides, \n");
                sb.Append(guitar.Spec.TopWood);
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
        GuitarSpec spec1 = new(Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder);

        inventory.AddGuitar("V95693", 1499.95m, spec1);
        inventory.AddGuitar("V9512", 1549.95m, spec1);
    }
}
