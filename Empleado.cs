namespace RRHH
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

        public int CalcularEdad(DateTime FechaNacimiento)
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;

            if (DateTime.Now.Month < FechaNacimiento.Month ||(DateTime.Now.Month == FechaNacimiento.Month && DateTime.Now.Day < FechaNacimiento.Day))
            {
                edad--;
            }

            return edad;
        }

        public float CalcularSalario(float SueldoBasico, int Antiguedad)
        {
            float PorcentajeAdicional = 1;
            float PorcentajeDescuento = 15;
            float Adicional = Antiguedad * PorcentajeAdicional / 100;
            float Descuento = SueldoBasico * PorcentajeDescuento / 100;
            float Salario = SueldoBasico + Adicional - Descuento;
            return Salario;
        }




    }
}