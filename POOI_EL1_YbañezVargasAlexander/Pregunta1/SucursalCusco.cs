using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pregunta1
{
    public partial class SucursalCusco : Form
    {
     
        public SucursalCusco()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Cusco obj = new Cusco();

            obj.Modelo = int.Parse(txtModelo.Text);

            if (txtCantidad.Text == string.Empty)
            { obj.Cantidad = 2; }
            else
            { obj.Cantidad = int.Parse(txtCantidad.Text); }

            obj.Equipo = cboEquipo.Text;
            txtSub.Text = obj.SubTotal().ToString("n2");
            txtDescuento.Text = obj.Descuento().ToString("n2");
            txtTotal.Text = obj.NetoPagar().ToString("n2");

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtModelo.Text);
            item.SubItems.Add(txtCantidad.Text);
            item.SubItems.Add(cboEquipo.Text);
            item.SubItems.Add(txtSub.Text);
            item.SubItems.Add(txtDescuento.Text);
            item.SubItems.Add(txtTotal.Text);

            lvwLista.Items.Add(item);



        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvwLista.SelectedItems)
            {
                item.Remove();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvwLista.Items.Clear();
        }
    }

            
    
}   
