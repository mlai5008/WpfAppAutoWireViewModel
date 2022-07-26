using WpfAppAutoWireViewModel.Infrastructure.Interfaces.ViewModels;
using WpfAppAutoWireViewModel.Infrastructure.ViewModels.Base;

namespace WpfAppAutoWireViewModel.ViewModels.ViewModels
{
    public class UserDetailsViewModel : BaseViewModel, IUserDetailsViewModel
    {
        private string _details;

        public UserDetailsViewModel()
        {
            Details = "Details";
        }

        public string Details
        {
            get => _details;
            set
            {
                _details = value;
                OnPropertyChanged();
            }
        }
    }
}