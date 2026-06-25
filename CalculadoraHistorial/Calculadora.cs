namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;
        public Calculadora()
        {
            dato = 0;
        }
        public double Resultado
        { get => dato; }
        public void Sumar(double termino)
        {
            dato += termino;
        }
        public void Restar(double termino)
        {
            dato -= termino;
        }
        public void Multiplicar(double termino)
        {
            dato *= termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato /= termino;
            }
            else
            {
                Console.WriteLine("No existe la division en 0");
            }
        }
        public void Limpiar()
        {
            dato = 0;
        }
    }
    public class Operacion
    {
        private double resultadoAnterior; //Almacena el resultado previo al calculo actual
        private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
        private TipoOperacion operacion; //El tipo de operacion realizada
        public double Resultado
        {
            //Logica para calular o devolver el resultado
            get => resultadoAnterior;
        }

        //Propiedad publica para acceder al nuevo valor utilizado en la operacion
        public double NuevoValor
        {
            get => nuevoValor;
        }

        //Constructor u otros metodos necesarios para inicializar y gestionalizar la operacion
        //...
    }
    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar //Representa la accion de borrar el resultado o el historial
    }

}