using MyStore.API.Modules.Products.Entities;

namespace MyStore.API.Modules.Products.Ports;

public interface ICategoriesRepository
{
    void Add(Category category);
    void Update(Category category);
    void Delete(Category category);
}
