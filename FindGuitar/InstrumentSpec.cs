namespace FindMusicalInstruments;

public abstract class InstrumentSpec
{
    public Builder Builder { get; private set; }
    public string Model { get; private set; }
    public Type Type { get; private set; }
    public Wood BackWood { get; private set; }
    public Wood TopWood { get; private set; }

    public InstrumentSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood)
    {
        Builder = builder;
        Model = model;
        Type = type;
        BackWood = backWood;
        TopWood = topWood;
    }

    public virtual bool Matches(InstrumentSpec otherSpec)
    {
        if (Builder != otherSpec.Builder) return false;
        if (!string.IsNullOrWhiteSpace(Model) && Model != otherSpec.Model) return false;
        if (Type != otherSpec.Type) return false;
        if (BackWood != otherSpec.BackWood) return false;
        if (TopWood != otherSpec.TopWood) return false;

        return true;
    }
}
