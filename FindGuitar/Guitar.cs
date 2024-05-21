namespace FindGuitar;

internal class Guitar
{
    public string SerialNumber { get; private set; }
    public decimal Price { get; set; }

    public GuitarSpec Spec { get; private set; }

    public Guitar(string serialNumber, decimal price, GuitarSpec guitarSpec)
    {
        SerialNumber = serialNumber;
        Price = price;
        Spec = guitarSpec;
    }
}
