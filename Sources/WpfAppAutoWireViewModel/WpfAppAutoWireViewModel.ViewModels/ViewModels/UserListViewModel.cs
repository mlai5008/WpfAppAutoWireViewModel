using System.Collections.ObjectModel;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.ViewModels;
using WpfAppAutoWireViewModel.Infrastructure.ViewModels.Base;

namespace WpfAppAutoWireViewModel.ViewModels.ViewModels
{
    public class UserListViewModel : BaseViewModel, IUserListViewModel
    {
        public UserListViewModel()
        {
            Users = new ObservableCollection<string>(){"A", "B"};
        }

        public ObservableCollection<string> Users { get; set; }

        public string TextA => "TextA";
    }
}