namespace WpfAppAutoWireViewModel.Infrastructure.Interfaces.Views.Base
{
    public interface IView
    {
        #region Properties
        object DataContext { get; set; } 
        #endregion
    }
}