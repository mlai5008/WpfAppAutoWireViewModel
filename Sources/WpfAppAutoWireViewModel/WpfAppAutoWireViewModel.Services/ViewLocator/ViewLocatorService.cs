using Autofac;
using System;
using System.Reflection;
using System.Text.RegularExpressions;
using WpfAppAutoWireViewModel.Infrastructure.Constants;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Services;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Views.Base;

namespace WpfAppAutoWireViewModel.Services.ViewLocator
{
    public class ViewLocatorService : IViewLocatorService
    {
        #region Fields
        private readonly IComponentContext _injectContainer; 
        #endregion

        #region Ctor
        public ViewLocatorService(IComponentContext componentContext)
        {
            _injectContainer = componentContext;
        } 
        #endregion

        #region Methods
        public T AutoWireViewModel<T>() where T : IView
        {
            Assembly assembly = Assembly.LoadFrom(AppProjectName.InfrastructureAssembly);
            Type typeV = typeof(T);
            string viewTypeName = typeV.ToString();
            string viewModelTypeName = Regex.Replace(viewTypeName, @"\b[A-Z]\w+", delegate (Match match)
            {
                string part = match.ToString();
                return part.Contains(ConstantNames.ViewModel) ? part : part.Replace(ConstantNames.View, ConstantNames.ViewModel);
            });
            Type viewModelType = assembly.GetType(viewModelTypeName);
            if (viewModelType == null) throw new Exception(ExceptionMessageConstants.ViewModelTypeNotFoundException);

            T view = _injectContainer.Resolve<T>();
            view.DataContext = _injectContainer.Resolve(viewModelType);
            return view;
        } 
        #endregion
    }
}