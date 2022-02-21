using System;

namespace EjerciFicheros3
{
    class Funciones
    {
        /// <summary>
        /// Estructura de alumno con nombre apellidos y las notas de todas las evaluaciones
        /// </summary>
        public struct Alumnado
        {
            public string nombre;
            public string Apellidos;
            public decimal notaEvaluacion;
            public decimal nota2Evaluacion;
            public decimal nota3Evaluacion;

        }
        public static void AlmacenarDatos(string[] datosArchivo)
        {
            Alumnado[] alumno = new Alumnado[datosArchivo.Length / 5];
            int max = 0;
            for (int rep = 0; rep < datosArchivo.Length; rep++)
            {
                if (rep == 5)
                {
                    max++;
                }
                if (Decimal.TryParse(datosArchivo[rep], out decimal numero))
                {
                    if (alumno[max].notaEvaluacion == 0)
                    {
                        alumno[max].notaEvaluacion = numero;
                    }
                    else
                    {
                        if (alumno[max].nota2Evaluacion == 0)
                        {
                            d
                        }
                    }
                }
                else
                {
                    if (alumno[max].nombre != null)
                    {
                        alumno[max].Apellidos = datosArchivo[rep];
                        
                    }
                    else
                    {
                        alumno[max].nombre = datosArchivo[rep];
                    }
                }
            }


        }
    }
}
