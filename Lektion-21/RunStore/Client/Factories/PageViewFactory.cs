using System;
using Client.Helpers;
using Client.Interfaces;
using Client.ViewModels;

namespace Client.Factories;

public class PageViewFactory(Func<ApplicationNameEnum, PageViewModel> pageFactory) : IPageViewFactory
{
    public PageViewModel LoadPageViewModel(ApplicationNameEnum pageName) => pageFactory.Invoke(pageName);
}
