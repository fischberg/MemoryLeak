namespace MemoryLeak;

public partial class DisplayObservableCollectionWithCV : ContentPage
{
    private readonly ObservableDataCollection vm;

	public DisplayObservableCollectionWithCV()
	{
        vm = new();
        InitializeComponent();
        BindingContext = vm;
	}

    public void RefreshCollection()
    {
        vm.RefreshCollection();
    }
}
