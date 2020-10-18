using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;

namespace Pregunta2
{
    public partial class Libros : Form
    {
        public Libros()
        {
            InitializeComponent();
        }

        List<Libro> listaLibro = new List<Libro>();

        Libro obj = new Libro();

        void Listado()
        {
            lvLibros.Items.Clear();
            foreach(Libro reg in listaLibro)
            {
                ListViewItem item = new ListViewItem(reg.codLibro);
                item.SubItems.Add(reg.nomLibro.ToUpper());
                item.SubItems.Add(reg.fecRegistro.ToShortDateString());
                item.SubItems.Add(reg.genero);
                item.SubItems.Add(reg.nomAutor);
                lvLibros.Items.Add(item);
            }
        }

        void Limpiar()
        {
            cboGen.SelectedIndex = -1;
            txtCodigo.Text = obj.generaCodigo();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Boolean find = false;
            
            foreach(Libro reg in listaLibro)
            {
                if (reg.nomLibro == txtNombre.Text.ToUpper())
                {
                    MessageBox.Show("Libro ya se encuentra registrado…!!","AVISO");
                    find = true;
                    break;
                    
                }
            }

            if ( find == false)
            {
                obj = new Libro();
                obj.codLibro = txtCodigo.Text;
                obj.nomLibro = txtNombre.Text.ToUpper();
                obj.fecRegistro = dtFechaReg.Value;   
                obj.genero = cboGen.Text;
                obj.nomAutor = txtAutor.Text.ToUpper();

                listaLibro.Add(obj);
                Listado();
                Limpiar();

            }
        }

        private void Libros_Load(object sender, EventArgs e)
        {
            txtCodigo.Text =obj.generaCodigo();
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = Interaction.InputBox("Ingrese codigo a buscar");
            Boolean find = false;
            foreach(Libro reg in listaLibro)
            {
                if (reg.codLibro == codigo)
                {
                    find = true;
                    listaLibro.Remove(reg);
                    break;
                }

            }
            if (find == false)
            {
                MessageBox.Show("El codigo no existe", "AVISO");
                return;
            }
            Listado();
        }   
    }      

}
