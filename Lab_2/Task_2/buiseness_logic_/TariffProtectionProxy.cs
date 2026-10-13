public class TariffProtectionProxy : ITariffProvider
{
    private readonly RealTariffProvider _realProvider;
    private readonly Database _db;
    public int _entered_puke_code { get; init; }

    public TariffProtectionProxy(RealTariffProvider realTariffProvider, Database db, int entered_puke_code)
    {
        _realProvider = realTariffProvider;
        _db = db;
        _entered_puke_code = entered_puke_code;
    }

    public IEnumerable<Tariff> GetAvailableTariffs(int id)
    {
        var subscriber = _db.Subscribers.FirstOrDefault(s => s.Id == id);

        if (subscriber == null || subscriber.puk_code != _entered_puke_code)
        {
            throw new Exception("Невірний PUK-код або користувача не знайдено.");
        }

        return _realProvider.GetAvailableTariffs(id);
    }
}