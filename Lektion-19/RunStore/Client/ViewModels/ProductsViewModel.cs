using System;
using System.Collections.ObjectModel;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class ProductsViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial ObservableCollection<Product> Products { get; set; } = [];
    public ProductsViewModel()
    {
        PageTitle = "Våra produkter";
        LoadProducts();
    }

    // [RelayCommand]
    // private void Edit()
    // {
    //     Console.WriteLine("Ändra uppgifter");
    // }

    // [RelayCommand]
    // private void Delete()
    // {
    //     Console.WriteLine("Ta bort produkt");
    // }

    private void LoadProducts()
    {
        try
        {
            Products = new ObservableCollection<Product>(ProductServices.ListAllProducts());
        }
        catch (Exception ex)
        {
            // Byts ut till en tjusig popup senare...
            Console.WriteLine(ex.Message);
        }

    }
}
