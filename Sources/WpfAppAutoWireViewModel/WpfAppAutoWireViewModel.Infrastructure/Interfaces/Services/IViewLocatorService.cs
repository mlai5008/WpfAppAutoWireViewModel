using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Views.Base;

namespace WpfAppAutoWireViewModel.Infrastructure.Interfaces.Services
{
    public interface IViewLocatorService
    {
        #region Methods
        public T AutoWireViewModel<T>() where T : IView;
        #endregion
    }
}