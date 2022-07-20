using System.Reflection;
using Autofac;

namespace WpfAppAutoWireViewModel.Startup
{
    public class Bootstrapper
    {
        #region Consts
        private const string ViewsAssembly = "WpfAppAutoWireViewModel.Views.dll";
        //private const string ViewModelsAssembly = "WpfAppViewModelFirst.ViewModels.dll";
        //private const string CustomizationAssembly = "WpfAppViewModelFirst.Customization.dll";
        #endregion

        #region Methods
        public IContainer Bootstrap()
        {
            ContainerBuilder builder = new ContainerBuilder();

            RegisterAssemblyModules(builder);
            return builder.Build();
        }

        private void RegisterAssemblyModules(ContainerBuilder builder)
        {
            foreach (string assembly in new string[]
            {
                ViewsAssembly,
                //ViewModelsAssembly,
                //CustomizationAssembly
            })
            {
                builder.RegisterAssemblyModules(Assembly.LoadFrom(assembly));
            }
        } 
        #endregion
    }
}