using System.Windows.Controls;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Views;

namespace WpfAppAutoWireViewModel.Customizations.Views
{
    /// <summary>
    /// Логика взаимодействия для UserDetailsView.xaml
    /// </summary>
    public partial class UserDetailsView : UserControl, IUserDetailsView
    {
        #region Ctor
        public UserDetailsView()
        {
            InitializeComponent();
        } 
        #endregion
    }
}
