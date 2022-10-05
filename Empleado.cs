namespace Punto3
{
    public class Empleado
    {
        private DatosPersonales dataPersonal;
        private DatosProfesionales dataPro;

        public DatosPersonales DataPersonal { get => dataPersonal; set => dataPersonal = value; }
        public DatosProfesionales DataPro { get => dataPro; set => dataPro = value; }

        public Empleado () {}

        public Empleado (DatosPersonales dataPersonalEmpleado, DatosProfesionales dataProEmpleado){
            this.DataPersonal = dataPersonalEmpleado;
            this.DataPro = dataProEmpleado;
        }

        public int CalcularAntiguedad(DateTime FechaIngreso)
        {
            int antiguedad = DateTime.Now.Year - FechaIngreso.Year;

            if (DateTime.Now.Month < FechaIngreso.Month ||(DateTime.Now.Month == FechaIngreso.Month && DateTime.Now.Day < FechaIngreso.Day))
            {
                antiguedad--;
            }

            return antiguedad;
        }








    }
}