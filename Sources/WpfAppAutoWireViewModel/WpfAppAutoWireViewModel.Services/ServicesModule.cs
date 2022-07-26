using Autofac;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Services;
using WpfAppAutoWireViewModel.Services.ViewLocator;

namespace WpfAppAutoWireViewModel.Services
{
    public class ServicesModule : Module
    {
        #region Methods
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ViewLocatorService>().As<IViewLocatorService>().SingleInstance();

            base.Load(builder);
        }
        #endregion
    }
}