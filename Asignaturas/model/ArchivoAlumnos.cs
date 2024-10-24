using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignaturas.model
{
    internal class ArchivoAlumnos
    {
        public void Guardar(List<Alumno> alumnos, string rutaArchivo)
        {
            FileStream archivo = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write);
            BinaryWriter escritor = new BinaryWriter(archivo);
            foreach (Alumno alu in alumnos)
            {
                escritor.Write(alu.Nombre);
                escritor.Write(alu.Nota);
            }
            archivo.Close();
        }

        public List<Alumno> Cargar (string rutaArchivo)
        {
            List<Alumno> alumnos = new List<Alumno>();
            if (!File.Exists(rutaArchivo))
            {

                return alumnos;
            }

            FileStream archivo = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read);
            BinaryReader lector = new BinaryReader(archivo);

            while(archivo.Position!= archivo.Length)
            {
                string nombre = lector.ReadString();
                double nota = lector.ReadDouble();

                Alumno alum = new Alumno();
                alum.Nombre = nombre;
                alum.Nota = nota;

                alumnos.Add(alum);
            }
            return alumnos;
        }
    }
}
