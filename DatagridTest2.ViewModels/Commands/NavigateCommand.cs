
using DatagridTest2.ViewModels;
using DatagridTest2.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatagridTest2.Commands
{
    public class NavigateCommand<TViewModel> : CommandBase
        where TViewModel : BaseViewModel
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _createViewModel;

        public NavigateCommand(NavigationStore navigationStore, Func<TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            if (_navigationStore.CurrentViewModel.GetType().ToString().Equals("DatagridTest.ViewModels.HomeViewModel"))
                ((HomeViewModel)_navigationStore.CurrentViewModel).dispose();
            _navigationStore.CurrentViewModel = _createViewModel();


        }
    }
}
