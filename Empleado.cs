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

        public int CalcularAntiguedad()
        {
            int antiguedad = DateTime.Now.Year - DataPersonal.FechaIngreso.Year;

            if (DateTime.Now.Month < DataPersonal.FechaIngreso.Month ||(DateTime.Now.Month == DataPersonal.FechaIngreso.Month && DateTime.Now.Day < DataPersonal.FechaIngreso.Day))
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
            float Descuento = DataPro.SueldoBasico * PorcentajeDescuento / 100;
            float Salario = DataPro.SueldoBasico + Adicional - Descuento;
            return Salario;
        }
    }
}