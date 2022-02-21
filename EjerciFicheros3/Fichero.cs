using System;
using System.IO;

namespace EjerciFicheros3
{
    class Fichero
    {
        public static string NombreArchivo = @"C:\Users\Alumno\Desktop\Alumnos.txt";


        /// <summary>
        /// Lee el fichero y extrae los datos en formato de string 
        /// </summary>
        /// <returns>Retorna una lista con todos los datos</returns>
        public static string[] LeerFichero()
        {
            // Alumnado[] Alumno = new Alumnado[10];
            int max = 1;
            string[] ListaDatos = new string[max];
            StreamReader FRead = null;
            try
            {
                FRead = new StreamReader(NombreArchivo);
                int rep = 0;
                while (!FRead.EndOfStream)
                {
                    Array.Resize(ref ListaDatos, max++);
                    ListaDatos[rep] += FRead.ReadLine();

                    rep++;
                }
                FRead.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ListaDatos;
        }
    }
}
