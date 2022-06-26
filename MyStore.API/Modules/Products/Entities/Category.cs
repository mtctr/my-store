using MyStore.API.Modules.Shared.Adapters;

namespace MyStore.API.Modules.Products.Entities;

public class Category : Entity<int>
{
    private Category()
    {
    }

    public Category(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }

}
