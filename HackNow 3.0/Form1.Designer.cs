
namespace HackNow_3._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.cbFemenino = new System.Windows.Forms.CheckBox();
            this.cbMasculino = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbSiPsicologo = new System.Windows.Forms.CheckBox();
            this.cbNoPsicologo = new System.Windows.Forms.CheckBox();
            this.cbSiMedicamentos = new System.Windows.Forms.CheckBox();
            this.cbNoMedicamentos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(365, 41);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(173, 36);
            this.btnEmpezar.TabIndex = 0;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(367, 102);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(170, 31);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(243, 229);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(184, 23);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(242, 295);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(184, 23);
            this.tbEdad.TabIndex = 3;
            this.tbEdad.TextChanged += new System.EventHandler(this.tbEdad_TextChanged);
            // 
            // cbFemenino
            // 
            this.cbFemenino.AutoSize = true;
            this.cbFemenino.Location = new System.Drawing.Point(240, 390);
            this.cbFemenino.Name = "cbFemenino";
            this.cbFemenino.Size = new System.Drawing.Size(79, 19);
            this.cbFemenino.TabIndex = 4;
            this.cbFemenino.Text = "Femenino";
            this.cbFemenino.UseVisualStyleBackColor = true;
            // 
            // cbMasculino
            // 
            this.cbMasculino.AutoSize = true;
            this.cbMasculino.Location = new System.Drawing.Point(345, 390);
            this.cbMasculino.Name = "cbMasculino";
            this.cbMasculino.Size = new System.Drawing.Size(81, 19);
            this.cbMasculino.TabIndex = 5;
            this.cbMasculino.Text = "Masculino";
            this.cbMasculino.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // cbSiPsicologo
            // 
            this.cbSiPsicologo.AutoSize = true;
            this.cbSiPsicologo.Location = new System.Drawing.Point(230, 474);
            this.cbSiPsicologo.Name = "cbSiPsicologo";
            this.cbSiPsicologo.Size = new System.Drawing.Size(35, 19);
            this.cbSiPsicologo.TabIndex = 6;
            this.cbSiPsicologo.Text = "Si";
            this.cbSiPsicologo.UseVisualStyleBackColor = true;
            // 
            // cbNoPsicologo
            // 
            this.cbNoPsicologo.AutoSize = true;
            this.cbNoPsicologo.Location = new System.Drawing.Point(335, 475);
            this.cbNoPsicologo.Name = "cbNoPsicologo";
            this.cbNoPsicologo.Size = new System.Drawing.Size(42, 19);
            this.cbNoPsicologo.TabIndex = 7;
            this.cbNoPsicologo.Text = "No";
            this.cbNoPsicologo.UseVisualStyleBackColor = true;
            // 
            // cbSiMedicamentos
            // 
            this.cbSiMedicamentos.AutoSize = true;
            this.cbSiMedicamentos.Location = new System.Drawing.Point(230, 561);
            this.cbSiMedicamentos.Name = "cbSiMedicamentos";
            this.cbSiMedicamentos.Size = new System.Drawing.Size(35, 19);
            this.cbSiMedicamentos.TabIndex = 8;
            this.cbSiMedicamentos.Text = "Si";
            this.cbSiMedicamentos.UseVisualStyleBackColor = true;
            // 
            // cbNoMedicamentos
            // 
            this.cbNoMedicamentos.AutoSize = true;
            this.cbNoMedicamentos.Location = new System.Drawing.Point(329, 556);
            this.cbNoMedicamentos.Name = "cbNoMedicamentos";
            this.cbNoMedicamentos.Size = new System.Drawing.Size(42, 19);
            this.cbNoMedicamentos.TabIndex = 9;
            this.cbNoMedicamentos.Text = "No";
            this.cbNoMedicamentos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 604);
            this.Controls.Add(this.cbNoMedicamentos);
            this.Controls.Add(this.cbSiMedicamentos);
            this.Controls.Add(this.cbNoPsicologo);
            this.Controls.Add(this.cbSiPsicologo);
            this.Controls.Add(this.cbMasculino);
            this.Controls.Add(this.cbFemenino);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEmpezar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.CheckBox cbFemenino;
        private System.Windows.Forms.CheckBox cbMasculino;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.CheckBox cbNoMedicamentos;
        private System.Windows.Forms.CheckBox cbSiMedicamentos;
        private System.Windows.Forms.CheckBox cbNoPsicologo;
        private System.Windows.Forms.CheckBox cbSiPsicologo;
    }
}

