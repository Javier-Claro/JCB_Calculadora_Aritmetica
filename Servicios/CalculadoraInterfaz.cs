using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Aritmetica.Servicios
{
    internal interface CalculadoraInterfaz
    {

        /// <summary>
        /// Método que muestra mensaje de bienvenida al cajero.
        /// </summary>
        public int mostrarMenu();


        /// <summary>
        /// Método que pide un número al usuario:
        /// </summary>
        /// <returns>un entero con la opción seleccionada</returns>
        public int numeroPantalla(string contador);

        /// <summary>
        /// Método que realiza una suma:
        /// </summary>
        /// <returns>un entero con la opción seleccionada</returns>
        public void suma(int num1, int num2);

        /// <summary>
        /// Método que realiza una resta:
        /// </summary>
        /// <returns>un entero con la opción seleccionada</returns>
        public void resta(int num1, int num2);

        /// <summary>
        /// Método que realiza una multlipicacion:
        /// </summary>
        /// <returns>un entero con la opción seleccionada</returns>
        public void multiplicacion(int num1, int num2);

        /// <summary>
        /// Método que realiza una division:
        /// </summary>
        /// <returns>un entero con la opción seleccionada</returns>
        public void division(int num1, int num2);
    }
}
