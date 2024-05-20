namespace FindGuitar;

internal class Inventory
{
    private List<Guitar> guitars;

    public Inventory()
    {
        guitars = new List<Guitar>();
    }

    public void AddGuitar(string serialNumber, decimal price,
                          string builder, string model,
                          string type, string backWood, string topWood)
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

    public Guitar Search(Guitar searchGuitar)
    {
        foreach (var guitar in guitars)
        {
            string builder = searchGuitar.Builder.ToLower();
            if (!string.IsNullOrWhiteSpace(builder) && builder!= guitar.Builder.ToLower())
                continue;

            string model = searchGuitar.Model.ToLower();
            if (!string.IsNullOrWhiteSpace(model) && model != guitar.Model.ToLower())
                continue;

            string type = searchGuitar.Type.ToLower();
            if (!string.IsNullOrWhiteSpace(type) && type != guitar.Type.ToLower())
                continue;

            string backWood = searchGuitar.BackWood.ToLower();
            if (!string.IsNullOrWhiteSpace(backWood) && backWood != guitar.BackWood.ToLower())
                continue;

            string topWood = searchGuitar.TopWood.ToLower();
            if (!string.IsNullOrWhiteSpace(topWood) && topWood != guitar.TopWood.ToLower())
                continue;

            return guitar;
        }
        return null;
    }
}
