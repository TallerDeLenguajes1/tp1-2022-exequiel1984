namespace RRHH
{
    public class DatosPersonales{
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private string direccion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public DatosPersonales () {}

        public DatosPersonales(string nombreEmpleado, string apellidoEmpleado, DateTime fechaNacimientoEmpleado, string direccionEmpleado){
            this.Nombre = nombreEmpleado;
            this.Apellido = apellidoEmpleado;
            this.FechaNacimiento = fechaNacimientoEmpleado;
            this.Direccion = direccionEmpleado;
        }
    }
}