using System;

namespace Sakura
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Universidad.Estudiante> estudiantes = new List<Universidad.Estudiante>();
            int NumStd = 5; //Vamos a suponer que son 5 estudiantes
            int SesionesT = 40; //Tambien supondremos que las sesiones totales son 40
            int SesionesAsistidas;

            Console.WriteLine("Total de Alumnos 5 \nTotal de sesiones 40");
            Console.WriteLine();

            for (int i = 0; i < NumStd; i++)
            {
                Console.WriteLine($"Ingrese el Nombre del estudiante {i+1}: ");
                string Nombre = Console.ReadLine();

                do
                {
                    Console.WriteLine($"Ingrese el # de sesiones asistidas por {Nombre}: ");
                    SesionesAsistidas = int.Parse(Console.ReadLine());
                } while (SesionesAsistidas<=0 ||SesionesAsistidas>40);
                
                estudiantes.Add(new Universidad.Estudiante(Nombre, SesionesAsistidas, SesionesT));
            }

            Console.WriteLine("\nResumen de Asistencia: ");

            foreach(var estudiante in estudiantes)
            {
                estudiante.MostrarInfo();
            }
        }
    }
}