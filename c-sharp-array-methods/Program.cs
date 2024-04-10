//Suma de elementos pares en un arreglo
static void SumElementsPairs()
{
    Console.WriteLine("Ingresa los elementos separados por espacios:");
    string input = Console.ReadLine()!;
    string[] strArr = input.Split(' ');
    int[] arreglo = Array.ConvertAll(strArr, int.Parse);
    int suma = 0;
    foreach (int num in arreglo)
    {
        if (num % 2 == 0)
        {
            suma += num;
        }
    }
    Console.WriteLine("La suma de los pares en el arreglo es: " + suma);
}

//Invertir el orden de un arreglo
static void ReverseArray()
{
    Console.WriteLine("Ingrese los elementos separados por espacios:");
    string input = Console.ReadLine()!;
    string[] strArr = input.Split(' ');
    int[] arreglo = Array.ConvertAll(strArr, int.Parse);
    int[] arregloInvertido = new int[arreglo.Length];

    for (int i = 0; i < arreglo.Length; i++)
    {
        arregloInvertido[i] = arreglo[arreglo.Length - 1 - i];
    }

    Console.WriteLine("Arreglo original:");
    ImprimirArreglo(arreglo);

    Console.WriteLine("Arreglo invertido:");
    ImprimirArreglo(arregloInvertido);
}

static void ImprimirArreglo(int[] arr)
{
    foreach (int num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

//Encontrar el valor máximo en un arreglo
static void MaximumValueInArray()
{
    Console.WriteLine("Ingrese los elementos del arreglo separados por espacios:");
    string input = Console.ReadLine()!;
    string[] strArr = input.Split(' ');
    int[] arreglo = Array.ConvertAll(strArr, int.Parse);

    int maximo = arreglo[0];

    for (int i = 1; i < arreglo.Length; i++)
    {
        if (arreglo[i] > maximo)
        {
            maximo = arreglo[i];
        }
    }

    Console.WriteLine("El valor máximo en el arreglo es: " + maximo);
}

//Buscar un elemento en un arreglo
static void FindElementInArray()
{
    Console.WriteLine("Ingrese los elementos separados por espacios:");
    string input = Console.ReadLine()!;
    string[] strArr = input.Split(' ');
    int[] arreglo = Array.ConvertAll(strArr, int.Parse);

    Console.WriteLine("Ingrese el valor a buscar:");
    int valorABuscar = Convert.ToInt32(Console.ReadLine());

    int posicion = -1;

    for (int i = 0; i < arreglo.Length; i++)
    {
        if (arreglo[i] == valorABuscar)
        {
            posicion = i;
            break;
        }
    }

    if (posicion != -1)
    {
        Console.WriteLine($"El valor {valorABuscar} se encuentra en la posición {posicion} del arreglo.");
    }
    else
    {
        Console.WriteLine($"El valor {valorABuscar} no se encuentra en el arreglo. Error {posicion}");
    }
}

//Ordenar un arreglo de forma ascendente
static void SortArray()
{
    Console.WriteLine("Ingrese los elementos del arreglo separados por espacios:");
    string input = Console.ReadLine()!;
    string[] strArr = input.Split(' ');
    int[] arreglo = Array.ConvertAll(strArr, int.Parse);

    Array.Sort(arreglo);

    Console.WriteLine("Arreglo ordenado de forma ascendente:");
    ImprimirArreglo(arreglo);
}

//Crea un programa que solicite al usuario ingresar una lista de nombres y luego ordene los nombres
//alfabéticamente utilizando el método Array.Sort(). Finalmente, muestra la lista ordenada.
static void SortNamesAlphabetically()
{
    Console.WriteLine("Ingrese una lista de nombres separados por espacios:");
    string input = Console.ReadLine()!;
    string[] nombres = input.Split(' ');

    Array.Sort(nombres);

    Console.WriteLine("Lista de nombres ordenada:");
    foreach (string nombre in nombres)
    {
        Console.WriteLine(nombre);
    }
}

//Escribe un programa que pida al usuario ingresar una lista de números enteros. Luego, encuentra
//el valor máximo y el valor mínimo de la lista utilizando los métodos Array.Max() y Array.Min().
//Muestra los resultados al usuario.
static void FindMaximumAndMinimum()
{
    Console.WriteLine("Ingrese una lista de números enteros separados por espacios:");
    string input = Console.ReadLine()!;
    string[] strNumeros = input.Split(' ');

    int[] numeros = Array.ConvertAll(strNumeros, int.Parse);

    int maximo = numeros[0];
    int minimo = numeros[0];

    foreach (int num in numeros)
    {
        if (num > maximo)
        {
            maximo = num;
        }

        if (num < minimo)
        {
            minimo = num;
        }
    }

    Console.WriteLine($"El valor máximo en la lista es: {maximo}");
    Console.WriteLine($"El valor mínimo en la lista es: {minimo}");
}

//Crea un programa que declare un arreglo de strings con los nombres de algunos países. Luego,
//solicita al usuario ingresar un nombre de país y utiliza el método Array.IndexOf() para buscar si ese
//país se encuentra en el arreglo. Muestra un mensaje indicando si el país fue encontrado o no.
static void SearchCountryInArrangement()
{
    string[] paises = { "Argentina", "Brasil", "Chile", "Colombia", "Ecuador", "México", "Perú", "Uruguay", "Venezuela" };
    Console.WriteLine("Ingrese el nombre de un país:");
    string paisBuscado = Console.ReadLine()!;

    int indice = Array.IndexOf(paises, paisBuscado);

    if (indice != -1)
    {
        Console.WriteLine($"El país {paisBuscado} se encuentra en la posición {indice} del arreglo.");
    }
    else
    {
        Console.WriteLine($"El país {paisBuscado} no se encuentra en el arreglo.");
    }
}

//Escribe un programa que declare un arreglo de enteros y luego utilice el método Array.Reverse()
//para invertir el orden de los elementos. Muestra el arreglo original y el arreglo invertido.
static void ReverseArrayMethod()
{
    Console.WriteLine("Ingrese los elementos separados por espacios:");
    string input = Console.ReadLine()!;
    string[] strArr = input.Split(' ');
    int[] arreglo = Array.ConvertAll(strArr, int.Parse);

    Console.WriteLine("Arreglo original:");
    ImprimirArreglo(arreglo);

    Array.Reverse(arreglo);

    Console.WriteLine("Arreglo invertido:");
    ImprimirArreglo(arreglo);
}

//Crea un programa que solicite al usuario ingresar una lista de calificaciones numéricas. Luego,
//utiliza el método Array.Exists() para verificar si al menos una calificación es mayor o igual a 90
//(considerada sobresaliente). Muestra un mensaje indicando si hay calificaciones sobresalientes o
//no.
static void CheckRatingsOutstanding()
{
    Console.WriteLine("Ingrese una lista de calificaciones separadas por espacios:");
    string input = Console.ReadLine()!;
    string[] strCalificaciones = input.Split(' ');

    int[] calificaciones = Array.ConvertAll(strCalificaciones, int.Parse);

    bool haySobresalientes = Array.Exists(calificaciones, calificacion => calificacion >= 90);

    if (haySobresalientes)
    {
        Console.WriteLine("¡Hay calificaciones sobresalientes en la lista!");
    }
    else
    {
        Console.WriteLine("No hay calificaciones sobresalientes en la lista.");
    }
}


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
        Console.WriteLine("║ [5] Ejercicio 5           ║");
        Console.WriteLine("║ [6] Ejercicio 6           ║");
        Console.WriteLine("║ [7] Ejercicio 7           ║");
        Console.WriteLine("║ [8] Ejercicio 8           ║");
        Console.WriteLine("║ [9] Ejercicio 9           ║");
        Console.WriteLine("║ [10] Ejercicio 10         ║");
        Console.WriteLine("║ [0] Salir                 ║");
        Console.WriteLine("╚═══════════════════════════╝");

        opt = Convert.ToInt32(Console.ReadLine());

        switch (opt)
        {
            case 1:
                SumElementsPairs();
                break;
            case 2:
                ReverseArray();
                break;
            case 3:
                MaximumValueInArray();
                break;
            case 4:
                FindElementInArray();
                break;
            case 5:
                SortArray();
                break;
            case 6:
                SortNamesAlphabetically();
                break;
            case 7:
                FindMaximumAndMinimum();
                break;
            case 8:
                SearchCountryInArrangement();
                break;
            case 9:
                ReverseArrayMethod();
                break;
            case 10:
                CheckRatingsOutstanding();
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