using WpfAppAutoWireViewModel.Infrastructure.Interfaces.ViewModels;
using WpfAppAutoWireViewModel.Infrastructure.ViewModels.Base;

namespace WpfAppAutoWireViewModel.ViewModels.ViewModels
{
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        #region Properties
        public string Title => "WpfAppAutoWireViewModel"; 
        #endregion
    }
}