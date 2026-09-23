namespace Relacion1E02_AlexVT
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void bAccederClick(object sender, EventArgs e)
        {
            string nombre = eNombre.Text;
            string apellidos = eApellidos.Text;

            //bool edadTransformada = Int32.TryParse(eEdad.Text, out int edad);
            if (!Int32.TryParse(eEdad.Text, out int edad)) {
                DisplayAlert("Edad no válida", "Introduzca una edad válida", "Ok");
                return;
            }

            try {
                Usuario usuario = new Usuario(nombre, apellidos, edad);

                if (usuario.validarUsuario(nombre, apellidos, edad))
                    DisplayAlert("Acceso aprobado", "Tiene acceso al sistema", "Ok");
                else
                    DisplayAlert("Acceso denegado", "No tiene acceso al sistema", "Ok");

            } catch (Exception ex) {
                DisplayAlert("Error", ex.Message, "Salir");
            }
        }
    }
}
