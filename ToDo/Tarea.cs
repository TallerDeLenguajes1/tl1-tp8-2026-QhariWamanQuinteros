namespace EspacioTarea
{
    public class Tarea
    {
        private int tareaID;
        private int duracion;
        public int TareaID { get => tareaID; set => tareaID = value; }
        public string Descripcion { get; set; }
        public int Duracion { get => duracion; set => duracion = value; } //Validar que esté entre 10 y 100

        //Puedes añadir un constructor y metodos auxiliares si lo consideras necesario
        public Tarea(int tareaID, string descripcion, int duracion)
        {
            TareaID = tareaID;
            Descripcion = descripcion;
            Duracion = duracion;
        }
    }
}
