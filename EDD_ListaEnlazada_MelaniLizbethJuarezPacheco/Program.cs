internal class Program
{
    private static void Main(string[] args)
    {
        /* 
         1. Agregar
         2. Insertar
         3. Eliminar
4. Cambiar
5. Mostrar Lista
6. Llenar Aleatoriamente
7. Obtener Pares
8. Obtener Primos
9. Búsqueda Secuencial
10. Búsqueda Mejorada
11. Buscar Todos
12. Ordenamiento Burbuja
13. Ordenamiento Selección
14. Ordenamiento Inserción
15. Salir

         */
        string opcion;
        Console.WriteLine("Ingrese una opción: ");
        do
        {
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Agregar");
                    break;
                case "2":
                    Console.WriteLine("Insertar");
                    break;
                case "3":
                    Console.WriteLine("Eliminar");
                    break;
                case "4":
                    Console.WriteLine("Cambiar");
                    break;
                case "5":
                    Console.WriteLine("Mostrar Lista");
                    break;
                case "6":
                    Console.WriteLine("Llenar Aleatoriamente");
                    break;
                case "7":
                    Console.WriteLine("Obtener Pares");
                    break;
                case "8":
                    Console.WriteLine("Obtener Primos");
                    break;
                case "9":
                    Console.WriteLine("Busqueda Secuencial");
                    break;
                case "10":
                    Console.WriteLine("Busqueda Mejorada");
                    break;
                case "11":
                    Console.WriteLine("Buscar Todos");
                    break;
                case "12":
                    Console.WriteLine("Ordenamiento Burbuja");
                    break;
                case "13":
                    Console.WriteLine("Ordenamiento Selección");
                    break;
                case "14":
                    Console.WriteLine("Ordenamiento Inserción");
                    break;
                case "15":
                    Console.WriteLine("Salir");
                    break;
            }
        } while (opcion != "15");
    }
}