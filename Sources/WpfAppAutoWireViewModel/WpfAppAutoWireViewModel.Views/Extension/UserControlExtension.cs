using Autofac;
using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace WpfAppAutoWireViewModel.Views.Extension
{
    public static class UserControlExtension
    {
        public static void AutoWireViewModel(this UserControl userControl, Type viewType, IComponentContext componentContext)
        {
            var assembly = Assembly.LoadFrom(@"WpfAppAutoWireViewModel.Infrastructure.dll");
            string viewTypeName = viewType.ToString();
            string viewModelTypeName = Regex.Replace(viewTypeName, @"\b[A-Z]\w+", delegate (Match match)
            {
                string part = match.ToString();
                return part.Contains("ViewModel") ? part : part.Replace("View", "ViewModel");
            });
            Type viewModelType = assembly.GetType(viewModelTypeName);
            if (viewModelType == null) return;
            userControl.DataContext = componentContext.Resolve(viewModelType);
        }
    }
}