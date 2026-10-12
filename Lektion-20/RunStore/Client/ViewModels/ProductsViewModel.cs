using System;
using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class ProductsViewModel : ViewModelBase
{
    private IProductService _service;

    [ObservableProperty]
    public partial ObservableCollection<Product> Products { get; set; } = [];
    public ProductsViewModel(IProductService service)
    {
        PageTitle = "Våra produkter";
        _service = service;
        LoadProducts();
    }

    // [RelayCommand]
    // private void Edit()
    // {
    //     Console.WriteLine("Ändra uppgifter");
    // }

    [RelayCommand]
    private void Delete()
    {
        Console.WriteLine("Ta bort produkt");
    }

    private void LoadProducts()
    {
        try
        {
            Products = new ObservableCollection<Product>(_service.List());
        }
        catch (Exception ex)
        {
            // Byts ut till en tjusig popup senare...
            Console.WriteLine(ex.Message);
        }
    }
}





