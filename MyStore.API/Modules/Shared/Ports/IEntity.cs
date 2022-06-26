namespace MyStore.API.Modules.Shared.Ports;
public interface IEntity<TId>
{
    TId Id { get; }
    bool Active { get; }
    void Inactivate();
    void Update();
}
