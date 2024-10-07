using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakura
{
    public class Universidad
    {
        public class Estudiante
        {
            public string Nombre { get; set; }
            public int SesionesTotales { get; set; }
            public int SesionesAsistidas { get; set; }

            public Estudiante(string Nombre, int SesionesTotales, int SesionesAsistidas)
            {
                Nombre = Nombre;
                SesionesTotales = SesionesTotales;
                SesionesAsistidas = SesionesAsistidas;
            }
            public class Asistencia
            {
                public static double Porcentaje(int SesionesAsistidas)
                {
                    return SesionesAsistidas;
                }

                public static double CalPorcentaje(int SesionesAsistidas, int SesionesTotales)
                {
                    return (double)((SesionesAsistidas*100)/SesionesTotales);
                }
                public static bool Cumplimiento(int SesionesAsistidas, int SesionesTotales)
                {
                    return CalPorcentaje(SesionesAsistidas, SesionesTotales)>=75;
                }
            }

        }
    }
}
