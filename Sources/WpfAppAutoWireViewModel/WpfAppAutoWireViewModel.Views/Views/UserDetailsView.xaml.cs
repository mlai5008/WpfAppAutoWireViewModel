using Autofac;
using System.Windows.Controls;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Views;
using WpfAppAutoWireViewModel.Views.Extension;

namespace WpfAppAutoWireViewModel.Views.Views
{
    /// <summary>
    /// Логика взаимодействия для UserDetails.xaml
    /// </summary>
    public partial class UserDetailsView : UserControl, IUserDetailsView
    {
        public UserDetailsView()
        {
            InitializeComponent();
        }

        //public UserDetails(IComponentContext componentContext)
        //{
        //    this.AutoWireViewModel(typeof(IUserDetailsView), componentContext);
        //}
    }
}
