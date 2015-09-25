namespace TP
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnSimple = new System.Windows.Forms.Button();
            this.btnRestringida = new System.Windows.Forms.Button();
            this.cboBarrios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 12);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(860, 568);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // btnSimple
            // 
            this.btnSimple.Location = new System.Drawing.Point(12, 600);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(125, 23);
            this.btnSimple.TabIndex = 2;
            this.btnSimple.Text = "Impresion Simple";
            this.btnSimple.UseVisualStyleBackColor = true;
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // btnRestringida
            // 
            this.btnRestringida.Location = new System.Drawing.Point(737, 600);
            this.btnRestringida.Name = "btnRestringida";
            this.btnRestringida.Size = new System.Drawing.Size(135, 23);
            this.btnRestringida.TabIndex = 5;
            this.btnRestringida.Text = "Impresion Restringida";
            this.btnRestringida.UseVisualStyleBackColor = true;
            this.btnRestringida.Click += new System.EventHandler(this.btnRestringida_Click);
            // 
            // cboBarrios
            // 
            this.cboBarrios.FormattingEnabled = true;
            this.cboBarrios.Location = new System.Drawing.Point(590, 602);
            this.cboBarrios.Name = "cboBarrios";
            this.cboBarrios.Size = new System.Drawing.Size(121, 21);
            this.cboBarrios.TabIndex = 6;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.cboBarrios);
            this.Controls.Add(this.btnRestringida);
            this.Controls.Add(this.btnSimple);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnSimple;
        private System.Windows.Forms.Button btnRestringida;
        private System.Windows.Forms.ComboBox cboBarrios;
    }
}