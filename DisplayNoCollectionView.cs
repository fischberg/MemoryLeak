namespace MemoryLeak;

public class DisplayNoCollectionView : ContentPage
{
	public DisplayNoCollectionView()
	{
		var sv = new ScrollView();
		var vs = new VerticalStackLayout();
		var dataCollection = new DataCollection();

		foreach (var d in dataCollection.Collection)
		{
            vs.Add(new Label { Text = d.Title });
            vs.Add(new Label { Text = d.SubTitle });
			vs.Add(new Image { Source = "iron_white.png", HorizontalOptions=LayoutOptions.Start, WidthRequest=20, HeightRequest=30 });
			vs.Add(new BoxView { HeightRequest = 1, VerticalOptions = LayoutOptions.End });
        }
        Content = sv;
		sv.Content = vs;
    }
}
