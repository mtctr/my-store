using MyStore.API.Modules.Shared.Ports;

namespace MyStore.API.Modules.Shared.Adapters;

public abstract class Entity<TId> : IEquatable<Entity<TId>>, IEntity<TId>
{
    public TId Id { get; protected set; }
    public bool Active { get; protected set; } = true;
    public DateTime CreatedAt { get; private set; } = DateTime.Now;
    public DateTime UpdatedAt { get; protected set; }

    protected Entity(TId id)
    {
        if (object.Equals(id, default(TId)))
        {
            throw new ArgumentException("The ID cannot be the type's default value.", "id");
        }

        this.Id = id;
        this.Active = true;
        this.CreatedAt = DateTime.Now;
    }

    // EF requires an empty constructor
    protected Entity()
    {
    }

    public void Inactivate()
    {
        this.Active = false;
    }
    public void Update()
    {
        this.UpdatedAt = DateTime.Now;
    }

    // For simple entities, this may suffice
    // As Evans notes earlier in the course, equality of Entities is frequently not a simple operation
    public override bool Equals(object otherObject)
    {
        var entity = otherObject as Entity<TId>;
        if (entity != null)
        {
            return this.Equals(entity);
        }
        return base.Equals(otherObject);
    }

    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }

    public bool Equals(Entity<TId> other)
    {
        if (other == null)
        {
            return false;
        }
        return this.Id.Equals(other.Id);
    }

}