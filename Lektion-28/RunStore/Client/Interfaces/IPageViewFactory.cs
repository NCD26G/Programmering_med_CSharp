using Client.Enums;
using Client.ViewModels;

namespace Client.Interfaces;

public interface IPageViewFactory
{
    ViewModelBase LoadPageViewModel(PageViewsEnum page);
}
