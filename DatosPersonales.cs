namespace RRHH
{
    public class DatosPersonales{
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private string direccion;
        private char estadoCivil;
        private int cantidadHijos;
        private DateTime fechaDivorcio;
        private char tieneTituloUniversitario;
        private string titulo;
        private string universidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public int CantidadHijos { get => cantidadHijos; set => cantidadHijos = value; }
        public DateTime FechaDivorcio { get => fechaDivorcio; set => fechaDivorcio = value; }
        public char TieneTituloUniversitario { get => tieneTituloUniversitario; set => tieneTituloUniversitario = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Universidad { get => universidad; set => universidad = value; }

        public DatosPersonales () {}

        public DatosPersonales(string nombreEmpleado, string apellidoEmpleado, DateTime fechaNacimientoEmpleado, string direccionEmpleado, char estadoCivilEmpleado, int cantidadHijosEmpleado, DateTime fechaDivorcioEmpleado, char tieneTituloUniversitarioEmpleado, string tituloEmpleado, string universidadEmpleado){
            this.Nombre = nombreEmpleado;
            this.Apellido = apellidoEmpleado;
            this.FechaNacimiento = fechaNacimientoEmpleado;
            this.Direccion = direccionEmpleado;
            this.EstadoCivil = estadoCivilEmpleado;
            this.CantidadHijos = cantidadHijosEmpleado;
            this.fechaDivorcio = fechaDivorcioEmpleado;
            this.TieneTituloUniversitario = tieneTituloUniversitarioEmpleado;
            this.Titulo = tituloEmpleado;
            this.Universidad = universidadEmpleado;
        }
    }
}