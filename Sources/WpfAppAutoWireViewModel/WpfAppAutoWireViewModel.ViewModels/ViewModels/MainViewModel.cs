using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Services;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.ViewModels;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Views;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Views.Base;
using WpfAppAutoWireViewModel.Infrastructure.ViewModels.Base;

namespace WpfAppAutoWireViewModel.ViewModels.ViewModels
{
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        #region Fields
        private IView _userListView;
        private IView _userDetailsView;
        #endregion

        #region Ctor
        public MainViewModel(IViewLocatorService viewLocatorService)
        {
            UserListView = viewLocatorService.AutoWireViewModel<IUserListView>();
            UserDetailsView = viewLocatorService.AutoWireViewModel<IUserDetailsView>();
        } 
        #endregion

        #region Properties
        public string Title => "WpfAppAutoWireViewModel";

        public IView UserListView
        {
            get => _userListView;
            set
            {
                if (_userListView != value)
                {
                    _userListView = value;
                    OnPropertyChanged();
                }
            }
        }

        public IView UserDetailsView
        {
            get => _userDetailsView;
            set
            {
                if (_userDetailsView != value)
                {
                    _userDetailsView = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
    }
}