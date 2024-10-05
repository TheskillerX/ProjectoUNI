using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAsistencia
{
    namespace ControlAsistencia
    {
        public class Universidad
        {
            public class Estudiante
            {
                public string Nombre { get; set; }
                public int SesionesTotales { get; set; }
                public int SesionesAsistidas { get; set; }

                public class Asistencia
                {
                    public static double CalcularPorcentaje(int sesionesAsistidas, int sesionesTotales)
                    {
                        if (sesionesTotales == 0) return 0;
                        return (sesionesAsistidas / (double)sesionesTotales) * 100;
                    }

                    public static bool CumpleConAsistencia(double porcentaje)
                    {
                        return porcentaje >= 75.0;
                    }
                }
            }
        }
    }
}
