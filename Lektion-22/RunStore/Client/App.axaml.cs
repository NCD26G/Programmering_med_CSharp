using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Client.Interfaces;
using Client.Services;
using Client.ViewModels;
using Client.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Client;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        // Skapa en instans ServiceCollection...
        // En lista av beroende som applikation har eller kommer att ha...
        var collection = new ServiceCollection();
        // Om någon efterfrågar interface IProductService så ger
        // vi dem en instans av KalleAnka objektet...
        collection.AddSingleton<MainWindowViewModel>();
        collection.AddTransient<ProductsViewModel>();
        collection.AddTransient<IProductService, ProductServices>();

        // Bygga ihop services
        var serviceProvider = collection.BuildServiceProvider();

        var vm = serviceProvider.GetRequiredService<MainWindowViewModel>();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow()
            {
                // Kopplar på vår ViewModel till vår View
                DataContext = vm
                // DataContext = new MainWindowViewModel()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}