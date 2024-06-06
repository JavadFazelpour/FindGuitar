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
        Instrument instrument = new Instrument(serialNumber, price, spec);
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

    public List<Instrument> Search(InstrumentSpec searchSpec)
    {
        List<Instrument> matchingInstruments = new();

        foreach (var instrument in inventory)
        {
            if (instrument.Spec.Matches(searchSpec))
                matchingInstruments.Add(instrument);
        }
        return matchingInstruments;
    }
}
