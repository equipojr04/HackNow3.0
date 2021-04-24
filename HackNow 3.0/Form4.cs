using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace HackNow_3._0

/*Jesus Antonio Cornejo Cervantes
Valeria Pedraza Chavez  
Dianna Jacqueline Cruz Bautista
JR04
*/

{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            btnSiguiente2.Enabled = false;
        }

        private void controlBotones4()
        {
            if (tbRespuesta1.Text.Trim() != string.Empty && tbRespuesta1.Text.All(Char.IsNumber))
            {
                btnSiguiente2.Enabled = true;
                errorProvider4.SetError(tbRespuesta1, "");
            }
            else
            {
                if (!(tbRespuesta1.Text.All(Char.IsNumber)))
                {
                    errorProvider4.SetError(tbRespuesta1, "La edad debe contener numeros");
                }
                else
                {
                    errorProvider4.SetError(tbRespuesta1, "Debe introducir su edad");

                }
                btnSiguiente2.Enabled = false;
                tbRespuesta1.Focus();

            }
        }

        private void tbRespuesta1_TextChanged(object sender, EventArgs e)
        {
            controlBotones4();
        }

        private void btnSiguiente2_Click(object sender, EventArgs e)
        {
            Form5 obj5 = new Form5();
            obj5.Visible = true;
            Visible = false;
        }

        private void btnVolver3_Click(object sender, EventArgs e)
        {
            Form3 obj3 = new Form3();
            obj3.Visible = true;
            Visible = false;
        }
    }
}
