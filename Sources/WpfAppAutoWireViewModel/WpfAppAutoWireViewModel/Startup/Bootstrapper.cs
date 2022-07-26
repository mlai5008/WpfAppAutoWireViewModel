using Autofac;
using System.Reflection;
using WpfAppAutoWireViewModel.Infrastructure.Constants;

namespace WpfAppAutoWireViewModel.Startup
{
    public class Bootstrapper
    {
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
                AppProjectName.ViewsAssembly,
                AppProjectName.ViewModelsAssembly,
                AppProjectName.ServicesAssembly,
                //AppProjectName.CustomizationAssembly
            })
            {
                builder.RegisterAssemblyModules(Assembly.LoadFrom(assembly));
            }
        } 
        #endregion
    }
}