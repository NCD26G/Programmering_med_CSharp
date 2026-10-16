using System;
using Client.Interfaces;
using Client.Services;
using Client.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Client.Helpers;

public static class ServiceCollectionExtensions
{
    // Syftet är att skapa en metod som lägger till tjänser services
    // i ServiceCollection objektet. Som vi fått via Microsoft.Extensions.DependencyInjection...
    public static void AddServices(this IServiceCollection collection)
    {
        // Om någon efterfrågar interface IProductService så ger
        // vi dem en instans av KalleAnka objektet...
        collection.AddSingleton<MainWindowViewModel>();
        collection.AddTransient<HomeViewModel>();
        collection.AddTransient<ProductsViewModel>();
        collection.AddTransient<IProductService, ProductServices>();
    }
}
