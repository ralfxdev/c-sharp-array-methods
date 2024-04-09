//Menú
int opt = 0;

do
{
    try
    {
        Console.WriteLine("╔═══════════════════════════╗");
        Console.WriteLine("║            Menú           ║");
        Console.WriteLine("╠═══════════════════════════╣");
        Console.WriteLine("║ [1] Ejercicio 1           ║");
        Console.WriteLine("║ [2] Ejercicio 2           ║");
        Console.WriteLine("║ [3] Ejercicio 3           ║");
        Console.WriteLine("║ [4] Ejercicio 4           ║");
        Console.WriteLine("║ [5] Ejercicio 4           ║");
        Console.WriteLine("║ [6] Ejercicio 4           ║");
        Console.WriteLine("║ [7] Ejercicio 4           ║");
        Console.WriteLine("║ [8] Ejercicio 4           ║");
        Console.WriteLine("║ [9] Ejercicio 4           ║");
        Console.WriteLine("║ [10] Ejercicio 4           ║");
        Console.WriteLine("║ [0] Salir                 ║");
        Console.WriteLine("╚═══════════════════════════╝");

        opt = Convert.ToInt32(Console.ReadLine());

        switch (opt)
        {
            case 1:
                Console.WriteLine("Ejercicio #1");
                break;
            case 2:
                Console.WriteLine("Ejercicio #2");
                break;
            case 3:
                Console.WriteLine("Ejercicio #3");
                break;
            case 4:
                Console.WriteLine("Ejercicio #4");
                break;
            case 5:
                Console.WriteLine("Ejercicio #5");
                break;
            case 6:
                Console.WriteLine("Ejercicio #6");
                break;
            case 7:
                Console.WriteLine("Ejercicio #7");
                break;
            case 8:
                Console.WriteLine("Ejercicio #8");
                break;
            case 9:
                Console.WriteLine("Ejercicio #9");
                break;
            case 10:
                Console.WriteLine("Ejercicio #10");
                break;
            case 0:
                Console.WriteLine("Saliendo del programa.");
                break;
            default:
                Console.WriteLine("No es una opción válida");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada no válida. Intente nuevamente.");
    }

} while (opt != 0);