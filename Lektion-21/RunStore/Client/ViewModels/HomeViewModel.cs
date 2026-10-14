using System;

namespace Client.ViewModels;

public class HomeViewModel : PageViewModel
{
    public HomeViewModel()
    {
        PageName = Helpers.ApplicationNameEnum.Home;
    }
}
