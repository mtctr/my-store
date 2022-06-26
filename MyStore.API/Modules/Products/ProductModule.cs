using MyStore.API.Modules.Products.Adapters;
using MyStore.API.Modules.Products.Ports;

namespace MyStore.API.Modules.Products
{
    public class ProductModule : IModule
    {
        public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/products", () => { });
            endpoints.MapGet("/brands", () => { });
            endpoints.MapGet("/categories", () => { });

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection services)
        {
            services.AddScoped<IProductsRepository,ProductsRepository>();
            services.AddScoped<IBrandsRepository,BrandsRepository>();
            services.AddScoped<ICategoriesRepository,CategoriesRepository>();
            return services;
        }
    }
}
