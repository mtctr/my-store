using MyStore.API.Modules.Products.Entities;

namespace MyStore.API.Modules.Products.Ports;

public interface IBrandsRepository
{
    void Add(Brand brand);
    void Update(Brand brand);
    void Delete(Brand brand);
}
