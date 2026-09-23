namespace Relacion1E02_AlexVT
{
    internal class Usuario
    {
        public string nombre { get; private set; }
        public string apellidos { get; private set; }
        public int edad { get; private set; }

        public Usuario(string nombre, string apellidos, int edad) {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }

        public bool validarUsuario(string nombre, string apellidos, int edad) {
            try {
                if (validarNombre(nombre) && validarApellidos(apellidos) && validarEdad(edad))
                    return true;
                else
                    return false;
            }
            catch (Exception e) {
                throw new Exception($"Error: {e.Message}");
            }
        }

        public bool validarNombre(string nombre) {
            if (nombre == null) return false;

            bool esNombreValido = false;
            if (nombre.Length >= 3 && nombre.Length <= 20) {
                esNombreValido = true;
                //throw new Exception("El nombre debe tener entre 3 y 20 caracteres.");
            }
            return esNombreValido;
        }

        public bool validarApellidos(string apellidos) {
            if (apellidos == null) return false;
            bool esApellidosValido = false;
            if (apellidos.Length >= 4 && apellidos.Length <= 40) {
                esApellidosValido = true;
                //throw new Exception("Los apellidos deben tener entre 4 y 40 caracteres.");    
            }
            return esApellidosValido;
        }

        public bool validarEdad(int edad) {
            bool esEdadValida = false;
            if ((edad >= 5 || edad <= 70) && edad >= 18) {
                esEdadValida = true;
                //throw new Exception("La edad debe estar entre 5 y 70");
            }
            return esEdadValida;

            //if (edad < 18)
            //    throw new Exception("El usario debe ser mayor de edad para tener acceso");
        }
    }
}
