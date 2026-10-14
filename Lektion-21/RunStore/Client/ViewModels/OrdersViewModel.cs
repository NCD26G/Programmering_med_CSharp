using System;

namespace Client.ViewModels;

public class OrdersViewModel : PageViewModel
{
    public OrdersViewModel()
    {
        PageName = Helpers.ApplicationNameEnum.Customers;
    }
}
