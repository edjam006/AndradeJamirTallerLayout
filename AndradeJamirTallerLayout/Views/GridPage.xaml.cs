namespace AndradeJamirTallerLayout.Views;

public partial class GridPage : ContentPage
{
	public GridPage()
	{
		InitializeComponent();
	}


    private void IrAStack_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new StackPage());
    }
}