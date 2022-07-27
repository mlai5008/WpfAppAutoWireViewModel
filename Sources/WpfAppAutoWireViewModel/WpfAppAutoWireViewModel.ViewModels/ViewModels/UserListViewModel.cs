using System.Collections.ObjectModel;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.ViewModels;
using WpfAppAutoWireViewModel.Infrastructure.Models;
using WpfAppAutoWireViewModel.Infrastructure.ViewModels.Base;

namespace WpfAppAutoWireViewModel.ViewModels.ViewModels
{
    public class UserListViewModel : BaseViewModel, IUserListViewModel
    {
        #region Ctor
        public UserListViewModel()
        {
            Users = new ObservableCollection<User>()
            {
                new User(){Name = "Developer" , Age = 20},
                new User(){Name = "Project Manager", Age = 25}
            };
        } 
        #endregion

        #region Properties
        public ObservableCollection<User> Users { get; set; }
        #endregion
    }
}