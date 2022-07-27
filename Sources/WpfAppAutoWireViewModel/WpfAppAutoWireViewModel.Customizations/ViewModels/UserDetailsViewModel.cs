using WpfAppAutoWireViewModel.Infrastructure.Interfaces.ViewModels;
using WpfAppAutoWireViewModel.Infrastructure.ViewModels.Base;

namespace WpfAppAutoWireViewModel.Customizations.ViewModels
{
    public class UserDetailsViewModel : BaseViewModel, IUserDetailsViewModel
    {
        #region Fields
        private string _details;
        #endregion

        #region Ctor
        public UserDetailsViewModel()
        {
            Details = "Details with Customization";
        }
        #endregion

        #region Properties
        public string Details
        {
            get => _details;
            set
            {
                _details = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}