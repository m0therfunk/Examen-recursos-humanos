using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_recursosHumanos
{
    internal class empleados
    {

        public static string[] cedula = new string[10]; //codigo del articulo
        public static string[] nombre = new string[10]; //nombre del articulo
        public static string[] direccion = new string[10]; //precio del articulo
        public static string[] telefono = new string[10]; //cantidad del articulo
        public static double[] salario = new double[10]; //bodega donde se guardara el articulo

        //metodo para inicializar arreglos
        public static void inicializarArreglos()
        {
            for (int i = 0; i < cedula.Length; i++)
            {
                cedula[i] = "";
                nombre[i] = "";
                direccion[i] = "";
                telefono[i] = "";
                salario[i] = 0;

            }
            Console.WriteLine("Los arreglos han sido inicializados");
            Console.Clear();


        }
        //metodo para ingresar articulos
        public static void ingresarEmpleados()
        {
            Console.Clear();
            int indice = 0;
            while (indice < cedula.Length)
            {
                Console.WriteLine("Digite la cedula: ");
                cedula[indice] = Console.ReadLine();
                Console.WriteLine("Digite el nombre del empleado: ");
                nombre[indice] = Console.ReadLine();
                Console.WriteLine("Digite su direccion: ");
                direccion[indice] = Console.ReadLine();
                Console.WriteLine("Digite su telefono: ");
                telefono[indice] = Console.ReadLine();
                Console.WriteLine("Digite su salario: ");
                salario[indice] = double.Parse(Console.ReadLine());
                indice++;
                Console.Clear();
            }
            Console.WriteLine("La informacion de los empleados ha sido ingresada");

        }
        //meotodo pra modificar productos
        public static void modificarEmpleados()
        {
            Console.Clear();
            Console.WriteLine("Digite la cedula del empleado que desea modificar: ");
            string nuevacedula = Console.ReadLine();
            for (int i = 0; i < cedula.Length; i++)
            {
                if (nuevacedula == cedula[i])
                {
                    Console.WriteLine($"Cedula: {cedula[i]} Nombre: {nombre[i]} Direccion: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]}");
                    Console.Write("Digite un nuevo nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.Write("Digite una nueva direccion: ");
                    direccion[i] = Console.ReadLine();
                    Console.Write("Digite el nuevo telefono: ");
                    telefono[i] = Console.ReadLine();
                    Console.Write("Digite un nuevo salario: ");
                    salario[i] = double.Parse(Console.ReadLine());
                    break;

                }
            }
        }
        //meotdo para consultar productos
        public static void consultarEmpleados()
        {
            Console.Clear();
            Console.WriteLine("*** Reporte de empleados ***");
            for (int i = 0; i < cedula.Length; i++)
            {
                Console.WriteLine($"Cedula: {cedula[i]} Nombre: {nombre[i]} Direccion: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]}");
            }
            Console.WriteLine("*** FIN DEL REPORTE ***");
        }
        //metodo para eliminar articulos
        public static void excluirEmpleados()
        {
            Console.Clear();
            Console.WriteLine("Digite la cedula del empleado que desea eliminar: ");
            string cedulaEliminar = Console.ReadLine();

            bool encontrado = false;
            for (int i = 0; i < cedula.Length; i++)
            {
                if (cedula[i] == cedulaEliminar)
                {
                    Console.WriteLine($"Empleado encontrado: Cedula: {cedula[i]} Nombre: {nombre[i]} Direccion: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]}");
                    Console.WriteLine("¿Está seguro que desea eliminar este empleado? (s/n)");
                    string confirmacion = Console.ReadLine();

                    if (confirmacion.ToLower() == "s")
                    {
                        // Eliminar el artículo
                        cedula[i] = "";  // O cualquier valor que indique que está vacío
                        nombre[i] = ""; // Eliminar el nombre
                        direccion[i] = "";
                        telefono[i] = "";
                        salario[i] = 0;

                        Console.WriteLine("El empleado ha sido eliminado.");
                    }
                    else
                    {
                        Console.WriteLine("Operación cancelada.");
                    }
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró un empleado con esa cedula.");
            }
        }
        public static void buscarEmpleados()
        {
            Console.Clear();
            Console.WriteLine("Digite la cedula del empleado que desea consultar: ");
            string cedulaSeleccionada = Console.ReadLine();
            for (int i = 0; i < cedula.Length; i++)
            {
                if (cedulaSeleccionada == cedula[i])
                {
                    Console.WriteLine($"Cedula: {cedula[i]} Nombre: {nombre[i]} Direccion: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]}");
                    break;

                }
                Console.WriteLine("*** DETALLES DEL EMPLEADO SELECCIONADO ***");
            }
        }

        public static void Reportes() 
        {
            Console.Clear();
            int opcion1 = 0;
            do {
                Console.WriteLine("1- Consultar empleados");
                Console.WriteLine("2- Mostrar promedio de los salarios");
                opcion1 = int.Parse(Console.ReadLine());

                switch (opcion1)
                {
                    case 1: empleados.consultarEmpleados(); break;
                    case 2: empleados.calcularPromedio(); break;

                }


            } while (opcion1 != 2);
        
        }
        public static void calcularPromedio() 
        {
            Console.Clear();

            double sumaSalarios = 0;
            int empleadosContados = 0; // Para contar los empleados que tienen salario

            // Sumar los salarios y contar empleados
            for (int i = 0; i < salario.Length; i++)
            {
                if (salario[i] > 0) // Verificamos que el salario no sea 0 (empleados no eliminados)
                {
                    sumaSalarios += salario[i];
                    empleadosContados++;
                }
            }

            if (empleadosContados > 0)
            {
                double promedio = sumaSalarios / empleadosContados;
                Console.WriteLine($"El promedio de los salarios es: {promedio}");
            }
            else
            {
                Console.WriteLine("No hay empleados con salario registrado.");
            }

        }
    }

}
