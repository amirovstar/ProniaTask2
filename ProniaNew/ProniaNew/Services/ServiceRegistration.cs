using System;
using ProniaNew.ExtensionServices.Implements;
using ProniaNew.ExtensionServices.Interfaces;
using ProniaNew.Services.Implements;
using ProniaNew.Services.Interfaces;

namespace ProniaNew.Services;

public static class ServiceRegistration
{
    public static void AddService(this IServiceCollection services)
    {
        services.AddScoped<ISliderService, SliderService>();
        services.AddScoped<IFileService, FileService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<LayoutService>();
    }
}

