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
    public partial class frmSocio : Form
    {
        SQL datos;
        Socio socio;
        bool nuevo;
        public frmSocio()
        {
            InitializeComponent();
        }

        private void frmSocio_Load(object sender, EventArgs e)
        {
            datos = new SQL();
            nuevo = false;
            datos.rellenarCombo("barrios", cboBarrio);
            dgvSocios.DataSource = datos.rellenarGrilla("view_Socios");
            estadosForms(false, true, true, true, false, false);
            dgvSocios.Columns[0].Visible = false;
            dgvSocios.Columns[7].Visible = false;
            dgvSocios.Columns[8].Visible = false;
            dgvSocios.Columns[6].Width = 90;
        }
        private int nSexo()
        {
            int i = 0;
            if (rbtnMasculino.Checked)
            {
                i = 1;
            }

            return i;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            estadosForms(true, false, false, false, true, true);
            txtNombre.Focus();
              
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                socio = new Socio(txtApellido.Text, txtNombre.Text, txtCalle.Text, txtDocumento.Text, txtNumero.Text, txtTelefono.Text,
                        txtEmail.Text, 0, Convert.ToInt32(cboBarrio.SelectedValue), nSexo(), Convert.ToDateTime(dtpFechaNacimiento.Text));
                if (nuevo)
                {
                    datos.abm("insert into Socios(nombre,apellido,documento,calle,numero,telefono,e_mail,id_barrio,sexo,fecha_nacimiento) values('" +
                        socio.pNombre + "','" + socio.pApellido + "','" + socio.pDocumento + "','" + socio.pCalle + "','" + socio.pNumero + "','" +
                        socio.pTelefono + "','" + socio.pEmail + "'," + socio.pId_barrio + "," + socio.pSexo + ",'" + socio.pFechaNacimiento.ToString("MM/dd/yyyy") + "')");

                    dgvSocios.DataSource = datos.rellenarGrilla("view_Socios");
                    limpiar();
                    estadosForms(false, true, true, true, false, false);
                    nuevo = false;
                }
                else
                {
                    socio.pId_persona = Convert.ToInt32(dgvSocios.SelectedCells[0].Value);
                    datos.abm("update socios set apellido = '" + socio.pApellido + "', nombre = '" + socio.pNombre + "', documento  = '" + socio.pDocumento +
                        "', calle = '" + socio.pCalle + "', numero = '" + socio.pNumero + "', telefono = '" + socio.pTelefono +
                        "', e_mail  = '" + socio.pEmail + "', id_barrio  = " + socio.pId_barrio + ", sexo = " + socio.pSexo + ", fecha_nacimiento = '" + socio.pFechaNacimiento.ToString("MM/dd/yyyy") +
                        "' where id_socio = " + socio.pId_persona);

                    dgvSocios.DataSource = datos.rellenarGrilla("view_Socios");
                    limpiar();
                    estadosForms(false, true, true, true, false, false);
                } 
            }
            else
            {
                MessageBox.Show("Tiene campos incompletos o incorrectos, por favor verifique.", "Error al validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void estadosForms(bool gpbox, bool eNuevo, bool eModificar, bool eEliminar, bool eAceptar, bool eCancelar)
        {
            gpbxSocios.Enabled = gpbox;
            btnNuevo.Enabled = eNuevo;
            btnModificar.Enabled = eModificar;
            btnEliminar.Enabled = eEliminar;
            btnAceptar.Enabled = eAceptar;
            btnCancelar.Enabled = eCancelar;
        }
        private void limpiar()
        {
            txtApellido.Clear();
            txtCalle.Clear();
            txtDocumento.Clear();
            txtEmail.Clear();
            txtNombre.Clear();
            txtNumero.Clear();
            txtTelefono.Clear();
            cboBarrio.SelectedIndex = -1;
            dtpFechaNacimiento.Text = DateTime.Now.ToString("dd/MM/yyyy");
            rbtnFemenino.Checked = false;
            rbtnMasculino.Checked = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            estadosForms(false, true, true, true, false, false);
        }
        private bool validar()
        {
            bool r = false;
            if (txtApellido.Text != "" && txtCalle.Text != "" && txtDocumento.Text != "" && txtEmail.Text != "" && txtNombre.Text != ""
            && txtNumero.Text != "" && txtTelefono.Text != "" && cboBarrio.SelectedIndex != -1 && dtpFechaNacimiento.Text != "" && (rbtnFemenino.Checked || rbtnMasculino.Checked))
            {
                r = true;
            }
            return r;
        }

        

        private void dgvSocios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvSocios.Rows[dgvSocios.CurrentCell.RowIndex].Selected = true;
            

            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count == 1)
            {
                nuevo = false;
                int id = dgvSocios.CurrentCell.RowIndex;
                estadosForms(true, false, false, false, true, true);
                cargarSocio();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un item de la lista antes de modificar un registro.","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }
        private void cargarSocio()
        {
            txtNombre.Text = Convert.ToString(dgvSocios.CurrentRow.Cells[1].Value); 
            txtApellido.Text = Convert.ToString(dgvSocios.CurrentRow.Cells[2].Value);
            txtDocumento.Text = Convert.ToString(dgvSocios.CurrentRow.Cells[3].Value);
            txtTelefono.Text = Convert.ToString(dgvSocios.CurrentRow.Cells[4].Value);
            txtCalle.Text = Convert.ToString(dgvSocios.CurrentRow.Cells[5].Value);
            txtNumero.Text = Convert.ToString(dgvSocios.CurrentRow.Cells[6].Value);
            cboBarrio.SelectedValue = Convert.ToInt32(dgvSocios.CurrentRow.Cells[7].Value);
            if (Convert.ToInt32(dgvSocios.CurrentRow.Cells[8].Value) == 0)
            {
                rbtnFemenino.Checked = true;
            }
            else
            {
                if (Convert.ToInt32(dgvSocios.CurrentRow.Cells[8].Value) == 1)
                {
                    rbtnMasculino.Checked = true;
                }
            }
            dtpFechaNacimiento.Text = Convert.ToString(dgvSocios.CurrentRow.Cells[9].Value);
            txtEmail.Text = Convert.ToString(dgvSocios.CurrentRow.Cells[10].Value); 

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvSocios.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar este socio?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try
                    {
                        socio = new Socio();
                        socio.pId_persona = Convert.ToInt32(dgvSocios.CurrentRow.Cells[0].Value);
                        datos.abm("delete from socios where id_socio = " + socio.pId_persona);
                        limpiar();
                        dgvSocios.DataSource = datos.rellenarGrilla("view_Socios");
                    }
                    catch
                    {
                        MessageBox.Show("Este cliente no se puede eliminar ó ocurrio un error en el intento.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }

            }
            
            else
            {
                MessageBox.Show("Debe seleccionar un item de la lista antes de eliminar un registro.","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
           
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmReport formReport = new frmReport();
            formReport.Show();
        }

        private void dgvSocios_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvSocios.Rows[dgvSocios.CurrentCell.RowIndex].Selected = true;
        }

        

       
    }
}
