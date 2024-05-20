namespace FindGuitar;

internal class Guitar
{
    public string SerialNumber { get; private set; }
    public Builder Builder { get; private set; }
    public string Model { get; private set; }
    public Type Type { get; private set; }
    public Wood BackWood { get; private set; }
    public Wood TopWood { get; private set; }

    public decimal Price { get; set; }

    public Guitar(string serialNumber, decimal price, Builder builder, string model, Type type, Wood backWood, Wood topWood)
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
