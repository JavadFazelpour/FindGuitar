using System.Text;

namespace FindMusicalInstruments;

internal class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        InitializeInventory(inventory);

        GuitarSpec whatErinLikes = new(Builder.Fender, "Stratocastor", Type.Electric, 6, Wood.Alder, Wood.Alder);

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
                sb.Append("!\n---\n");
                Console.WriteLine(sb);
            }
        }
        else
            Console.WriteLine("Sorry, Erin, we have nothing for you.");

        MandolinSpec whatKatrinLikes = new(Builder.Gibson, "F5-G", Type.Acoustic, Style.A, Wood.Maple, Wood.Maple);
        List<Mandolin> mandolins = inventory.Search(whatKatrinLikes);

        if (mandolins != null)
        {
            Console.WriteLine("Katrin, you might like these mandolins:\n");

            foreach (Mandolin mandolin in mandolins)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("We have a ");
                sb.Append(mandolin.Spec.Builder);
                sb.Append(" ");
                sb.Append(mandolin.Spec.Model);
                sb.Append(" ");
                sb.Append(mandolin.Spec.Type);
                sb.Append(" mandolin:\n");
                sb.Append(mandolin.Spec.BackWood);
                sb.Append(" back and sides, \n");
                sb.Append(mandolin.Spec.TopWood);
                sb.Append(" top.\nYou can have it for only $");
                sb.Append(mandolin.Price);
                sb.Append("!\n---\n");
                Console.WriteLine(sb);
            }
        }
        else
            Console.WriteLine("Sorry, Katrin, we have nothing for you.");
    }

    private static void InitializeInventory(Inventory inventory)
    {

        // Guitars
        inventory.AddInstrument("V95693", 1499.95m, new GuitarSpec(Builder.Fender, "Stratocastor", Type.Electric, 6, Wood.Alder, Wood.Alder));
        inventory.AddInstrument("V9512", 1549.95m, new GuitarSpec(Builder.Fender, "Stratocastor", Type.Electric, 6, Wood.Alder, Wood.Alder));
        inventory.AddInstrument("11277", 3999.95m, new GuitarSpec(Builder.Collings, "CJ", Type.Acoustic, 6, Wood.IndianRosewood, Wood.Spruce));
        inventory.AddInstrument("122784", 5495.95m, new GuitarSpec(Builder.Martin, "D-18", Type.Acoustic, 6, Wood.Mahogany, Wood.Adirondack));
        inventory.AddInstrument("82765501", 1890.95m, new GuitarSpec(Builder.Gibson, "SG'61", Type.Electric, 6, Wood.Mahogany, Wood.Mahogany));
        inventory.AddInstrument("70108276", 2295.95m, new GuitarSpec(Builder.Gibson, "Les Paul", Type.Electric, 6, Wood.Maple, Wood.Maple));

        // Mandolins
        inventory.AddInstrument("9019920", 5495.99m, new MandolinSpec(Builder.Gibson, "F5-G", Type.Acoustic, Style.A, Wood.Maple, Wood.Maple));

    }
}
