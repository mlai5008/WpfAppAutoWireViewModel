﻿using System.Windows.Controls;
using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Views;

namespace WpfAppAutoWireViewModel.Views.Views
{
    /// <summary>
    /// Логика взаимодействия для UserDetails.xaml
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