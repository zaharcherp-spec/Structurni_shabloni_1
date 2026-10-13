public interface ITariffProvider
{
    IEnumerable<Tariff> GetAvailableTariffs(int subscriberId);
}