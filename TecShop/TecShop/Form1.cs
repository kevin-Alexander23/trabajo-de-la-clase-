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

namespace TecShop
{
    public partial class Form1 : Form
    {
        List<ClsProducto> listaInventario = new List<ClsProducto>();
        ClsProducto pdt = new ClsProducto();


        public Form1()
        {
            InitializeComponent();
            idProducto();
        }

        public void LimpiarObjetos()
        {
            txtId.Clear();
            txtDescripcion.Clear();
            cbtCategoria.Text = "";
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

        void idProducto()
        {
            int id = 0;
            txtId.Text = id.ToString();
            id++;
        }
        public void RegistrarProducto()
        {
            double PrecioVenta;
            pdt.idProducto = Convert.ToInt32(txtId.Text);
            pdt.NomProducto = txtProducto.Text;
            pdt.descripcion = txtProducto.Text;
            pdt.categoria = cbtCategoria.Text;
            pdt.stock = int.Parse(txtCantidad.Text);
            pdt.precioCompra = Convert.ToInt32(txtPrecio);
            PrecioVenta 


        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
