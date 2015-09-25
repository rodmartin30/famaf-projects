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
    public partial class frmReport : Form
    {
        SQL datos;
        public frmReport()
        {
            InitializeComponent();
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            rCrystal miReporte = new rCrystal();
            crystalReportViewer1.ReportSource = miReporte;
            crystalReportViewer1.Show();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            datos = new SQL();
            datos.rellenarCombo("barrios", cboBarrios);
        }

        private void btnRestringida_Click(object sender, EventArgs e)
        {
            rCrystal miReporte = new rCrystal();
            string sql = "SELECT * FROM Socios WHERE id_barrio=" + Convert.ToInt32(cboBarrios.SelectedValue) ;
            DataTable dt = new DataTable();
            dt = datos.consultar(sql);

            miReporte.SetDataSource(dt);

            crystalReportViewer1.ReportSource = miReporte;
            crystalReportViewer1.Show();

        }
    }
}
