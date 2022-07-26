using Autofac;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Views;
using WpfAppAutoWireViewModel.Views.Views;

namespace WpfAppAutoWireViewModel.Views
{
    public class ViewsModule : Module
    {
        #region Methods
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainWindow>().As<IMainWindow>().SingleInstance();
            builder.RegisterType<UserListView>().As<IUserListView>().SingleInstance();
            builder.RegisterType<UserDetailsView>().As<IUserDetailsView>().SingleInstance();

            base.Load(builder);
        }
        #endregion
    }
}