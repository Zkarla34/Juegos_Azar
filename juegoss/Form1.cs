using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juegoss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Cara y sello
        private void btncaraysello_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.lbnombrecs.Text = textnombre.Text;
            f2.lbtotalcs.Text = texttotal.Text;


            //Ocultar formulario 1
            Form.ActiveForm.Visible = false;
            f2.Show();
        }

        //Piedra papel tijera
        private void btnppt_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            f3.lbnombreppt.Text = textnombre.Text;
            f3.lbtotalppt.Text = texttotal.Text;
            //Ocultar formulario 1
            Form.ActiveForm.Visible = false;
            f3.Show();
        }

        //Dados
        private void btndados_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.lbnombred.Text = textnombre.Text;
            f4.lbtotald.Text = texttotal.Text;

            
            //Ocultar formulario 1
            Form.ActiveForm.Visible = false;
            f4.Show();
        }

    }
}
