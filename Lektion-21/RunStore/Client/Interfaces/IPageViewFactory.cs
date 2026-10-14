using System;
using Client.Helpers;
using Client.ViewModels;

namespace Client.Interfaces;

public interface IPageViewFactory
{
    PageViewModel LoadPageViewModel(ApplicationNameEnum pageName);
}
