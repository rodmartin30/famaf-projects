namespace TP
{
    partial class frmBusquedas
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxBuscar = new System.Windows.Forms.GroupBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.cboFormato = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblFormato = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbxBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(313, 82);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbxBuscar
            // 
            this.gbxBuscar.Controls.Add(this.txtCategoria);
            this.gbxBuscar.Controls.Add(this.cboFormato);
            this.gbxBuscar.Controls.Add(this.txtTitulo);
            this.gbxBuscar.Controls.Add(this.txtDirector);
            this.gbxBuscar.Controls.Add(this.txtActor);
            this.gbxBuscar.Controls.Add(this.lblCategoria);
            this.gbxBuscar.Controls.Add(this.lblTitulo);
            this.gbxBuscar.Controls.Add(this.lblDirector);
            this.gbxBuscar.Controls.Add(this.lblFormato);
            this.gbxBuscar.Controls.Add(this.lblActor);
            this.gbxBuscar.Location = new System.Drawing.Point(12, 12);
            this.gbxBuscar.Name = "gbxBuscar";
            this.gbxBuscar.Size = new System.Drawing.Size(267, 152);
            this.gbxBuscar.TabIndex = 6;
            this.gbxBuscar.TabStop = false;
            this.gbxBuscar.Text = "Filtros";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(70, 120);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(121, 20);
            this.txtCategoria.TabIndex = 12;
            // 
            // cboFormato
            // 
            this.cboFormato.FormattingEnabled = true;
            this.cboFormato.Location = new System.Drawing.Point(70, 47);
            this.cboFormato.Name = "cboFormato";
            this.cboFormato.Size = new System.Drawing.Size(121, 21);
            this.cboFormato.TabIndex = 11;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(70, 96);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(121, 20);
            this.txtTitulo.TabIndex = 10;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(70, 72);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(121, 20);
            this.txtDirector.TabIndex = 9;
            // 
            // txtActor
            // 
            this.txtActor.Location = new System.Drawing.Point(70, 21);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(121, 20);
            this.txtActor.TabIndex = 8;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(6, 123);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(6, 99);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Título";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(6, 75);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(44, 13);
            this.lblDirector.TabIndex = 5;
            this.lblDirector.Text = "Director";
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(6, 50);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(45, 13);
            this.lblFormato.TabIndex = 4;
            this.lblFormato.Text = "Formato";
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.Location = new System.Drawing.Point(6, 24);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(32, 13);
            this.lblActor.TabIndex = 3;
            this.lblActor.Text = "Actor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(860, 466);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(313, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmBusquedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmBusquedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBusquedas";
            this.gbxBuscar.ResumeLayout(false);
            this.gbxBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbxBuscar;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.ComboBox cboFormato;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
    }
}