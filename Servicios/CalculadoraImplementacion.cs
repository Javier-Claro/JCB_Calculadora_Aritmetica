using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Aritmetica.Servicios
{
    internal class CalculadoraImplementacion : CalculadoraInterfaz
    {
        public int mostrarMenu()
        {
            int opcionEntrada;

            Console.WriteLine("\n\t########################################");
            Console.WriteLine("\n\t1: Cerrar app");
            Console.WriteLine("\n\t2: Suma");
            Console.WriteLine("\n\t3: Resta");
            Console.WriteLine("\n\t4: Multiplicacion");
            Console.WriteLine("\n\t5: Division");
            Console.WriteLine("\n\t########################################");
            Console.WriteLine("\n\tSeleccione una opción:");

            opcionEntrada = Console.ReadKey(true).KeyChar - ('0');

            return opcionEntrada;
        }

        //El string "contador", nos servirá para cuando lo escribamos por pantalla, nos sea más facil el distinguir el primer número del segundo:
        public int numeroPantalla(string contador) {
            Console.Write("\n\tIndique el {0} número para realizar la opreación: ", contador);
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        public void suma(int num1, int num2) {

            int resultado = num1 + num2;
            Console.WriteLine("\n\t[INFO] - El resultado de la suma de {0} y {1} es: {2}.", num1, num2, resultado);
        }

        public void resta(int num1, int num2) {
            int resultado = num1 - num2;
            Console.WriteLine("\n\t[INFO] - El resultado de la resta de {0} y {1} es: {2}.", num1, num2, resultado);
        }

        public void multiplicacion(int num1, int num2) {
            int resultado = num1 * num2;
            Console.WriteLine("\n\t[INFO] - El resultado de la multiplicacion de {0} y {1} es: {2}.", num1, num2, resultado);
        }

        public void division(int num1, int num2) {
            int resultado = num1 / num2;
            Console.WriteLine("\n\t[INFO] - El resultado de la division de {0} y {1} es: {2}.", num1, num2, resultado);
        }
    }
}
