using System;
using System.Collections.ObjectModel;
using System.Linq;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class ProductsViewModel : PageViewModel
{
    private IProductService _service;

    [ObservableProperty]
    public partial ObservableCollection<Product> Products { get; set; } = [];

    public ProductsViewModel()
    {
        _service = new ProductServices();
        LoadProducts();
    }
    public ProductsViewModel(IProductService service)
    {
        PageTitle = "Våra produkter";
        _service = service;
        PageName = Helpers.ApplicationNameEnum.Products;
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
            Products = new ObservableCollection<Product>(_service.List());
        }
        catch (Exception ex)
        {
            // Byts ut till en tjusig popup senare...
            Console.WriteLine(ex.Message);
        }
    }
}





