using System;
using System.Collections.ObjectModel;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

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
