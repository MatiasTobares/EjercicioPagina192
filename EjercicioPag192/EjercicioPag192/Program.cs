using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPag192
{
    class Program
    {
        static void Main(string[] args)
        {
            int CantidadAlumnos = 0; //Cantidad de elementos del array unidimensional
            string cambio = "";  //Variable para cambiar los valores a enteros/float o rellenar el array.
            float SumaNota = 0.0f, PromedioNotas = 0.0f, NotaMinima = 10.0f, NotaMaxima = 0.0f;

            Console.WriteLine("Ingrese la cantidad de alumnos: ");
            cambio = Console.ReadLine();
            CantidadAlumnos = Convert.ToInt32(cambio);

            float[] notas = new float[CantidadAlumnos];

            for (int i = 0; i < CantidadAlumnos; i++) {
                Console.WriteLine("Ingrese la calificacion: " + (i + 1));   //El i+1 es para mostrar la nota a partir de uno, pero el array toma desde la posicion 0.
                cambio = Console.ReadLine();
                notas[i] = Convert.ToSingle(cambio);
            }

            for (int i = 0;i< CantidadAlumnos; i++){
                SumaNota += notas[i];
            }

            //Operacion que saca el promedio de las notas, en relacion a la cantidad de alumnos.
            PromedioNotas = SumaNota / CantidadAlumnos;

            //Bucle para buscar la nota menor en el array.
            for(int i = 0; i < CantidadAlumnos; i++){
                if (notas[i] < NotaMinima){
                    NotaMinima = notas[i];
                }
            }

            //Bucle para buscar la nota mayor en el array.
            for (int i = 0; i < CantidadAlumnos; i++){
                if (notas[i] > NotaMaxima){
                    NotaMaxima = notas[i];
                }
            }
            Console.WriteLine("Mostrando los resultados...");
            Console.WriteLine("El promedio de las notas es {0}", PromedioNotas);
            Console.WriteLine("La calificacion mínima es {0}",NotaMinima);
            Console.WriteLine("La calificacion máxima es {0}", NotaMaxima);


            Console.ReadKey();
        }
    }
}
