namespace MauiAppICommandProblem;

public partial class TestPage : ContentPage
{
	public TestPage(TestViewModel testViewModel)
	{
		InitializeComponent();
		BindingContext = testViewModel;
	}
}