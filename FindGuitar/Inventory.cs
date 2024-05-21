namespace FindGuitar;

internal class Inventory
{
    private List<Guitar> guitars;

    public Inventory()
    {
        guitars = new List<Guitar>();
    }

    public void AddGuitar(string serialNumber, decimal price, GuitarSpec guitarSpec)
    {
        Guitar guitar = new Guitar(serialNumber, price, guitarSpec);

        guitars.Add(guitar);
    }

    public Guitar GetGuitar(string serialNumber)
    {
        foreach (var guitar in guitars)
        {
            if (guitar.SerialNumber == serialNumber)
            {
                return guitar;
            }
        }
        return null;
    }

    public List<Guitar> Search(GuitarSpec searchSpec)
    {
        List<Guitar> matchingGuitars = new();

        foreach (var guitar in guitars)
        {
            GuitarSpec guitarSpec = guitar.Spec;

            Builder builder = searchSpec.Builder;
            if (builder != guitarSpec.Builder)
                continue;

            string model = searchSpec.Model.ToLower();
            if (!string.IsNullOrWhiteSpace(model) && model != guitarSpec.Model.ToLower())
                continue;

            Type type = searchSpec.Type;
            if (type != guitarSpec.Type)
                continue;

            Wood backWood = searchSpec.BackWood;
            if (backWood != guitarSpec.BackWood)
                continue;

            Wood topWood = searchSpec.TopWood;
            if (topWood != guitarSpec.TopWood)
                continue;
            matchingGuitars.Add(guitar);
        }
        return matchingGuitars;
    }
}
