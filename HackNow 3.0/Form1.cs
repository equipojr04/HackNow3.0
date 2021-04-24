using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackNow_3._0
    /*Jesus Antonio Cornejo Cervantes
    Valeria Pedraza Chavez  
    Dianna Jacqueline Cruz Bautista
    JR04
    */

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEmpezar.Enabled = false;
        }

        private void controlBotones2()
        {
            if (tbEdad.Text.Trim() != string.Empty && tbEdad.Text.All(Char.IsNumber))
            {
                btnEmpezar.Enabled = true;
                errorProvider2.SetError(tbEdad, "");
            }
            else
            {
                if (!(tbEdad.Text.All(Char.IsNumber)))
                {
                    errorProvider2.SetError(tbEdad, "La edad debe contener numeros");
                }
                else
                {
                    errorProvider2.SetError(tbEdad, "Debe introducir su edad");

                }
                btnEmpezar.Enabled = false;
                tbEdad.Focus();

            }
        }
        private void controlBotones()
        {
            if (tbNombre.Text.Trim() != string.Empty && tbNombre.Text.All(Char.IsLetter))
            {
                btnEmpezar.Enabled = true;
                errorProvider1.SetError(tbNombre, "");
            }
            else
            {
                if (!(tbNombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(tbNombre, "El nombre solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(tbNombre, "Debe introducir su nombre");

                }
                btnEmpezar.Enabled = false;
                tbNombre.Focus();

            }
        }


        private void tbEdad_TextChanged(object sender, EventArgs e)
        {
            controlBotones2();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {

            Form2 obj2 = new Form2();
            obj2.Visible = true;
            Visible = false;


        }
    }
}
