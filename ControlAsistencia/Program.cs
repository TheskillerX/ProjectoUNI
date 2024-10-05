using ControlAsistencia.ControlAsistencia;
using System;

namespace ControlAsistencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var estudiante1 = new Universidad.Estudiante { Nombre = "Leonel Andres Messi Cuccitini (GOAT)", SesionesTotales = 20, SesionesAsistidas = 18 };

            var estudiante2 = new Universidad.Estudiante { Nombre = "Carles Puyol", SesionesTotales = 20, SesionesAsistidas = 12 };

            var estudiante3 = new Universidad.Estudiante { Nombre = "Xavier Hernandez", SesionesTotales = 20, SesionesAsistidas = 15 };

            var estudiante4 = new Universidad.Estudiante { Nombre = "Andres Iniesta", SesionesTotales = 20, SesionesAsistidas = 19 };

            var estudiante5 = new Universidad.Estudiante { Nombre = "Victor Valdes", SesionesTotales = 20, SesionesAsistidas = 16 };

            var estudiante6 = new Universidad.Estudiante { Nombre = "Johan Cruyff", SesionesTotales = 20, SesionesAsistidas = 10 };

            var estudiante7 = new Universidad.Estudiante { Nombre = "Rivaldo", SesionesTotales = 20, SesionesAsistidas = 14 };

            var estudiante8 = new Universidad.Estudiante { Nombre = "Sergio Busquets", SesionesTotales = 20, SesionesAsistidas = 17 };

            var estudiante9 = new Universidad.Estudiante { Nombre = "Tierry Henry", SesionesTotales = 20, SesionesAsistidas = 11 };

            var estudiante10 = new Universidad.Estudiante { Nombre = "Pep Guardiola", SesionesTotales = 20, SesionesAsistidas = 19 };

            var estudiante11 = new Universidad.Estudiante { Nombre = "luis Suarez", SesionesTotales = 20, SesionesAsistidas = 15 };

            
            estudiante1.MostrarInformacion();

            estudiante2.MostrarInformacion();

            estudiante3.MostrarInformacion();

            estudiante4.MostrarInformacion();

            estudiante5.MostrarInformacion();

            estudiante6.MostrarInformacion();

            estudiante7.MostrarInformacion();

            estudiante8.MostrarInformacion();

            estudiante9.MostrarInformacion();

            estudiante10.MostrarInformacion();

            estudiante11.MostrarInformacion();

        }
    }
}
