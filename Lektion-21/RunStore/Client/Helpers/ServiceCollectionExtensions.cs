using System;
using Client.Factories;
using Client.Interfaces;
using Client.Services;
using Client.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Client.Helpers;

public static class ServiceCollectionExtensions
{
    public static void AddServices(this IServiceCollection collection)
    {
        collection.AddSingleton<MainWindowViewModel>();
        collection.AddSingleton<PageViewFactory>();
        collection.AddTransient<HomeViewModel>();
        collection.AddTransient<CustomersViewModel>();
        collection.AddTransient<ProductsViewModel>();
        collection.AddTransient<OrdersViewModel>();
        collection.AddTransient<IProductService, ProductServices>();
        collection.AddTransient<ICustomerService, CustomerServices>();

        collection.AddSingleton<Func<ApplicationNameEnum, PageViewModel>>(c => name => name switch
        {
            ApplicationNameEnum.Home => c.GetRequiredService<HomeViewModel>(),
            ApplicationNameEnum.Customers => c.GetRequiredService<CustomersViewModel>(),
            ApplicationNameEnum.Orders => c.GetRequiredService<OrdersViewModel>(),
            ApplicationNameEnum.Products => c.GetRequiredService<ProductsViewModel>(),
            _ => throw new InvalidOperationException("Det gick åt h-e")
        });
    }
}
