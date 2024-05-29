namespace FindMusicalInstruments;

public class GuitarSpec : InstrumentSpec
{
    public int NumStrings { get; private set; }

    public GuitarSpec(Builder builder, string model, Type type, int numStrings, Wood backWood, Wood topWood) : base(builder, model, type, backWood, topWood)
    {
        this.NumStrings = numStrings;
    }

    public override bool Matches(InstrumentSpec otherSpec)
    {
        if (!base.Matches(otherSpec)) return false;
        if (otherSpec is not GuitarSpec spec) return false;
        if (NumStrings != spec.NumStrings) return false;

        return true;
    }



}
