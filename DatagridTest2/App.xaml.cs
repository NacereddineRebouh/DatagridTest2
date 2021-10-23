using DatagridTest2.Commands;
using DatagridTest2.ViewModels;
using DatagridTest2.ViewModels.Stores;
using Startup;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DatagridTest2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        NavigationStore navigationStore;
        SideMenuViewModel sideMenuViewModel;

        protected override void OnStartup(StartupEventArgs e)
        {
            navigationStore = new NavigationStore();
            sideMenuViewModel = new SideMenuViewModel(createHomeNavigateCommand(), createUsersNavigateCommand());

            navigationStore.CurrentViewModel = new HomeViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(sideMenuViewModel, navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        private NavigateCommand<UsersViewModel> createUsersNavigateCommand()
        {
            return new NavigateCommand<UsersViewModel>(navigationStore, () => new UsersViewModel());
        }

        private NavigateCommand<HomeViewModel> createHomeNavigateCommand()
        {
            return new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel());
        }
    }
}
