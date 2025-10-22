using System.Globalization;

namespace rtoasaS3online.Views;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string usuario, string contrasena)
	{
		InitializeComponent();
		txtUsuario.Text = "El usuario es "+ usuario;
		txtContrasena.Text ="La contraseña es "+ contrasena;
	}
}