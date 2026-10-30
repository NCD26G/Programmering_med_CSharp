using System;
using Client.Enums;
using Client.Interfaces;
using Client.ViewModels;

namespace Client.Factories;

public class PageViewFactory : IPageViewFactory
{
    private readonly Func<PageViewsEnum, ViewModelBase> _pageFactory;
    public PageViewFactory(Func<PageViewsEnum, ViewModelBase> pageFactory)
    {
        _pageFactory = pageFactory;
    }

    public ViewModelBase LoadPageViewModel(PageViewsEnum page)
    {
        return _pageFactory.Invoke(page);
    }
}
