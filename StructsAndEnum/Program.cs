using System;

namespace StructsAndEnum
    
{
    //tienes valores internos
    enum estaciones {primavera, verano, otono, invierno };

    enum bonus {bajo=500, normal=1000, bueno=1500, extra=2000};
    class Program
    {
        static void Main(string[] args)
        {
            //estaciones alergia = estaciones.primavera;
            //se usa el ? para trabajar con tipos enumarados para valores nulos
            //estaciones? NOalergia = null;
            //Su valor no es string por lo que hay que convertirlo
            //string LaAlergia = alergia.ToString;
            //Console.WriteLine(alergia);

            /*bonus aleatorio = bonus.bueno;
            //a esto se le llama cast que es para convertirlo a double lo mismo que tostring
            double bonusAntonio = (double)aleatorio;
            //Se puede usar los valores de los enum
            double salarioAntonio = 1500 + bonusAntonio;

            Console.WriteLine(salarioAntonio);*/

            empleado juan = new empleado(bonus.bueno, 1500);

            Console.WriteLine("el salario del empleado es " + juan.getSalario());

        }
    }
    class empleado
    {
        //se puede usar los enum como parametros enumerados
        public empleado(bonus bonusEmpleado, double salario)
        {
            bonus = (double)bonusEmpleado;

            this.salario = salario;
        }

        public double getSalario()
        {
            return salario + bonus;
        }

        private double salario, bonus;
    }
}
