using System.Collections.ObjectModel;
using WpfAppAutoWireViewModel.Customizations.Models;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.ViewModels;
using WpfAppAutoWireViewModel.Infrastructure.ViewModels.Base;

namespace WpfAppAutoWireViewModel.Customizations.ViewModels
{
    public class UserListViewModel : BaseViewModel, IUserListViewModel
    {
        #region Ctor
        public UserListViewModel()
        {
            Users = new ObservableCollection<User>()
            {
                new User(){Name = "Tester", Age = 20, Company = "Apple"},
                new User(){Name = "DevOp", Age = 24, Company = "Goggle"},
            };
        }
        #endregion

        #region Properties
        public ObservableCollection<User> Users { get; set; }
        #endregion
    }
}