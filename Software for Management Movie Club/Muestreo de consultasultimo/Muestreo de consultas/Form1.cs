using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muestreo_de_consultas
{
    public partial class Form1 : Form
    {
        SQL datos;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mostrarQueSociosVinieronEntreFecchasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datos = new SQL();
        }

        private void rbtConsulta1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbtConsulta1.Checked || rbtConsulta2.Checked || rbtConsulta3.Checked || rbtConsulta4.Checked || rbtConsulta5.Checked || rbtConsulta6.Checked)
            {
                if (rbtConsulta1.Checked)
                {
                    if (txtLetra1S1.Text != "" && txtLetra2S1.Text != "")
                    {
                        dtaGridSocios.DataSource = datos.consulta1(dtp1S1.Text, Convert.ToDateTime(dtp2S1.Text).ToString("dd/MM/yyyy"), txtLetra1S1.Text, txtLetra2S1.Text);
                        dtaGridSocios.Columns[0].Width = 150;
                        dtaGridSocios.Columns[1].Width = 150;
                        dtaGridSocios.Columns[2].Width = 150;
                        dtaGridSocios.Columns[3].Width = 150;
                        dtaGridSocios.Columns[4].Width = 150;
                        dtaGridSocios.Columns[5].Width = 92;
                        dtaGridSocios.Columns[6].Width = 150;
                    }
                    else
                    {
                        MessageBox.Show("Hay campos incompletos, por favor verifique.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

                if (rbtConsulta2.Checked)
                {
                    if(cboS2.SelectedIndex != -1)
                    {
                        dtaGridSocios.DataSource = datos.consulta2(cboS2.SelectedIndex);
                        dtaGridSocios.Columns[0].Width = 250;
                        dtaGridSocios.Columns[1].Width = 250;
                    }
                    else
                    {
                        MessageBox.Show("Hay campos incompletos, por favor verifique.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                if (rbtConsulta3.Checked)
                {
                    if (txtS3.Text != "" && cboS3.SelectedIndex != -1)
                    {
                        dtaGridSocios.DataSource = datos.consulta3(cboS3.Text, Convert.ToInt32(txtS3.Text));
                        dtaGridSocios.Columns[0].Width = 250;
                        dtaGridSocios.Columns[1].Width = 250;
                        dtaGridSocios.Columns[2].Width = 250;
                    }
                    else
                    {
                        MessageBox.Show("Hay campos incompletos, por favor verifique.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                if (rbtConsulta4.Checked)
                {
                    dtaGridSocios.DataSource = datos.consulta4();
                    dtaGridSocios.Columns[0].Width = 250;
                    dtaGridSocios.Columns[1].Width = 250;
                    dtaGridSocios.Columns[2].Width = 250;
                }

                if (rbtConsulta5.Checked)
                {
                    if (txtS5.Text != "")
                    {
                        dtaGridSocios.DataSource = datos.consulta5(Convert.ToInt32(txtS5.Text));
                        dtaGridSocios.Columns[0].Width = 250;
                        dtaGridSocios.Columns[1].Width = 250;
                        dtaGridSocios.Columns[2].Width = 250;
                        dtaGridSocios.Columns[3].Width = 250;
                        
                    }
                    else
                    {
                        MessageBox.Show("Hay campos incompletos, por favor verifique.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                if (rbtConsulta6.Checked)
                {
                    if (txt1S6.Text != "" && txt2S6.Text != "" && cboS6.SelectedIndex != -1)
                    {
                        dtaGridSocios.DataSource = datos.consulta6(cboS6.Text, Convert.ToInt32(txt1S6.Text), Convert.ToInt32(txt2S6.Text));
                        dtaGridSocios.Columns[0].Width = 200;
                        dtaGridSocios.Columns[1].Width = 200;
                        dtaGridSocios.Columns[2].Width = 200;
                        dtaGridSocios.Columns[3].Width = 200;
                        dtaGridSocios.Columns[4].Width = 200;
                    }
                    else
                    {
                        MessageBox.Show("Hay campos incompletos, por favor verifique.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar alguna sentencia para mostrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpiarGrid_Click(object sender, EventArgs e)
        {
            dtaGridSocios.Rows.Clear();
        }

        private void txtLetra1S1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                
                e.Handled = false;
                
            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtLetra2S1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtS3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }

            else
            {
                e.Handled = true;
            }
        }

        private void txt2S6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }

            else
            {
                e.Handled = true;
            }
        }

        private void txt1S6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtS5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }

            else
            {
                e.Handled = true;
            }
        }
    }
}
