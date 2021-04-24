using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HackNow_3._0

/*Jesus Antonio Cornejo Cervantes
Valeria Pedraza Chavez  
Dianna Jacqueline Cruz Bautista
JR04
*/

{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void btnVolver1_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Visible = true;
            Visible = false;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            Form3 obj3 = new Form3();
            obj3.Visible = true;
            Visible = false;
        }
    }
}
