public class Database
{
    public List<Tariff> Tariffs { get; }
    public List<Subscriber> Subscribers { get; }

    public Database(List<Tariff> tariffs, List<Subscriber> subscribers)
    {
        Tariffs = tariffs;
        Subscribers = subscribers;
    }
}