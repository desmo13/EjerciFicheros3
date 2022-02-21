namespace EjerciFicheros3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] DatosFicheros = Fichero.LeerFichero();
            Funciones.AlmacenarDatos(DatosFicheros);
        }
    }
}
