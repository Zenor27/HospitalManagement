namespace HospitalEntities.Models
{
    public interface IIdentifiable<out T>
    {
        T Id { get; }
    }

    public interface IIdentifiable : IIdentifiable<int>
    {
    }
}