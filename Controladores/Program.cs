using Calculadora_Aritmetica.Servicios;
using System.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_Aritmetica
{

    /// <summary>
    /// Clase Principal de la aplicación
    /// </summary>
    class Program
    {


        static void Main(String[] args)
        {

            CalculadoraInterfaz calculo = new CalculadoraImplementacion();

            int num1, num2, opcionMenu;

            do
            {
                opcionMenu = calculo.mostrarMenu();

                switch (opcionMenu)
                {
                    case 1:
                        
                        break;

                    case 2:
                        num1 = calculo.numeroPantalla("primer");
                        num2 = calculo.numeroPantalla("segundo");
                        Console.Clear();

                        calculo.suma(num1, num2);
                        break;

                    case 3:
                        num1 = calculo.numeroPantalla("primer");                       
                        num2 = calculo.numeroPantalla("segundo");
                        Console.Clear();

                        calculo.resta(num1, num2);
                        break;

                    case 4:
                        num1 = calculo.numeroPantalla("primer");
                        num2 = calculo.numeroPantalla("segundo");
                        Console.Clear();

                        calculo.multiplicacion(num1, num2);
                        break;

                    case 5:
                        num1 = calculo.numeroPantalla("primer");
                        num2 = calculo.numeroPantalla("segundo");
                        Console.Clear();

                        calculo.division(num1, num2);
                        break;

                    default:
                        Console.Clear();

                        Console.WriteLine("[INFO] - La opción deseada no existe.");
                        break;
                }
            } while (opcionMenu != 1);
        }
    }
}