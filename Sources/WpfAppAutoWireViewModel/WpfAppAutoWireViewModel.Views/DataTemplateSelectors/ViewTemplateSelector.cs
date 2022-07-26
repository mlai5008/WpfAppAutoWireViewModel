using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppAutoWireViewModel.Views.DataTemplateSelectors
{
    public class ViewTemplateSelector : DataTemplateSelector
    {
        #region Methods
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement containerElement = container as FrameworkElement;

            if (null == item || null == containerElement)
                return base.SelectTemplate(item, container);

            Type itemType = item.GetType();

            IEnumerable<Type> dataTypes = Enumerable.Repeat(itemType, 1).Concat(itemType.GetInterfaces());

            DataTemplate template = dataTypes.Select(t => new DataTemplateKey(t))
                .Select(containerElement.TryFindResource)
                .OfType<DataTemplate>()
                .FirstOrDefault();

            return template ?? base.SelectTemplate(item, container);
        }
        #endregion
    }
}