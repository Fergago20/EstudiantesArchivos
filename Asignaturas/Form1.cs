using Asignaturas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignaturas
{
    public partial class Form1 : Form
    {
        AdministrarAlumno Adm = new AdministrarAlumno();
        Alumno alumno = new Alumno();
        public Form1()
        {
            InitializeComponent();
        }

        private void btmAgregar_Click(object sender, EventArgs e)
        {
            alumno.Nombre = tbNombre.Text;
            alumno.Nota = double.Parse(tbNota.Text);
            Adm.Agregar(alumno);
            Mostrar();
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            
            alumno.Nombre = tbNombre.Text;
            alumno.Nota = double.Parse(tbNota.Text);
            Adm.Eliminar(alumno);
            Mostrar();
        }

        private void btmActualizar_Click(object sender, EventArgs e)
        {
            alumno.Nombre = tbNombre.Text;
            alumno.Nota = double.Parse(tbNota.Text);
            Adm.Actualizar(alumno, alumno.Nombre);
            Mostrar();
        }

        private void Mostrar()
        {
            dgvSalida.DataSource = null;
            dgvSalida.DataSource = Adm.Mostrar();
        }

        private void btmGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Archivos DAT (*.dat)|*.dat";
                saveFileDialog1.Title = "Guardar archivo";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ArchivoAlumnos archivo = new ArchivoAlumnos();
                    archivo.Guardar(Adm.Mostrar(), saveFileDialog1.FileName);
                    MessageBox.Show("Guardado Correctamente");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btmCargar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos DAT (*.dat)|*.dat";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ArchivoAlumnos archivo = new ArchivoAlumnos();
                Adm.Reponer(archivo.Cargar(openFileDialog1.FileName));
                Mostrar();
            }
        }
    }
}
