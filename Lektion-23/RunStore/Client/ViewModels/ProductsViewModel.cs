using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class ProductsViewModel : ViewModelBase
{
    private readonly IProductService _productService;

    [ObservableProperty]
    public partial ObservableCollection<Product> Products { get; set; } = [];

    public ProductsViewModel()
    {
        _productService = new ProductServices();
        PageTitle = "Våra produkter";
        Init();
    }
    public ProductsViewModel(IProductService productService)
    {
        _productService = productService;
        PageTitle = "Våra produkter";

        // Task.Run(()=> LoadProducts()).Wait();
        Init();
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

    private async void Init()
    {
        await LoadProducts();
    }

    private async Task LoadProducts()
    {
        try
        {
            Products = new ObservableCollection<Product>(await _productService.List());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}





