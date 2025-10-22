using System.Transactions;

namespace rtoasaS3online.Views;

public partial class vLogin : ContentPage
{
    string usuario = " ";
    string contrasena = " ";
    public vLogin()
	{
		InitializeComponent();
	}

    //renato  123
    public vLogin(string usuarioregistro, string contrasenaregistro)
    {
        InitializeComponent();
        usuario = usuarioregistro; //renato
        contrasena = contrasenaregistro;//123
    }

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        try
        {
            string usuarioIngresado = txtUsuario.Text;
            string contrasenaIngresada = txtContrasena.Text;
            if(usuario == usuarioIngresado && contrasena==contrasenaIngresada)
            {
                Navigation.PushAsync(new vPrincipal(usuario, contrasena));//Abre principal
            }
            else
            {
                DisplayAlert("Alerta", "Usuario/Contrasena incorrectos", "Cerrar");

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR "+ ex.Message);
            
        }
       
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());//abre registro
    }
}