using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string[,] Navegante = new string[4, 5];
        static void Main(string[] args)
        {
            int x;
            int y;
            string z;
            


            for (int b = 0; b < 5; b ++)
            {
                Console.WriteLine("Por favor ingrese su usuario");

                Console.WriteLine("Ingrese su nombre:");
                Navegante[0, b] = Console.ReadLine();

                Console.WriteLine("Ingrese su apellido:");
                Navegante[1, b] = Console.ReadLine();

                Console.WriteLine("Ingrese su telefono");
                Navegante[2, b] = Console.ReadLine();

                Console.WriteLine("Ingrese su dirección");
                Navegante[3, b] = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("1. Continuar.");
                Console.WriteLine("2. Salir");
                try
                {
                    x = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error, intente  de nuevo");
                    x = int.Parse(Console.ReadLine());
                }

                if (x == 1)
                {

                    break;
                }

                Console.Clear();
            }
                 Console.WriteLine("1. Para ver usuarios ");
                 Console.WriteLine("2. Buscar usuarios");
                 Console.WriteLine("3. Salir");
                 Console.WriteLine("¿Que desea hacer?");
            y = int.Parse(Console.ReadLine());
            if (y == 1)
                for (int b = 0; b ==5; b++)
                {
                    Console.WriteLine(" Nombre: " + Navegante[0, b] + " Apellido: " + Navegante[1, b] + " Dirección: " + Navegante[2, b] + " telefono: " + Navegante[3, b] + "\n");
               
                }

            while (y != 3)
            {
                if (y == 2)
                {
                    for (int b = 0; b < 1; b++)
                    {
                        Console.WriteLine("Ingrese el nombre para ver la información del usuario");
                        z = Console.ReadLine();
                        if (z == Navegante[0, b])
                        {
                            Console.WriteLine(" Nombre: " + Navegante[0, b] + " Apellido: " + Navegante[1, b] + " Dirección: " + Navegante[2, b] + " telefono: " + Navegante[3, b] );
                           
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("1. Para ver usuarios ");
                            Console.WriteLine("2. Buscar usuarios");
                            Console.WriteLine("3. Salir");
                            Console.WriteLine("¿Que desea hacer?");
                            try
                            {
                                y = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Error, intente de nuevo");
                                y = int.Parse(Console.ReadLine());
                            }



                        }





                    }


                }

            }
        }
    }
}

