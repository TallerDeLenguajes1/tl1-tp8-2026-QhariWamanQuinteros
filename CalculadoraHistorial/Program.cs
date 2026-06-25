using EspacioCalculadora;
bool valido;
int opcion = 0;
double num1;
Calculadora calculadora = new Calculadora();
while (opcion != 6)
{
    Console.WriteLine(calculadora.Resultado);
    do
    {
        Console.WriteLine("Ingrese un numero");
        valido = double.TryParse(Console.ReadLine(), out num1);
        if (!valido)
        {
            Console.WriteLine("El valor no es valido");
        }
    } while (!valido);
    do
    {
        Console.WriteLine("Ingrese la operacion que desea realizar");
        Console.WriteLine("\t1. Sumar");
        Console.WriteLine("\t2. Restar");
        Console.WriteLine("\t3. Multiplicar");
        Console.WriteLine("\t4. Dividir");
        Console.WriteLine("\t5. Limpiar");
        Console.WriteLine("\t6. Salir");
        valido = int.TryParse(Console.ReadLine(), out opcion);
        if (!valido || (opcion < 1 || opcion > 6))
        {
            Console.WriteLine("El valor no es valido");
        }
    } while (!valido || (opcion < 1 || opcion > 6));
    switch (opcion)
    {
        case 1: calculadora.Sumar(num1); break;
        case 2: calculadora.Restar(num1); break;
        case 3: calculadora.Multiplicar(num1); break;
        case 4: calculadora.Dividir(num1); break;
        case 5: calculadora.Limpiar(); break;
        case 6: break;
    }
}