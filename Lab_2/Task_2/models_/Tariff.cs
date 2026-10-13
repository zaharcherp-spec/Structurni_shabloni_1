public class Tariff
{
    private string _name;
    private decimal _price;

    public string Name
    {
        get => _name;
        set
        {
            if (value != null && value.Contains(' '))
            {
                throw new Exception("Введіть без пробілу");
            }
            _name = value;
        }
    }

    public decimal Price
    {
        get => _price;
        set => _price = value;
    }

    public Tariff(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}