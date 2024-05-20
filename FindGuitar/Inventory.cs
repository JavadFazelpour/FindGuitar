namespace FindGuitar;

internal class Inventory
{
    private List<Guitar> guitars;

    public Inventory()
    {
        guitars = new List<Guitar>();
    }

    public void AddGuitar(string serialNumber, decimal price, string builder, string model, string type, string backWood, string topWood)
    {
        Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
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
            string builder = searchGuitar.Builder;
            if (!string.IsNullOrWhiteSpace(builder) && builder != guitar.Builder)
                continue;

            string model = searchGuitar.Model;
            if (!string.IsNullOrWhiteSpace(model) && model != guitar.Model)
                continue;

            string type = searchGuitar.Type;
            if (!string.IsNullOrWhiteSpace(type) && type != guitar.Type)
                continue;

            string backWood = searchGuitar.BackWood;
            if (!string.IsNullOrWhiteSpace(backWood) && backWood != guitar.BackWood)
                continue;

            string topWood = searchGuitar.TopWood;
            if (!string.IsNullOrWhiteSpace(topWood) && topWood != guitar.TopWood)
                continue;
        }
        return null;
    }
}
