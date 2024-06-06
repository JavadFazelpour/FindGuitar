namespace FindMusicalInstruments;

public class Instrument
{
    public string SerialNumber { get; private set; }
    public decimal Price { get; private set; }
    public InstrumentSpec Spec { get; private set; }


    public Instrument(string serialNumber, decimal price, InstrumentSpec spec)
    {
        SerialNumber = serialNumber;
        Price = price;
        this.Spec = spec;
    }
}
