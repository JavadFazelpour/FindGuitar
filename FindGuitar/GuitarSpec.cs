namespace FindGuitar;

public class GuitarSpec
{
    public string Model { get; set; }

    public Builder Builder { get; set; }
    public Type Type { get; set; }
    public Wood BackWood { get; set; }
    public Wood TopWood { get; set; }

    public GuitarSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood)
    {
        Builder = builder;
        Model = model;
        Type = type;
        BackWood = backWood;
        TopWood = topWood;
    }
}
