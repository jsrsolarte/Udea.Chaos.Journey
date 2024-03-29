namespace Udea.Chaos.Journey.Domain.Entities
{
    public abstract class EntityBase<T> : DomainEntity, IEntityBase<T>
    {
        public virtual T Id { get; init; } = default!;
    }
}