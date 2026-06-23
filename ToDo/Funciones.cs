namespace EspacioFunciones
{
    using EspacioTarea;
    public class Funciones
    {
        public static int PedirCantidadDeTareasAlUsuario()
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
                    Console.WriteLine("--------------------------");
                }
            } while (!valido || cantidadDeTareas < 1);
            return cantidadDeTareas;
        }
        public static void CargarTareas(int cantidadDeTareas, List<Tarea> listaDeTareas, ref int ID)
        {
            string buff; bool valido; int duracion;
            for (int i = 0; i < cantidadDeTareas; i++)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Ingrese la descripcion de la tarea");
                buff = Console.ReadLine();
                do
                {
                    Console.WriteLine("Ingrese la duracion de la tarea");
                    valido = int.TryParse(Console.ReadLine(), out duracion);
                    if (!valido || duracion < 10 || duracion > 100)
                    {
                        Console.WriteLine("Valor invalido");
                        Console.WriteLine("--------------------------");
                    }
                } while (!valido || duracion < 10 || duracion > 100);
                listaDeTareas.Add(new Tarea(ID, buff, duracion));
                ID++;
            }
        }
        public static void MostrarLista(List<Tarea> listaDeTareas)
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
        public static void BuscarTareas(List<Tarea> listaDeTareasBase, List<Tarea> listaDeTareasBuscada, string buscado)
        {
            foreach (Tarea tarea in listaDeTareasBase)
            {
                //if (tarea.Descripcion.Trim().ToLower() == buscado.Trim().ToLower())
                if (tarea.Descripcion.Trim().ToLower().Contains(buscado.Trim().ToLower()))
                {
                    listaDeTareasBuscada.Add(tarea);
                }
            }
        }
        public static void MoverTareas(List<Tarea> listaDeTareasQuitar, List<Tarea> listaDeTareasAgregar, List<Tarea> listaDeTareasAux)
        {
            foreach (Tarea tarea in listaDeTareasAux)
            {
                listaDeTareasAgregar.Add(tarea);
                listaDeTareasQuitar.Remove(tarea);
            }
        }
    }
}