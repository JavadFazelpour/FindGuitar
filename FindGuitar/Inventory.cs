namespace FindGuitar;

internal class Inventory
{
    private List<Guitar> guitars;

    public Inventory()
    {
        guitars = new List<Guitar>();
    }

    public void AddGuitar(string serialNumber, decimal price,
                          Builder builder, string model,
                          Type type, Wood backWood, Wood topWood)
    {
        Guitar guitar = new Guitar(serialNumber, price, builder,
                                   model, type, backWood, topWood);
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

    public List<Guitar> Search(Guitar searchGuitar)
    {
        List<Guitar> matchingGuitars = new();

        foreach (var guitar in guitars)
        {
            Builder builder = searchGuitar.Builder;
            if (builder != guitar.Builder)
                continue;

            string model = searchGuitar.Model.ToLower();
            if (!string.IsNullOrWhiteSpace(model) && model != guitar.Model.ToLower())
                continue;

            Type type = searchGuitar.Type;
            if (type != guitar.Type)
                continue;

            Wood backWood = searchGuitar.BackWood;
            if (backWood != guitar.BackWood)
                continue;

            Wood topWood = searchGuitar.TopWood;
            if (topWood != guitar.TopWood)
                continue;
            matchingGuitars.Add(guitar);
        }
        return matchingGuitars;
    }
}
