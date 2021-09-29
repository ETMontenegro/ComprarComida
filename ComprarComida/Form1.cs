using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprarComida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnPedido.Visible = false;
            lblTitulo1.Visible = false;
            LBLinstrucciones1.Visible = false;
            lblTitulo2.Visible = true;
            lblOp1.Visible = true;
            lblOp2.Visible = true;
            lblOp3.Visible = true;
            LBLinstrucciones2.Visible = true;
            textBox1.Visible = true;
         
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            int respuesta = Convert.ToInt32(textBox1.Text);
            
            if (respuesta > 1 && respuesta > 3 ) 
            {
                lblMnsjError.Visible = true;
                btnContinuar.Visible = false;
                textBox1.SelectAll();
            }
            else
            {
                lblMnsjError.Visible = false;
                btnContinuar.Visible = true;
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            lblSeleccion.Visible = true;
            lblSeleccion.Text = ( "Usted ha seleccionado la Opción: " + (Convert.ToString(textBox1.Text))
                + " ¿Es correcto?");
            btnConfirmar.Visible = true;
            btnNegar.Visible = true;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            btnPedido.Visible = false;
            lblTitulo1.Visible = false;
            LBLinstrucciones1.Visible = false;
            lblTitulo2.Visible = false;
            lblOp1.Visible = false;
            lblOp2.Visible = false;
            lblOp3.Visible = false;
            LBLinstrucciones2.Visible = true;
            
            btnContinuar.Visible = false;
            lblSeleccion.Visible = false;
            btnConfirmar.Visible = false;
            btnNegar.Visible = false;

            lblTitulo3.Visible = true;
            lblOpG1.Visible = true;
            lblOpG2.Visible = true;
            lblOpG3.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = true;

        }

        private bool btnNegarPresionado = false;

        private void btnNegar_Click(object sender, EventArgs e)
        {
            btnNegarPresionado = true;
            btnNegar.Visible = false;
            btnConfirmar.Visible = false;
            lblSeleccion.Visible = false;

            while (btnNegarPresionado)
            {
                textBox1.SelectAll();
                btnNegarPresionado = false;
                break;
            }
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            int respuesta2 = Convert.ToInt32(textBox2.Text);

            if (respuesta2 > 1 && respuesta2 > 3)
            {
                lblMnsjError.Visible = true;
                btnContinuar2.Visible = false;
                textBox2.SelectAll();
            }
            else
            {
                lblMnsjError.Visible = false;
                btnContinuar2.Visible = true;
            }
        }

        private void btnContinuar2_Click(object sender, EventArgs e)
        {
            lblSeleccion.Visible = true;
            lblSeleccion.Text = "Usted ha seleccionado la Opción: " 
                + (Convert.ToString(textBox2.Text)) 
                + "  Para su platillo y la Opcion: "
                + (Convert.ToString(textBox1.Text)) 
                + " como acompañamiento. ¿Es correcto?";
            btnConfirmar2.Visible = true;
            btnNegar2.Visible = true;

        }

        private void btnConfirmar2_Click(object sender, EventArgs e)
        {

            lblTitulo3.Visible = false;
            lblOpG1.Visible = false;
            lblOpG2.Visible = false;
            lblOpG3.Visible = false;
            btnConfirmar2.Visible = false;
            btnNegar2.Visible = false;
            lblSeleccion.Visible = false;
            textBox2.Visible = false;
            btnContinuar.Visible = false;
            btnContinuar2.Visible = false;
            LBLinstrucciones2.Visible = false;



            lblTitulo4.Visible = true;
            btnOtroPedido.Visible = true;

        }

        private void btnOtroPedido_Click(object sender, EventArgs e)
        {
            lblTitulo4.Visible = false;
            btnOtroPedido.Visible = false;


            lblTitulo2.Visible = true;
            lblOp1.Visible = true;
            lblOp2.Visible = true;
            lblOp3.Visible = true;
            LBLinstrucciones2.Visible = true;
            textBox1.Visible = true;

        }
        
        private void btnNegar2_Click(object sender, EventArgs e)
        {
            btnNegarPresionado = true;
            btnNegar2.Visible = false;
            btnConfirmar2.Visible = false;
            lblSeleccion.Visible = false;

            while (btnNegarPresionado)
            {
                textBox2.SelectAll();
                btnNegarPresionado = false;
                break;
            }
        }
    }
}
