namespace AndradeJamirTallerLayout.Views;

public partial class StackPage : ContentPage
{
	public StackPage()
	{
		InitializeComponent();
	}

    private void IrAFlex_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexPage());
    }
}