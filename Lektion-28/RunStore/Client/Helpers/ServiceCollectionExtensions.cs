using System;
using Client.Enums;
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
        collection.AddTransient<ProductsViewModel>();
        collection.AddTransient<CustomersViewModel>();
        collection.AddTransient<AddProductViewModel>();
        collection.AddTransient<EditProductViewModel>();
        collection.AddTransient<SalesOrdersViewModel>();
        collection.AddTransient<FakeOrderViewModel>();
        collection.AddTransient<IProductService, ProductServices>();
        collection.AddTransient<ICustomerService, CustomerServices>();
        collection.AddTransient<ISalesOrdersService, SalesOrderService>();

        collection.AddSingleton<Func<PageViewsEnum, ViewModelBase>>(c => name => name switch
        {
            PageViewsEnum.AddProduct => c.GetRequiredService<AddProductViewModel>(),
            PageViewsEnum.Home => c.GetRequiredService<HomeViewModel>(),
            PageViewsEnum.Customers => c.GetRequiredService<CustomersViewModel>(),
            PageViewsEnum.Products => c.GetRequiredService<ProductsViewModel>(),
            PageViewsEnum.EditProduct => c.GetRequiredService<EditProductViewModel>(),
            PageViewsEnum.SalesOrder => c.GetRequiredService<SalesOrdersViewModel>(),
            PageViewsEnum.FakeOrder => c.GetRequiredService<FakeOrderViewModel>(),
            _ => throw new InvalidOperationException()
        });
    }
}
