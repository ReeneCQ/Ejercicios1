using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1
{
    internal class DivisionCero
    {
        public static void Dividir(int dividendo, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                int resultado = dividendo / divisor;
                Console.WriteLine($"El resultado de la división es: {resultado}");
            }
            Console.ReadLine();
        }
    }
}
