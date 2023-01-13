using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiAppICommandProblem
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        bool isPanelVisible;

        public MainViewModel()
        {

        }

        [RelayCommand]
        private async Task MySelectedAsync(DateTime dateTime)
        {
            await Shell.Current.GoToAsync(nameof(TestPage));
        }

        [RelayCommand]
        private void SwitchPanel()
        {
            IsPanelVisible = !IsPanelVisible;
        }

    }
}
