using System.Collections.ObjectModel;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.ViewModels;
using WpfAppAutoWireViewModel.Infrastructure.ViewModels.Base;

namespace WpfAppAutoWireViewModel.ViewModels.ViewModels
{
    public class UserListViewModel : BaseViewModel, IUserListViewModel
    {
        #region Ctor
        public UserListViewModel()
        {
            Users = new ObservableCollection<string>() { "A", "B" };
        } 
        #endregion

        #region Properties
        public ObservableCollection<string> Users { get; set; }

        public string TextA => "TextA"; 
        #endregion
    }
}