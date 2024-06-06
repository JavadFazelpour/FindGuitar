namespace FindMusicalInstruments;

public class InstrumentSpec
{
    public Dictionary<string, string> Properties { get; private set; }

    public InstrumentSpec(Dictionary<string, string> properties)
    {
        if (Properties == null) Properties = new Dictionary<string, string>();
        Properties = properties;
    }

    public virtual bool Matches(InstrumentSpec otherSpec)
    {
        foreach (var key in otherSpec.Properties.Keys)
            if (Properties[key] != otherSpec.Properties[key])
                return false;
        return true;
    }
}
