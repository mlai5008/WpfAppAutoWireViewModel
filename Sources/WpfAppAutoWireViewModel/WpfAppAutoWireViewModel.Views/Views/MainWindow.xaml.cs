using System.Windows;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Views;

namespace WpfAppAutoWireViewModel.Views.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindow
    {
        #region Ctor
        public MainWindow()
        {
            InitializeComponent();
        } 
        #endregion
    }
}
