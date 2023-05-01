namespace MauiNavigationFail;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}


    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
		await Task.Delay(3000);

		//this works
		//await Shell.Current.Navigation.PushModalAsync(new NewPage1(), true);

		//fails on goback from NewPage1
		await Shell.Current.GoToAsync("///NewPage");
    }
}

