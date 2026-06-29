//using EspacioFunciones;
using EspacioTarea;
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();
List<Tarea> tareasBuscadas = new List<Tarea>();
int opcion; bool valido;
int id = 1000;
string buff;
do
{

    do
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Presione 1 para agregar tareas pendientes.");
        Console.WriteLine("Presione 2 para marcar tareas pendientes como realizadas.");
        Console.WriteLine("Presione 3 para ver la lista de tareas pendientes.");
        Console.WriteLine("Presione 4 para ver la lista de tareas realizadas.");
        Console.WriteLine("Presione 5 para buscar una tarea pendiente.");
        Console.WriteLine("Presione 6 para salir.");
        valido = int.TryParse(Console.ReadLine(), out opcion);
        if (!valido || opcion < 1 || opcion > 6)
        {
            Console.WriteLine("Opcion invalida");
        }
    } while (!valido || opcion < 1 || opcion > 6);
    switch (opcion)
    {
        case 1:
            int cantTareas = Tarea.PedirCantidadDeTareasAlUsuario();
            Tarea.CargarTareas(cantTareas, tareasPendientes, ref id);
            break;
        case 2:
            Console.WriteLine("Ingrese la descripcion de la tarea realizada");
            buff = Console.ReadLine();
            Tarea.BuscarTareas(tareasPendientes, tareasBuscadas, buff);
            if (tareasBuscadas.Count > 0)
            {
                Tarea.MoverTareas(tareasPendientes, tareasRealizadas, tareasBuscadas);
                tareasBuscadas.Clear();
            }
            else
            {
                Console.WriteLine("El valor ingresado no corresponde a la descripcion de ninguna tarea pendiente");
            }
            break;
        case 3:
            Console.WriteLine("\tTAREAS PENDIENTES");
            Tarea.MostrarLista(tareasPendientes);
            break;
        case 4:
            Console.WriteLine("\tTAREAS REALIZADAS");
            Tarea.MostrarLista(tareasRealizadas);
            break;
        case 5:
            Console.WriteLine("Ingrese la descripcion de la tarea pendiente que quiere buscar");
            buff = Console.ReadLine();
            Tarea.BuscarTareas(tareasPendientes, tareasBuscadas, buff);
            if (tareasBuscadas.Count > 0)
            {
                Console.WriteLine("\tTAREAS PENDIENTES");
                Tarea.MostrarLista(tareasBuscadas);
                tareasBuscadas.Clear();
            }
            else
            {
                Console.WriteLine("El valor ingresado no corresponde a la descripcion de ninguna tarea pendiente");
            }
            break;
        case 6:
            Console.WriteLine("Gracias por usar nuestra aplicacion");
            break;
    }
} while (opcion != 6);
// Lista auxiliar para las tareas que se van a mover
// Buscar las tareas que contienen la descripción
// Mover las tareas encontradas
/*
for (int i = 0; i < tareasPendientes.Count; i++)
{
    if (tareasPendientes[i].Descripcion.Contains(buff))
    {
        tareasRealizadas.Add(new Tarea(tareasPendientes[i].TareaID, tareasPendientes[i].Descripcion, tareasPendientes[i].Duracion));
        tareasPendientes.RemoveAt(i);
    }
}
*/

/*
int PedirCantidadDeTareasAlUsuario()
{
    int cantidadDeTareas;
    bool valido;
    do
    {
        Console.WriteLine("Ingrese la cantidad de tareas pendientes que tiene");
        valido = int.TryParse(Console.ReadLine(), out cantidadDeTareas);
        if (!valido || cantidadDeTareas < 1)
        {
            Console.WriteLine("Valor invalido");
        }
    } while (!valido || cantidadDeTareas < 1);
    return cantidadDeTareas;
}
void CargarTareas(int cantidadDeTareas, List<Tarea> listaDeTareas, ref int ID)
{
    string buff; bool valido; int duracion;
    for (int i = 0; i < cantidadDeTareas; i++)
    {
        Console.WriteLine("Ingrese la descripcion de la tarea");
        buff = Console.ReadLine();
        do
        {
            Console.WriteLine("Ingrese la duracion de la tarea");
            valido = int.TryParse(Console.ReadLine(), out duracion);
            if (!valido || duracion < 10 || duracion > 100)
            {
                Console.WriteLine("Valor invalido");
            }
        } while (!valido || duracion < 10 || duracion > 100);
        listaDeTareas.Add(new Tarea(ID, buff, duracion));
        ID++;
    }
}
void MostrarLista(List<Tarea> listaDeTareas)
{
    foreach (Tarea tarea in listaDeTareas)
    {
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine($"Descripcion de la tarea {tarea.Descripcion}");
        Console.WriteLine($"Duracion de la tarea {tarea.Duracion}");
        Console.WriteLine($"ID de la tarea {tarea.TareaID}");
        Console.WriteLine("------------------------------------------------------------------");
    }
}
void BuscarTareas(List<Tarea> listaDeTareasBase, List<Tarea> listaDeTareasBuscada, string buscado)
{
    foreach (var tarea in listaDeTareasBase)
    {
        if (tarea.Descripcion.Contains(buscado))
        {
            listaDeTareasBuscada.Add(tarea);
        }
    }
}
void MoverTareas(List<Tarea> listaDeTareasQuitar, List<Tarea> listaDeTareasAgregar, List<Tarea> listaDeTareasAux)
{
    foreach (var tarea in listaDeTareasAux)
    {
        listaDeTareasAgregar.Add(tarea);
        listaDeTareasQuitar.Remove(tarea);
    }
}
*/
