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

    [RelayCommand]
    private void Edit(string id)
    {
        Console.WriteLine("Ändra uppgifter, " + id);
    }

    [RelayCommand]
    private void Delete(string id)
    {
        Console.WriteLine("Ta bort produkt, " + id);
    }

    private void LoadProducts()
    {
        try
        {
            var service = new ProductServices();
            Products = new ObservableCollection<Product>(service.List());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}





