using System.Text;

namespace FindMusicalInstruments;

internal class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        InitializeInventory(inventory);

        Dictionary<string, string> properties = new() {
            {"builder","Gibson"},
            {"backWood","Maple"},
        };
        InstrumentSpec clientSpec = new InstrumentSpec(properties);

        List<Instrument> matchingInstruments = inventory.Search(clientSpec);
        if (matchingInstruments != null)
        {
            Console.WriteLine("You might like these instruments:\n");

            foreach (var instrument in matchingInstruments)
            {
                InstrumentSpec spec = instrument.Spec;
                Console.WriteLine("We have a " + spec.Properties["instrumentType"] + " with the following properties:");
                foreach (var entry in spec.Properties)
                {
                    if (entry.Key == "instrumentType") continue;
                    Console.WriteLine("    " + entry.Key + ": " + entry.Value);
                }
                Console.WriteLine($"   You can have this {spec.Properties["instrumentType"]} for ${instrument.Price}");
            }
        }
        else
            Console.WriteLine("Sorry, we have nothing for you.");
    }

    private static void InitializeInventory(Inventory inventory)
    {

        Dictionary<string, string> properties = new()
        {
            { "instrumentType", "Guitar" },
            { "builder", "Collings" },
            { "model", "CJ" },
            { "type", "Acoustic" },
            { "numStrings", "6" },
            { "topWood", "Indian RoseWood" },
            { "backWood", "Sitka" }
        };
        inventory.AddInstrument("11277", 3999.95m, new InstrumentSpec(properties));

        properties = new(){
            { "instrumentType", "Guitar" },
            { "builder", "Martin" },
            { "model", "D-18" },
            { "type", "Acoustic" },
            { "numStrings", "6" },
            { "topWood", "Mahogany" },
            { "backWood", "Adirondack" }
        };
        inventory.AddInstrument("122784", 5495.95m, new InstrumentSpec(properties));

        properties = new(){
            { "instrumentType", "Guitar" },
            { "builder", "Fender" },
            { "model", "Stratocastor" },
            { "type", "Electric" },
            { "numStrings", "6" },
            { "topWood", "Alder" },
            { "backWood", "Alder" }
        };
        inventory.AddInstrument("V9512", 1549.95m, new InstrumentSpec(properties));

        properties = new(){
            { "instrumentType", "Guitar" },
            { "builder", "Gibson" },
            { "model", "Les Paul" },
            { "type", "Electric" },
            { "numStrings", "6" },
            { "topWood", "Maple" },
            { "backWood", "Maple" }
        };
        inventory.AddInstrument("70108276", 2295.95m, new InstrumentSpec(properties));

        // inventory.AddInstrument("V95693", 1499.95m, new GuitarSpec(Builder.Fender, "Stratocastor", Type.Electric, 6, Wood.Alder, Wood.Alder));
        // inventory.AddInstrument("82765501", 1890.95m, new GuitarSpec(Builder.Gibson, "SG'61", Type.Electric, 6, Wood.Mahogany, Wood.Mahogany));

        // inventory.AddInstrument("9019920", 5495.99m, new MandolinSpec(Builder.Gibson, "F5-G", Type.Acoustic, Style.A, Wood.Maple, Wood.Maple));

    }
}
