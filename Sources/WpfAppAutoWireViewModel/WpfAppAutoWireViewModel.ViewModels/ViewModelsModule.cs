using Autofac;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.ViewModels;
using WpfAppAutoWireViewModel.ViewModels.ViewModels;

namespace WpfAppAutoWireViewModel.ViewModels
{
    public class ViewModelsModule : Module
    {
        #region Methods
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainViewModel>().As<IMainViewModel>().SingleInstance();

            base.Load(builder);
        }
        #endregion
    }
}