using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakura
{
    public static class ExtensionesEstudiante
    {
        public static void MostrarInfo(this Universidad.Estudiante estudiante)
        {
            double Asistencia = Universidad.Estudiante.Asistencia.CalPorcentaje(estudiante.SesionesAsistidas, estudiante.SesionesTotales);
            bool CumpleMin = Universidad.Estudiante.Asistencia.Cumplimiento(estudiante.SesionesTotales, estudiante.SesionesTotales);

            Console.WriteLine("0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0");
            Console.WriteLine($"Nombre: {estudiante.Nombre}");
            //Console.WriteLine($"Porcentaje de Asistencia: {PorcentajeAsistencia}%");
            //Console.WriteLine($"Cumplimiento mínimo de asistencia: {(CumpleMin ? "Si" : "No")}");
            Console.WriteLine();
        }
    }
}
