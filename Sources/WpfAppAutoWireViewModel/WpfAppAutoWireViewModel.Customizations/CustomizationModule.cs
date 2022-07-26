using Autofac;
using WpfAppAutoWireViewModel.Customizations.ViewModels;
using WpfAppAutoWireViewModel.Customizations.Views;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.ViewModels;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Views;

namespace WpfAppAutoWireViewModel.Customizations
{
    public class CustomizationModule : Module
    {
        #region Methods
        protected override void Load(ContainerBuilder builder)
        {
            RegisterViewTypes(builder);
            RegisterViewModelTypes(builder);

            base.Load(builder);
        }

        private void RegisterViewTypes(ContainerBuilder builder)
        {
            builder.RegisterType<UserListView>().As<IUserListView>().SingleInstance();
            builder.RegisterType<UserDetailsView>().As<IUserDetailsView>().SingleInstance();
        }

        private void RegisterViewModelTypes(ContainerBuilder builder)
        {
            builder.RegisterType<UserListViewModel>().As<IUserListViewModel>().SingleInstance();
            builder.RegisterType<UserDetailsViewModel>().As<IUserDetailsViewModel>().SingleInstance();
        }
        #endregion
    }
}