public class Menu_
{
    private readonly Database _db;

    public Menu_(Database db)
    {
        _db = db;
    }

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("1. Змінити (обрати) тариф");
            Console.WriteLine("2. Вийти з програми");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введіть ваш ID:");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введіть Puk-code:");
                    int code = int.Parse(Console.ReadLine());

                    try
                    {
                        var realProvider = new RealTariffProvider(_db);
                        var proxy = new TariffProtectionProxy(realProvider, _db, code);

                        var tariffs = proxy.GetAvailableTariffs(id);

                        Console.WriteLine("Доступні тарифи:");
                        foreach (var t in tariffs)
                        {
                            Console.WriteLine($"{t.Name} - {t.Price}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Помилка: {ex.Message}");
                    }
                    break;

                case "2":
                    return;
            }
        }
    }
}