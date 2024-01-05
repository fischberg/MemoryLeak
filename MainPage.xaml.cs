namespace MemoryLeak;

public partial class MainPage : ContentPage
{

    private static DisplayObservableCollectionWithCV Cp { get; set; }

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnButton1Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new DisplayWithCollectionView());
		GC.Collect();
	}

    private async void OnButton2Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DisplayNoCollectionView());
        GC.Collect();
    }

    private async void Button3_Clicked(System.Object sender, System.EventArgs e)
    {
        if (Cp == null)
            Cp = new();
        else
            Cp.RefreshCollection();

        await Navigation.PushAsync(Cp);
        GC.Collect();
    }
}