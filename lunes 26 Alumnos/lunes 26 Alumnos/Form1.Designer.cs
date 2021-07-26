
namespace lunes_26_Alumnos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Codigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.bcSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.cbModulo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chRepetidor = new System.Windows.Forms.CheckBox();
            this.Busqueda = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btBuscarCodigo = new System.Windows.Forms.Button();
            this.btBuscarDNI = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.txtBuscarDNI = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(13, 13);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(40, 13);
            this.Codigo.TabIndex = 0;
            this.Codigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(54, 10);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(45, 45);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(109, 20);
            this.txtDNI.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(232, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Turno";
            // 
            // cbTurno
            // 
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "Diurno",
            "Nocturno"});
            this.cbTurno.Location = new System.Drawing.Point(45, 82);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(121, 21);
            this.cbTurno.TabIndex = 7;
            // 
            // bcSexo
            // 
            this.bcSexo.FormattingEnabled = true;
            this.bcSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.bcSexo.Location = new System.Drawing.Point(242, 82);
            this.bcSexo.Name = "bcSexo";
            this.bcSexo.Size = new System.Drawing.Size(121, 21);
            this.bcSexo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Especialidad";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Todos"});
            this.cbEspecialidad.Location = new System.Drawing.Point(92, 121);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cbEspecialidad.TabIndex = 11;
            // 
            // cbModulo
            // 
            this.cbModulo.FormattingEnabled = true;
            this.cbModulo.Items.AddRange(new object[] {
            "DAM",
            "DAW"});
            this.cbModulo.Location = new System.Drawing.Point(318, 121);
            this.cbModulo.Name = "cbModulo";
            this.cbModulo.Size = new System.Drawing.Size(121, 21);
            this.cbModulo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Modulo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 14;
            // 
            // chRepetidor
            // 
            this.chRepetidor.AutoSize = true;
            this.chRepetidor.Location = new System.Drawing.Point(467, 123);
            this.chRepetidor.Name = "chRepetidor";
            this.chRepetidor.Size = new System.Drawing.Size(72, 17);
            this.chRepetidor.TabIndex = 15;
            this.chRepetidor.Text = "Repetidor";
            this.chRepetidor.UseVisualStyleBackColor = true;
            // 
            // Busqueda
            // 
            this.Busqueda.Controls.Add(this.txtBuscarDNI);
            this.Busqueda.Controls.Add(this.txtBuscarCodigo);
            this.Busqueda.Controls.Add(this.btBuscarDNI);
            this.Busqueda.Controls.Add(this.btBuscarCodigo);
            this.Busqueda.Controls.Add(this.label9);
            this.Busqueda.Controls.Add(this.label8);
            this.Busqueda.Location = new System.Drawing.Point(579, 13);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(209, 103);
            this.Busqueda.TabIndex = 16;
            this.Busqueda.TabStop = false;
            this.Busqueda.Text = "Busqueda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Codigo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "DNI";
            // 
            // btBuscarCodigo
            // 
            this.btBuscarCodigo.Location = new System.Drawing.Point(162, 40);
            this.btBuscarCodigo.Name = "btBuscarCodigo";
            this.btBuscarCodigo.Size = new System.Drawing.Size(37, 23);
            this.btBuscarCodigo.TabIndex = 19;
            this.btBuscarCodigo.UseVisualStyleBackColor = true;
            // 
            // btBuscarDNI
            // 
            this.btBuscarDNI.Location = new System.Drawing.Point(162, 69);
            this.btBuscarDNI.Name = "btBuscarDNI";
            this.btBuscarDNI.Size = new System.Drawing.Size(37, 23);
            this.btBuscarDNI.TabIndex = 20;
            this.btBuscarDNI.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(53, 40);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarCodigo.TabIndex = 21;
            // 
            // txtBuscarDNI
            // 
            this.txtBuscarDNI.Location = new System.Drawing.Point(53, 69);
            this.txtBuscarDNI.Name = "txtBuscarDNI";
            this.txtBuscarDNI.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarDNI.TabIndex = 22;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(588, 133);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(56, 46);
            this.btnAlta.TabIndex = 17;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Baja";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(732, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 46);
            this.button2.TabIndex = 19;
            this.button2.Text = "Modifica";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 253);
            this.dataGridView1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.chRepetidor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbModulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bcSexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTurno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.Codigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Busqueda.ResumeLayout(false);
            this.Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.ComboBox bcSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.ComboBox cbModulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chRepetidor;
        private System.Windows.Forms.GroupBox Busqueda;
        private System.Windows.Forms.TextBox txtBuscarDNI;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.Button btBuscarDNI;
        private System.Windows.Forms.Button btBuscarCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

