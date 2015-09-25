using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void abmMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterial formMateriales = new frmMaterial();
            formMateriales.ShowDialog();
        }

        private void abmSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSocio formSocio = new frmSocio();
            formSocio.ShowDialog();
        }

        private void aBMEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado formEmpleado = new frmEmpleado();
            formEmpleado.ShowDialog();
        }
    }
}
