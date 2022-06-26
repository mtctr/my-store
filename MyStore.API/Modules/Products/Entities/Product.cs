using MyStore.API.Modules.Shared.Adapters;

namespace MyStore.API.Modules.Products.Entities;

public class Product : Entity<Guid>
{
    private Product() { }
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public Brand Brand { get; private set; }
    public IEnumerable<Category> Categories { get; private set; } = new List<Category>();

    public void SetBrand(Brand brand)
    {
        Brand = brand;
    }
    public void SetCategories(IEnumerable<Category> categories)
    {
        Categories = categories;
    }
}
