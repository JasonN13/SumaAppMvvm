namespace SumaAppMvvm;

public partial class Suma : ContentPage
{
	public Suma()
	{
		InitializeComponent();
	}
	private void OnButtonClicked(object sender, EventArgs e)
	{
        try
        {
            var Uno = double.Parse(Numero1.Text);
            var Dos = double.Parse(Numero2.Text);
            if (Dos != 0)
            {
                var SOLUCION = Uno + Dos;
                var Respuesta = SOLUCION.ToString();
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("ERROR", ex.Message, "Aceptar");
        }	
	}
    private void OnButtonlimpiar(object sender, EventArgs e)
    {
        Numero1.Text = string.Empty;
        Numero2.Text = string.Empty;
    }
}