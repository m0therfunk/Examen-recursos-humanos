using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_recursosHumanos
{
    internal class Menu
    {
            public static void principal()
            {
                int opcion = 0;
                do
                {
                    Console.WriteLine("1- Inicializar arreglos");
                    Console.WriteLine("2- Ingresar empleado");
                    Console.WriteLine("3- Modificar empleado");
                    Console.WriteLine("4- Borrar empleado");
                    Console.WriteLine("5- Buscar empleado");
                    Console.WriteLine("6- Reportes");
                    Console.WriteLine("7- Salir");
                    Console.WriteLine("Digite una opcion");
                    opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                    {
                        case 1: empleados.inicializarArreglos(); break;
                        case 2: empleados.ingresarEmpleados(); break;
                        case 3: empleados.modificarEmpleados(); break;
                        case 4: empleados.excluirEmpleados(); break;
                        case 5: empleados.buscarEmpleados(); break;
                        case 6: empleados.Reportes(); break;
                        case 7: Console.WriteLine("Saliendo del sistema"); break;
                        default: Console.WriteLine("*** opcion incorrecta ***"); break;
                    }

                } while (opcion != 7);


            }
        }
    }

