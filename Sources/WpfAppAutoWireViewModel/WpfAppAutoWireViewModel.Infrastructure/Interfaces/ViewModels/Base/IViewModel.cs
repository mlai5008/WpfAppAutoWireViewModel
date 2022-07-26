using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfAppAutoWireViewModel.Infrastructure.Interfaces.ViewModels.Base
{
    public interface IViewModel : INotifyPropertyChanged
    {
        #region Methods
        /// <summary>
        /// Метод устанавливает значение поля свойства
        /// </summary>
        /// <typeparam name="TPropety"></typeparam>
        /// <param name="field"></param>
        /// <param name="newValue"></param>
        /// <param name="propertyName"></param>
        /// <returns>Показывает была ли произведена установка</returns>
        bool SetField<TPropety>(ref TPropety field, TPropety newValue, [CallerMemberName] string propertyName = null);

        /// <summary>
        /// Метод на событие <see cref="PropertyChanged"/>
        /// </summary>
        /// <param name="_propName"></param>
        void OnPropertyChanged([CallerMemberName] string propertyName = null);
        #endregion
    }
}