namespace AndradeJamirTallerLayout.Views;

public partial class AbsolutePage : ContentPage
{
	public AbsolutePage()
	{
		InitializeComponent();
	}

    private void IrAMain_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}