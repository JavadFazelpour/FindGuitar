namespace FindGuitar;

internal class Guitar
{
    public string SerialNumber { get; private set; }
    public string Builder { get; private set; }
    public string Model { get; private set; }
    public string Type { get; private set; }
    public string BackWood { get; private set; }
    public string TopWood { get; private set; }

    public decimal Price { get; set; }

    public Guitar(string serialNumber, decimal price, string builder, string model, string type, string backWood, string topWood)
    {
        SerialNumber = serialNumber;
        Price = price;
        Builder = builder;
        Model = model;
        Type = type;
        BackWood = backWood;
        TopWood = topWood;
    }
}
