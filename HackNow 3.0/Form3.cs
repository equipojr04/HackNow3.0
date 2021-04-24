using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace HackNow_3._0

/*Jesus Antonio Cornejo Cervantes
Valeria Pedraza Chavez  
Dianna Jacqueline Cruz Bautista
JR04
*/

{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = false;
        }

        private void controlBotones3()
        {
            if (tbRespuesta.Text.Trim() != string.Empty && tbRespuesta.Text.All(Char.IsNumber))
            {
                btnSiguiente.Enabled = true;
                errorProvider3.SetError(tbRespuesta, "");
            }
            else
            {
                if (!(tbRespuesta.Text.All(Char.IsNumber)))
                {
                    errorProvider3.SetError(tbRespuesta, "La edad debe contener numeros");
                }
                else
                {
                    errorProvider3.SetError(tbRespuesta, "Debe introducir su edad");

                }
                btnSiguiente.Enabled = false;
                tbRespuesta.Focus();

            }
        }

        private void tbRespuesta_TextChanged(object sender, EventArgs e)
        {
            controlBotones3();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        
        {
            if (tbRespuesta.Text == 3)
              {
                this.Hide();
                Form4 x = new Form4();
                XmlReadMode.ShowDialog();

            }
        }

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            Form2 obj2 = new Form2();
            obj2.Visible = true;
            Visible = false;
        }
    }
}
