namespace rtoasaS3online.Views;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuario = txtUsuarioRegistro.Text;
			string contrasena = txtContraenaRegistro.Text;
			Navigation.PushAsync(new vLogin(usuario, contrasena));
			DisplayAlert("Alerta", "Usuario registrado", "ok");

		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
    }
}