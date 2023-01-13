using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppICommandProblem
{
    public partial class TestViewModel : ObservableObject
    {

        [RelayCommand]
        private void MySelected(DateTime dateTime)
        {
            if (dateTime != null)
                System.Diagnostics.Debug.WriteLine(dateTime.ToString(), "MySelectedCommand");

        }
    }
}
