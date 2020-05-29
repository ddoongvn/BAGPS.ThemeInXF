using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace BAGPS.ThemeInXF.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "BAGPS THEME";
            NavigationToCommand = new DelegateCommand(NavigationTo);
        }

        private void NavigationTo()
        {
            NavigationService.NavigateAsync("Theme");
        }
        public ICommand NavigationToCommand { get; }
    }
}
