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
            builder.RegisterType<UserListViewModel>().As<IUserListViewModel>().SingleInstance();
            builder.RegisterType<UserDetailsViewModel>().As<IUserDetailsViewModel>().SingleInstance();

            base.Load(builder);
        }
        #endregion
    }
}