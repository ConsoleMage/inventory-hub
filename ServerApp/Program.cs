using Microsoft.Extensions.Caching.Memory;
using SharedModels;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Add memory cache service
builder.Services.AddMemoryCache();

var app = builder.Build();

app.MapGet("/api/productlist", (IMemoryCache cache) =>
{
    const string cacheKey = "productList";
    if (!cache.TryGetValue(cacheKey, out Product[] products))
    {
        products = new[]
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 1200.50,
                Stock = 25,
                Category = new Category { Id = 101, Name = "Electronics" }
            },
            new Product
            {
                Id = 2,
                Name = "Headphones",
                Price = 50.00,
                Stock = 100,
                Category = new Category { Id = 102, Name = "Accessories" }
            }
        };

        // Set cache options (e.g., cache for 5 minutes)
        var cacheEntryOptions = new MemoryCacheEntryOptions()
            .SetSlidingExpiration(TimeSpan.FromMinutes(5));

        cache.Set(cacheKey, products, cacheEntryOptions);
    }

    return products;
});

app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());

app.Run();
