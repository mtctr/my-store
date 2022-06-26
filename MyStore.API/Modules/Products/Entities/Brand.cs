using MyStore.API.Modules.Shared.Adapters;

namespace MyStore.API.Modules.Products.Entities;

public class Brand : Entity<int>
{
    private Brand()
    {
    }

    public Brand(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }
}
