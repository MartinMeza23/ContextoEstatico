using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextoEstatico
{
    class Program
    {
        static void Main(string[] args)
        {

            double sumando1 = 10;
            double sumando2 = 43;
            double resul =
                 
                Mate.sumar(sumando1, sumando2);

            Console.WriteLine(sumando1.ToString() + "+" + sumando2.ToString() + "=" + resul.ToString());
            Console.WriteLine("Pi: " + Mate.PI);
            //MATEMATICAS.PI = 95.36

            double radio = 3.67;
            
         
            Console.WriteLine("Radio : 5 , area =" + Mate.areaCirculo(5));
            Console.Read();

        }
    }
}
