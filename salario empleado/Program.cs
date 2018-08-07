using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Nombre del Autor: Mauricio Mejia Estevez
//Fecha: 10  Noviembre 2016
//Doy fe que este ejercicio es de mi autoría, en caso de encontrar plagio la nota de todo mi
//trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar
//4.En una organización se tiene a los empleados agrupados por categoría, los de categoría 1 ganan 
//$20.000, los de categoría 2, $15.000, los de categoría 3, $10.000 y los de categoría 4, $7.500.Se 
//quiere un algoritmo que permita determinar cuánto debe pagarse a un empleado si se conoce el número 
//de horas que trabajó durante el mes y la categoría a la que pertenece.Se sabe que a todos se les 
//descuenta un 7.2 % por concepto de salud, y si el salario total devengado (mensual)es menos de 1 ´000.000, 
//se le da un subsidio del 15 % sobre su salario mensual(sin descuentos).



namespace salario_empleado
{
    class Program
    {
        static void Main(string[] args)
        {
            int categoria;
            double alm;
            int horas;

            Opcion:
            Console.WriteLine("Categoria del empleado: ");
            Console.WriteLine();
            Console.WriteLine("[1]. Categoria A1");
            Console.WriteLine("[2]. Categoria B2");
            Console.WriteLine("[3]. Categoria C3");
            Console.WriteLine("[4]. Categoria D4");
            Console.WriteLine();
            Console.WriteLine("Selecciona opción:");
            categoria = int.Parse(Console.ReadLine());

            switch (categoria)
            {
                case 1:
                    alm = 20000;
                    break;
                case 2:
                    alm = 15000;
                    break;
                case 3:
                    alm = 10000;
                    break;
                case 4:
                    alm = 7500;
                    break;
                default:
                    Console.WriteLine("Error!. categoria no válida.");
                    goto Opcion;
            }

            Console.WriteLine("Ingrese el numero de horas trabajadas por el empleado:");
            horas = int.Parse(Console.ReadLine());

            double salario = (alm * horas) - (0.072 * (alm * horas));

            if (salario < 1000000)
                salario = salario + 0.15 * (alm * horas);

            Console.WriteLine("El pago al empleado debe ser: " + salario);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar... ");
            Console.ReadKey();
        }
    }
}
