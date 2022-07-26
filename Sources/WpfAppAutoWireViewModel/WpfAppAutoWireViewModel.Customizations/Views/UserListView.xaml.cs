﻿using System.Windows.Controls;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Views;

namespace WpfAppAutoWireViewModel.Customizations.Views
{
    /// <summary>
    /// Логика взаимодействия для UserListView.xaml
    /// </summary>
    public partial class UserListView : UserControl, IUserListView
    {
        #region Ctor
        public UserListView()
        {
            InitializeComponent();
        } 
        #endregion
    }
}
