namespace TP
{
    partial class frmMaterial
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
            this.dtgMateriales = new System.Windows.Forms.DataGridView();
            this.gbxCopia = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblIdCopia = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblPrecioSigno = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cboFormato = new System.Windows.Forms.ComboBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.btnCancelarCopia = new System.Windows.Forms.Button();
            this.btnAceptarCopia = new System.Windows.Forms.Button();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.lblTituloCopia = new System.Windows.Forms.Label();
            this.gbxMaterial = new System.Windows.Forms.GroupBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rbtnEstreno = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMateriales)).BeginInit();
            this.gbxCopia.SuspendLayout();
            this.gbxMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgMateriales
            // 
            this.dtgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMateriales.Location = new System.Drawing.Point(12, 292);
            this.dtgMateriales.Name = "dtgMateriales";
            this.dtgMateriales.Size = new System.Drawing.Size(860, 343);
            this.dtgMateriales.TabIndex = 8;
            // 
            // gbxCopia
            // 
            this.gbxCopia.Controls.Add(this.lblID);
            this.gbxCopia.Controls.Add(this.lblIdCopia);
            this.gbxCopia.Controls.Add(this.txtDias);
            this.gbxCopia.Controls.Add(this.lblDias);
            this.gbxCopia.Controls.Add(this.lblPrecioSigno);
            this.gbxCopia.Controls.Add(this.txtPrecio);
            this.gbxCopia.Controls.Add(this.lblPrecio);
            this.gbxCopia.Controls.Add(this.cboFormato);
            this.gbxCopia.Controls.Add(this.lblFormato);
            this.gbxCopia.Controls.Add(this.btnCancelarCopia);
            this.gbxCopia.Controls.Add(this.btnAceptarCopia);
            this.gbxCopia.Controls.Add(this.cboMaterial);
            this.gbxCopia.Controls.Add(this.lblTituloCopia);
            this.gbxCopia.Location = new System.Drawing.Point(429, 19);
            this.gbxCopia.Name = "gbxCopia";
            this.gbxCopia.Size = new System.Drawing.Size(443, 239);
            this.gbxCopia.TabIndex = 7;
            this.gbxCopia.TabStop = false;
            this.gbxCopia.Text = "Copias";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(127, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 19;
            // 
            // lblIdCopia
            // 
            this.lblIdCopia.AutoSize = true;
            this.lblIdCopia.Location = new System.Drawing.Point(15, 36);
            this.lblIdCopia.Name = "lblIdCopia";
            this.lblIdCopia.Size = new System.Drawing.Size(47, 13);
            this.lblIdCopia.TabIndex = 18;
            this.lblIdCopia.Text = "ID copia";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(127, 170);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(121, 20);
            this.txtDias.TabIndex = 17;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(15, 173);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(79, 13);
            this.lblDias.TabIndex = 16;
            this.lblDias.Text = "Dias de alquiler";
            // 
            // lblPrecioSigno
            // 
            this.lblPrecioSigno.AutoSize = true;
            this.lblPrecioSigno.Location = new System.Drawing.Point(158, 140);
            this.lblPrecioSigno.Name = "lblPrecioSigno";
            this.lblPrecioSigno.Size = new System.Drawing.Size(13, 13);
            this.lblPrecioSigno.TabIndex = 15;
            this.lblPrecioSigno.Text = "$";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(177, 137);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(71, 20);
            this.txtPrecio.TabIndex = 14;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(15, 140);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio";
            // 
            // cboFormato
            // 
            this.cboFormato.FormattingEnabled = true;
            this.cboFormato.Location = new System.Drawing.Point(127, 103);
            this.cboFormato.Name = "cboFormato";
            this.cboFormato.Size = new System.Drawing.Size(121, 21);
            this.cboFormato.TabIndex = 9;
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(15, 106);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(45, 13);
            this.lblFormato.TabIndex = 8;
            this.lblFormato.Text = "Formato";
            // 
            // btnCancelarCopia
            // 
            this.btnCancelarCopia.Location = new System.Drawing.Point(127, 210);
            this.btnCancelarCopia.Name = "btnCancelarCopia";
            this.btnCancelarCopia.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCopia.TabIndex = 7;
            this.btnCancelarCopia.Text = "Cancelar";
            this.btnCancelarCopia.UseVisualStyleBackColor = true;
            // 
            // btnAceptarCopia
            // 
            this.btnAceptarCopia.Location = new System.Drawing.Point(18, 210);
            this.btnAceptarCopia.Name = "btnAceptarCopia";
            this.btnAceptarCopia.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarCopia.TabIndex = 6;
            this.btnAceptarCopia.Text = "Aceptar";
            this.btnAceptarCopia.UseVisualStyleBackColor = true;
            // 
            // cboMaterial
            // 
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Location = new System.Drawing.Point(127, 68);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(121, 21);
            this.cboMaterial.TabIndex = 2;
            // 
            // lblTituloCopia
            // 
            this.lblTituloCopia.AutoSize = true;
            this.lblTituloCopia.Location = new System.Drawing.Point(15, 71);
            this.lblTituloCopia.Name = "lblTituloCopia";
            this.lblTituloCopia.Size = new System.Drawing.Size(33, 13);
            this.lblTituloCopia.TabIndex = 1;
            this.lblTituloCopia.Text = "Titulo";
            // 
            // gbxMaterial
            // 
            this.gbxMaterial.Controls.Add(this.cboTipo);
            this.gbxMaterial.Controls.Add(this.lblTipo);
            this.gbxMaterial.Controls.Add(this.cboClasificacion);
            this.gbxMaterial.Controls.Add(this.cboCategoria);
            this.gbxMaterial.Controls.Add(this.txtTitulo);
            this.gbxMaterial.Controls.Add(this.btnCancelar);
            this.gbxMaterial.Controls.Add(this.btnAceptar);
            this.gbxMaterial.Controls.Add(this.rbtnEstreno);
            this.gbxMaterial.Controls.Add(this.lblTitulo);
            this.gbxMaterial.Controls.Add(this.lblClasificacion);
            this.gbxMaterial.Controls.Add(this.lblCategoria);
            this.gbxMaterial.Location = new System.Drawing.Point(12, 19);
            this.gbxMaterial.Name = "gbxMaterial";
            this.gbxMaterial.Size = new System.Drawing.Size(365, 239);
            this.gbxMaterial.TabIndex = 6;
            this.gbxMaterial.TabStop = false;
            this.gbxMaterial.Text = "Material";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(122, 102);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 13;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(15, 105);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 12;
            this.lblTipo.Text = "Tipo";
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(122, 135);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(121, 21);
            this.cboClasificacion.TabIndex = 11;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(122, 68);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 10;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(122, 33);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(121, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(122, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(18, 210);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // rbtnEstreno
            // 
            this.rbtnEstreno.AutoSize = true;
            this.rbtnEstreno.Location = new System.Drawing.Point(18, 175);
            this.rbtnEstreno.Name = "rbtnEstreno";
            this.rbtnEstreno.Size = new System.Drawing.Size(62, 17);
            this.rbtnEstreno.TabIndex = 3;
            this.rbtnEstreno.Text = "Estreno";
            this.rbtnEstreno.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(15, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(15, 138);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(66, 13);
            this.lblClasificacion.TabIndex = 2;
            this.lblClasificacion.Text = "Clasificación";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(15, 71);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoría";
            // 
            // frmMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.dtgMateriales);
            this.Controls.Add(this.gbxCopia);
            this.Controls.Add(this.gbxMaterial);
            this.Name = "frmMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMaterial";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMateriales)).EndInit();
            this.gbxCopia.ResumeLayout(false);
            this.gbxCopia.PerformLayout();
            this.gbxMaterial.ResumeLayout(false);
            this.gbxMaterial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMateriales;
        private System.Windows.Forms.GroupBox gbxCopia;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIdCopia;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblPrecioSigno;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cboFormato;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Button btnCancelarCopia;
        private System.Windows.Forms.Button btnAceptarCopia;
        private System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.Label lblTituloCopia;
        private System.Windows.Forms.GroupBox gbxMaterial;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboClasificacion;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox rbtnEstreno;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblCategoria;
    }
}