using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxPersonas;

            Console.Write("Ingrese el número máximo de personas: ");
            maxPersonas = int.Parse(Console.ReadLine());
            Console.WriteLine("======================================");
            Console.WriteLine("El número máximo establecido es de " + maxPersonas + " personas, presione una tecla para comenzar a contar");
            Console.ReadKey();
            Console.Clear();

            int AsisActuales = 0;
            int TIngresos = 0;
            int TSalidas = 0;
            int vecesLle = 0;
            int vecesVa = 0;

            char opcion; 

            do 
            {
                
                Console.Clear();
                Console.WriteLine("| Asistentes actuales | " + AsisActuales);
                Console.WriteLine("| Aforo               | " + (AsisActuales * 100 / maxPersonas) + "%");
                Console.WriteLine("| Maximo              | " + maxPersonas + " personas");
                Console.WriteLine("===========================");
                Console.WriteLine("[ i ] si ingresa una persona");
                Console.WriteLine("[ s ] si sale una persona");
                Console.WriteLine("[ x ] para terminar");

                opcion = Console.ReadKey().KeyChar;
                
                switch (opcion)
                {
                    case 'i':

                        if (AsisActuales < maxPersonas)
                        {
                            AsisActuales++;
                            TIngresos++;
                        }
                        else
                        {
                            Console.WriteLine("\nYa se alcanzó el aforo máximo de personas.");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case 's':

                        if (AsisActuales > 0)
                        {
                            AsisActuales--;
                            TSalidas++;
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay personas para sacar del local.");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;
                }
              
                if (AsisActuales == maxPersonas)
                {
                    vecesLle++;
                }

                if (AsisActuales == 0)
                {
                    vecesVa++;
                }

            } while (opcion != 'x');
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("El programa ha terminado");
            Console.WriteLine("=================================");
            Console.WriteLine("Estadísticas:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(TIngresos+ " personas ingresaron");
            Console.WriteLine(TSalidas + " personas salieron");
            Console.WriteLine(vecesLle + " veces se llenó el local");
            Console.WriteLine("Estuvo vacío " + vecesVa + " veces");
            Console.ReadKey();
        }
    }
}