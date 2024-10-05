using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlAsistencia.ControlAsistencia;

namespace ControlAsistencia
{
    public static class ExtensionesEstudiante
    {
        public static void MostrarInformacion(this Universidad.Estudiante estudiante)
        {
            double porcentajeAsistencia = Universidad.Estudiante.Asistencia.CalcularPorcentaje(estudiante.SesionesAsistidas, estudiante.SesionesTotales);

            bool cumple = Universidad.Estudiante.Asistencia.CumpleConAsistencia(porcentajeAsistencia);

            Console.WriteLine($"Estudiante: {estudiante.Nombre}");

            Console.WriteLine($"Porcentaje de Asistencia: {porcentajeAsistencia:F2}%");

            Console.WriteLine(cumple ? "Felicidades mae si Cumplis  con los requisito de asistencia, toma una coca cola." : "lastimosamente no cumpliste con los requisito de asistencia, echale ganas mae, vos podes.");

            Console.WriteLine();
        }
    }
}
