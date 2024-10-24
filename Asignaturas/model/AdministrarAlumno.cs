using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignaturas.model
{
    internal class AdministrarAlumno
    {
        List<Alumno> alumnos = new List<Alumno>();

        public List<Alumno> Mostrar()
        {
            return alumnos;
        }
        public void Agregar(Alumno alum)
        {
            alumnos.Add(alum);
        }

        public void Reponer(List<Alumno> alum)
        {
            Reiniciar();
            alumnos = alum;
        }

        public void Eliminar(Alumno alum)
        {
            alumnos.Remove(alum);
        }

        public void Actualizar(Alumno alum, string nombre)
        {
            int index = alumnos.FindIndex(alu => string.Equals(alum.Nombre, alu.Nombre, StringComparison.OrdinalIgnoreCase));

            if (index != -1)
            {
                alumnos[index] = alum;
            }
        }

        public void Reiniciar()
        {
            alumnos.RemoveAll(alum=> true);
        }
    }
}
