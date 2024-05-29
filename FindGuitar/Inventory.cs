namespace FindMusicalInstruments;

internal class Inventory
{
    private List<Instrument> inventory;

    public Inventory()
    {
        inventory = new List<Instrument>();
    }

    public void AddInstrument(string serialNumber, decimal price, InstrumentSpec spec)
    {
        Instrument instrument = null;
        
        if (spec is GuitarSpec guitarSpec)
            instrument = new Guitar(serialNumber, price, guitarSpec);

        else if (spec is MandolinSpec mandolinSpec)
            instrument = new Mandolin(serialNumber, price, mandolinSpec);

        inventory.Add(instrument);
    }

    public Instrument GetInstrument(string serialNumber)
    {
        foreach (var instrument in inventory)
        {
            if (instrument.SerialNumber == serialNumber)
            {
                return instrument;
            }
        }
        return null;
    }

    public List<Guitar> Search(GuitarSpec searchSpec)
    {
        List<Guitar> matchingGuitars = new();

        foreach (var item in inventory)
        {
            if (item is not Guitar guitar) continue;

            if (guitar.Spec.Matches(searchSpec))
                matchingGuitars.Add(guitar);
        }
        return matchingGuitars;
    }
    public List<Mandolin> Search(MandolinSpec searchSpec)
    {
        List<Mandolin> matchingMandolins = new();

        foreach (var item in inventory)
        {
            if (item is not Mandolin mandolin) continue;

            if (mandolin.Spec.Matches(searchSpec))
                matchingMandolins.Add(mandolin);
        }
        return matchingMandolins;
    }
}
