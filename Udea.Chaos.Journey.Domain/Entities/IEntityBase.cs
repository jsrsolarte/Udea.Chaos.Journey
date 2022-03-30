namespace Udea.Chaos.Journey.Domain.Entities
{
    public interface IEntityBase<out T>
    {
        T Id { get; }
    }
}