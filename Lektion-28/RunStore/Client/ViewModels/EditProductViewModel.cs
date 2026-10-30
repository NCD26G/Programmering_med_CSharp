using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using Client.Helpers;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class EditProductViewModel : ViewModelBase
{
    private readonly IProductService? _productService;
    private string _itemNumber = string.Empty;
    private string _imageUrl = string.Empty;
    private string _objectId = string.Empty;

    [ObservableProperty]
    public partial string ItemNumber { get; set; } = string.Empty;
    [ObservableProperty]
    public partial string ProductName { get; set; } = string.Empty;
    [ObservableProperty]
    public partial string Supplier { get; set; } = string.Empty;
    [ObservableProperty]
    public partial int Price { get; set; }
    [ObservableProperty]
    public partial Bitmap? Image { get; set; } = null;

    public EditProductViewModel() { }

    public EditProductViewModel(IProductService productService)
    {
        _productService = productService;
        PageTitle = "Uppdatera produkt";
    }

    public async void Init(string itemNumber)
    {
        _itemNumber = itemNumber;
        await GetProduct();
    }

    private async Task GetProduct()
    {
        var product = await _productService!.Find(_itemNumber);

        _objectId = product._id;

        _imageUrl = string.IsNullOrEmpty(product.ImageUrl) ?
            "https://res.cloudinary.com/softtech-dev/image/upload/v1773483409/no-image_ymlpwk.png" : product.ImageUrl;

        ItemNumber = product.ItemNumber;
        ProductName = product.Name;
        Supplier = product.SupplierName;
        Price = product.Price;
        Image = await ImageHelper.ImageFromUrl(_imageUrl);

    }

    [RelayCommand]
    private async Task Save()
    {
        Product product = new()
        {
            ItemNumber = ItemNumber,
            Name = ProductName,
            SupplierName = Supplier,
            ImageUrl = _imageUrl,
            Description = "Uppdaterat produkten",
            Price = Price
        };

        await _productService!.Update(product, _objectId);
    }
}
