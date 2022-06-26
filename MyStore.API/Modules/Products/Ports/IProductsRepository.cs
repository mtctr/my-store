using MyStore.API.Modules.Products.Entities;

namespace MyStore.API.Modules.Products.Ports;

public interface IProductsRepository
{
    void Add(Product product);
    void Update(Product product);
    void Delete(Product product);
}
