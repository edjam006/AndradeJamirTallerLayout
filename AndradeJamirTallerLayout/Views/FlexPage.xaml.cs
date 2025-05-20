namespace AndradeJamirTallerLayout.Views;

public partial class FlexPage : ContentPage
{
	public FlexPage()
	{
		InitializeComponent();
	}

    private void IrAAbsolute_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsolutePage());
    }
}