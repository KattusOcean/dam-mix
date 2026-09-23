using Microsoft.Maui.Graphics.Platform;
using Microsoft.Maui.Platform;

namespace Relacion1E01_AlexVT
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /*
         * El método se encarga de validar si se han introducido datos ent todos lo
         * campos y si cumplen las características de longitud (nombre, apellidos) y
         * valor (edad).
         * 
         * En caso de que todo sea valido, se alterna la visibilidad de una etiqueta
         * mostrando el nombre completo del usuario junto con el mensaje: "Tiene acceso
         * al sistema".
         * 
         * En caso contrario, se mostrará el nombre completo del usuario junto al
         * mensaje: "No tiene acceso al sistema". Además, se indicarán los campos
         * erroneos en rojo.
         */
        private void bAccederClick(object sender, EventArgs e)
        {
            bool esNombreValido = false, esApellidosValido = false, esEdadValido = false;
            string nombre = eNombre.Text, apellidos = eApellidos.Text, resultado = lResultadoAcceso.Text;
            
            if (!Int32.TryParse(eEdad.Text, out int edad)) {
                eEdad.Text = "";
                eEdad.Placeholder = "La edad debe estar formada por números";
                eEdad.PlaceholderColor = Colors.Red;
                return;
            }

            if (nombre.Length >= 3 && nombre.Length <= 20) {
                esNombreValido = true;
                //nombre.ToTitleCase();
            
            } else {
                nombre = "";
                eNombre.Placeholder = "El nombre debe tener entre 3 y 20 caracteres";
                eNombre.PlaceholderColor = Colors.Red;
            }

            if (apellidos.Length >= 4 && apellidos.Length <= 40) {
                esApellidosValido = true;
                //apellidos.ToTitleCase();

            } else {
                apellidos = "";
                eApellidos.Placeholder = "Los apellidos deben tener entre 4 y 40 caracteres en total";
                eApellidos.PlaceholderColor = Colors.Red;
            }

            if ((edad >= 5 || edad <= 70) && edad >= 18) {
                esEdadValido = true;
            
            } else {
                eEdad.Text = "";
                eEdad.Placeholder = "La edad estar entre 5 y 70. Solo accederán los mayores de 18.";
                eEdad.PlaceholderColor = Colors.Red;
            }

            if (esNombreValido && esApellidosValido && esEdadValido) {
                //resultado = $"{apellidos}, {nombre}: Tiene acceso al sistema";
                lResultadoAcceso.Text = $"{apellidos}, {nombre}: Tiene acceso al sistema";
                lResultadoAcceso.TextColor = Colors.Green;

            } else {
                //resultado = $"{apellidos}, {nombre}: No tiene acceso al sistema";
                lResultadoAcceso.Text = $"{apellidos}, {nombre}: No tiene acceso al sistema";
                lResultadoAcceso.TextColor = Colors.Red;
            }
        }
    }
}
