using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfAppAutoWireViewModel.Infrastructure.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region Methods
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}