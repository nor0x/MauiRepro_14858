namespace MauiNavigationFail;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		//this works
		//await Shell.Current.Navigation.PopModalAsync(true);
		
		//this does nothing
		await Shell.Current.GoToAsync("..");
    }
}