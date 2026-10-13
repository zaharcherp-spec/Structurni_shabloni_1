public class RealTariffProvider : ITariffProvider
{
    private readonly Database _db;

    public RealTariffProvider(Database db)
    {
        _db = db;
    }

    public IEnumerable<Tariff> GetAvailableTariffs(int subscriberId)
    {
        return _db.Tariffs;
    }
}