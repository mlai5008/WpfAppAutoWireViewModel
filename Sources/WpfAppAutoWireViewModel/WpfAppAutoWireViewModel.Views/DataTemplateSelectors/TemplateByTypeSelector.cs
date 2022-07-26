using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppAutoWireViewModel.Views.DataTemplateSelectors
{
    public class TemplateByTypeSelector : DataTemplateSelector
    {
        public TemplateByTypeSelector()
        {
            Templates = new ObservableCollection<TemplateForType>();
        }

        public ObservableCollection<TemplateForType> Templates { get; set; }

        public DataTemplate TemplateForNullItem { get; set; }

        //internal DataTemplate SelectValue(object item, DependencyObject obj)
        //{
        //    if (item == null)
        //        return NullIfSpecified;

        //    return FindSingleTValueFor(item);
        //}

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null)
                //return NullIfSpecified;
                return base.SelectTemplate(item, container);

            return FindSingleTValueFor(item);
        }

        private DataTemplate FindSingleTValueFor(object item)
        {
            var type = item.GetType();
            var possibleTypes = Templates.Where(mapping => mapping.Type.IsAssignableFrom(type)).ToList();
            if (possibleTypes.Count > 1)
            {
                var typeNames = string.Join(", ", possibleTypes.Select(t => t.Type.Name));
                var errorMessage =
                    string.Format(
                        "Item '{0}' can be mapped to multiple types, please specify type TValue mapping more distinctly: " +
                        typeNames, type.Name);
                throw new InvalidOperationException(errorMessage);
            }

            if (possibleTypes.Count == 0)
                throw new InvalidOperationException("No type mapping found for: " + type.Name);

            var rfff = possibleTypes[0].DataTemplate;
            return possibleTypes[0].DataTemplate;
        }

        protected DataTemplate NullIfSpecified
        {
            get
            {
                if (TemplateForNullItem == null)
                    throw new Exception("TemplateForNullItem is not specified");

                return TemplateForNullItem;
            }
        }
    }

    public class TemplateForType
    {
        public Type Type { get; set; }
        public DataTemplate DataTemplate { get; set; }
    }
}