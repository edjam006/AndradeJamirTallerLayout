namespace AndradeJamirTallerLayout.Views;

public partial class Test : ContentPage
{
	public Test()
	{
		InitializeComponent();
	}

    private void BtnCambiarPAgina_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}