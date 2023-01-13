using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace MauiAppICommandProblem;

public partial class NewContent1 : ContentView
{
	public NewContent1()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty SelectedDateCommandProperty = BindableProperty.Create(
propertyName: nameof(SelectedDateCommand),
returnType: typeof(ICommand),
declaringType: typeof(NewContent1));

    public ICommand SelectedDateCommand
    {
        get => (ICommand)GetValue(SelectedDateCommandProperty);
        set => SetValue(SelectedDateCommandProperty, value);
    }

    [RelayCommand]
	async Task TestAsync()
	{
		System.Diagnostics.Debug.WriteLine("TestCommand");

		if (SelectedDateCommand != null)
		{
			SelectedDateCommand?.Execute(DateTime.Now);
		}
		else
			await Shell.Current.DisplayAlert("ERROR", "COMMAND IS NULL", "Ok");
	}
}