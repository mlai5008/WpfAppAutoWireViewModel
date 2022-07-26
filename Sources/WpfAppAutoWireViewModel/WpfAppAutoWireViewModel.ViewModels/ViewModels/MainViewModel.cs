using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Services;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.ViewModels;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Views;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Views.Base;
using WpfAppAutoWireViewModel.Infrastructure.ViewModels.Base;

namespace WpfAppAutoWireViewModel.ViewModels.ViewModels
{
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        //private readonly IViewLocatorService _viewLocatorService;
        //private IUserListView _userListView;
        //private IUserDetailsView _userV;

        private IView _userDetailsView;
        private IView _userListView;

        public MainViewModel(/*IUserListView userListView, IUserDetailsView userDetails,*/ IViewLocatorService viewLocatorService)
        {
            //_viewLocatorService = viewLocatorService;
            //UserListView = userListView;
            //UserListView = new 

            //UserV = userDetails;
            //UserV

            //SetUserListViewView<IUserListView, IUserListViewModel>();
            //SetUserDetailsView<IUserDetailsView, IUserDetailsViewModel>();

            UserListView = viewLocatorService.AutoWireViewModel<IUserListView>();
            UserDetailsView = viewLocatorService.AutoWireViewModel<IUserDetailsView>();
        }

        #region Properties
        public string Title => "WpfAppAutoWireViewModel";

        //public IUserListView UserListView
        //{
        //    get => _userListView;
        //    set
        //    {
        //        _userListView = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public IUserDetailsView UserV
        //{
        //    get => _userV;
        //    set
        //    {
        //        _userV = value;
        //        OnPropertyChanged();
        //    }
        //}

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

        //private void SetUserListViewView<TView, TViewModel>() where TView : IView where TViewModel : IViewModel
        //{
        //    IView view = _viewLocatorService.GetView<TView>();
        //    UserListView = view;
        //    UserListView.DataContext = _viewLocatorService.GetViewModel<TViewModel>();
        //}

        //public void SetUserDetailsView<TView, TViewModel>() where TView : IView where TViewModel : IViewModel
        //{
        //    IView view = _viewLocatorService.GetView<TView>();
        //    UserDetails = view;
        //    UserDetails.DataContext = _viewLocatorService.GetViewModel<TViewModel>();
        //}
    }
}