class Program
{
    static void Main()
    {
        var tariffs = new List<Tariff>
        {
            new Tariff("Basic", 100m),
            new Tariff("Pro", 250m)
        };

        var subscribers = new List<Subscriber>
        {
            new Subscriber { Id = 1, puk_code = 1234 }
        };

        var db = new Database(tariffs, subscribers);
        var ui = new Menu_(db);

        ui.Show();
    }
}