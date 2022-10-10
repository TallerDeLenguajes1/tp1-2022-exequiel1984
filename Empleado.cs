namespace RRHH
{
    public class Empleado
    {
        private DatosPersonales dataPersonal;
        private DatosProfesionales dataPro;
        private float sueldoBasico;

        public DatosPersonales DataPersonal { get => dataPersonal; set => dataPersonal = value; }
        public DatosProfesionales DataPro { get => dataPro; set => dataPro = value; }
        public float SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }

        public Empleado () {}

        public Empleado (DatosPersonales dataPersonalEmpleado, DatosProfesionales dataProEmpleado){
            this.DataPersonal = dataPersonalEmpleado;
            this.DataPro = dataProEmpleado;
            this.SueldoBasico = 50000;
        }

        public int CalcularAntiguedad()
        {
            int antiguedad = DateTime.Now.Year - DataPro.FechaIngreso.Year;

            if (DateTime.Now.Month < DataPro.FechaIngreso.Month ||(DateTime.Now.Month == DataPro.FechaIngreso.Month && DateTime.Now.Day < DataPro.FechaIngreso.Day))
            {
                antiguedad--;
            }

            return antiguedad;
        }

        public int CalcularEdad()
        {
            int edad = DateTime.Now.Year - DataPersonal.FechaNacimiento.Year;

            if (DateTime.Now.Month < DataPersonal.FechaNacimiento.Month ||(DateTime.Now.Month == DataPersonal.FechaNacimiento.Month && DateTime.Now.Day < DataPersonal.FechaNacimiento.Day))
            {
                edad--;
            }

            return edad;
        }

        public float CalcularSalario()
        {
            float PorcentajeAdicional = 0;
            float PorcentajeDescuento = 15;
            int Antiguedad = CalcularAntiguedad();
            if (Antiguedad > 20)
            {
                PorcentajeAdicional = 25;
            } else
            {
                PorcentajeAdicional = Antiguedad;
            }
    
            float Adicional = Antiguedad * PorcentajeAdicional / 100;
            float Descuento = SueldoBasico * PorcentajeDescuento / 100;
            float Salario = SueldoBasico + Adicional - Descuento;
            return Salario;
        }
    }
}