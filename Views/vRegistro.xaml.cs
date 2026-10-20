namespace mguerronS3.Views;

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
			string usuarioNuevo = txtUsuarioNuevo.Text;
			string contrasenaNueva = txtContrasena.Text;
			Navigation.PushAsync(new vLogin(usuarioNuevo, contrasenaNueva));
			DisplayAlertAsync("Alerta", "UsuarioGuardado", "Cerrar");
		}
		catch (Exception )
		{

			throw;
		}
    }
}