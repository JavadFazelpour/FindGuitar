namespace FindMusicalInstruments;

internal class MandolinSpec : InstrumentSpec
{
    public Style Style { get; private set; }

    public MandolinSpec(Builder builder, string model, Type type, Style style, Wood backWood, Wood topWood) : base(builder, model, type, backWood, topWood)
    {
        Style = style;
    }

    public override bool Matches(InstrumentSpec otherSpec)
    {
        if (!base.Matches(otherSpec)) return false;
        if (otherSpec is not MandolinSpec spec) return false;
        if (Style != spec.Style) return false;

        return true;
    }
}
