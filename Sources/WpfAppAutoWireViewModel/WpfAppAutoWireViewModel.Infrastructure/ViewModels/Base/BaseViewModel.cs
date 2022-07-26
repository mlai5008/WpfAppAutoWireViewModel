using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.ViewModels.Base;

namespace WpfAppAutoWireViewModel.Infrastructure.ViewModels.Base
{
    public class BaseViewModel : IViewModel
    {
        #region Methods

        public bool SetField<TPropety>(ref TPropety field, TPropety newValue, string propertyName = null)
        {
            if (newValue == null && field == null) return false;

            if (field != null && field.Equals(newValue)) return false;

            field = newValue;
            OnPropertyChanged(propertyName);

            return true;
        }

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}