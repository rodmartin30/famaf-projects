namespace TP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abmMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abmSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbxMovimientos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbtnSocio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnPersonaAutorizada = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.gbxMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem,
            this.busquedasToolStripMenuItem,
            this.deudoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abmMaterialToolStripMenuItem,
            this.abmSocioToolStripMenuItem,
            this.aBMEmpleadoToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // abmMaterialToolStripMenuItem
            // 
            this.abmMaterialToolStripMenuItem.Name = "abmMaterialToolStripMenuItem";
            this.abmMaterialToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.abmMaterialToolStripMenuItem.Text = "ABM Material/Copia";
            this.abmMaterialToolStripMenuItem.Click += new System.EventHandler(this.abmMaterialToolStripMenuItem_Click);
            // 
            // abmSocioToolStripMenuItem
            // 
            this.abmSocioToolStripMenuItem.Name = "abmSocioToolStripMenuItem";
            this.abmSocioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.abmSocioToolStripMenuItem.Text = "ABM Socio";
            this.abmSocioToolStripMenuItem.Click += new System.EventHandler(this.abmSocioToolStripMenuItem_Click);
            // 
            // aBMEmpleadoToolStripMenuItem
            // 
            this.aBMEmpleadoToolStripMenuItem.Name = "aBMEmpleadoToolStripMenuItem";
            this.aBMEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.aBMEmpleadoToolStripMenuItem.Text = "ABM Empleado";
            this.aBMEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.aBMEmpleadoToolStripMenuItem_Click);
            // 
            // busquedasToolStripMenuItem
            // 
            this.busquedasToolStripMenuItem.Name = "busquedasToolStripMenuItem";
            this.busquedasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.busquedasToolStripMenuItem.Text = "Busquedas";
            // 
            // deudoresToolStripMenuItem
            // 
            this.deudoresToolStripMenuItem.Name = "deudoresToolStripMenuItem";
            this.deudoresToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.deudoresToolStripMenuItem.Text = "Deudores";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(767, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(767, 78);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // gbxMovimientos
            // 
            this.gbxMovimientos.Controls.Add(this.btnAgregar);
            this.gbxMovimientos.Controls.Add(this.rbtnSocio);
            this.gbxMovimientos.Controls.Add(this.label2);
            this.gbxMovimientos.Controls.Add(this.rbtnPersonaAutorizada);
            this.gbxMovimientos.Controls.Add(this.label3);
            this.gbxMovimientos.Controls.Add(this.textBox1);
            this.gbxMovimientos.Controls.Add(this.label4);
            this.gbxMovimientos.Controls.Add(this.label5);
            this.gbxMovimientos.Controls.Add(this.comboBox1);
            this.gbxMovimientos.Controls.Add(this.dateTimePicker1);
            this.gbxMovimientos.Controls.Add(this.comboBox2);
            this.gbxMovimientos.Controls.Add(this.comboBox3);
            this.gbxMovimientos.Location = new System.Drawing.Point(19, 37);
            this.gbxMovimientos.Name = "gbxMovimientos";
            this.gbxMovimientos.Size = new System.Drawing.Size(679, 203);
            this.gbxMovimientos.TabIndex = 20;
            this.gbxMovimientos.TabStop = false;
            this.gbxMovimientos.Text = "Movimientos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(246, 162);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 27);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // rbtnSocio
            // 
            this.rbtnSocio.AutoSize = true;
            this.rbtnSocio.Location = new System.Drawing.Point(6, 35);
            this.rbtnSocio.Name = "rbtnSocio";
            this.rbtnSocio.Size = new System.Drawing.Size(52, 17);
            this.rbtnSocio.TabIndex = 14;
            this.rbtnSocio.TabStop = true;
            this.rbtnSocio.Text = "Socio";
            this.rbtnSocio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empleado";
            // 
            // rbtnPersonaAutorizada
            // 
            this.rbtnPersonaAutorizada.AutoSize = true;
            this.rbtnPersonaAutorizada.Location = new System.Drawing.Point(6, 58);
            this.rbtnPersonaAutorizada.Name = "rbtnPersonaAutorizada";
            this.rbtnPersonaAutorizada.Size = new System.Drawing.Size(116, 17);
            this.rbtnPersonaAutorizada.TabIndex = 13;
            this.rbtnPersonaAutorizada.TabStop = true;
            this.rbtnPersonaAutorizada.Text = "Persona autorizada";
            this.rbtnPersonaAutorizada.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo movimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Id copia";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(545, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 110);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(254, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(545, 43);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 348);
            this.dataGridView1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbxMovimientos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVD Club";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxMovimientos.ResumeLayout(false);
            this.gbxMovimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abmMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abmSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deudoresToolStripMenuItem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbxMovimientos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rbtnSocio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnPersonaAutorizada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

