namespace Punto3
{
    public class DatosProfesionales{
        private DateTime fechaIngreso;
        private string puesto;

        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Puesto { get => puesto; set => puesto = value; }

        public DatosProfesionales () {}

        public DatosProfesionales(DateTime fechaIngresoEmpleado, string puestoEmpleado){
            this.FechaIngreso = fechaIngresoEmpleado;
            this.Puesto = puestoEmpleado;
        }
    }
}