using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkShop
{
    public partial class Pago : Form
    {
        public Pago()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejemploDataSet2.empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.ejemploDataSet2.empleado);
            // TODO: esta línea de código carga datos en la tabla 'ejemploDataSet1.pagos' Puede moverla o quitarla según sea necesario.
            this.pagosTableAdapter.Fill(this.ejemploDataSet1.pagos);

        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            double ihss = 0;
            double fosovi = 0;
            double neto_pago = 0;
            double total_deducciones = 0;
            var empleado = cbEmpleado.Text;
            double pago = double.Parse(txtPago.Text);

            if (pago > 7000)
            {
                ihss = pago * 0.035;
            }
            else
            {
                ihss = 7000 * 0.035;
            }

            fosovi = pago * 0.025;

            total_deducciones = fosovi + ihss;

            neto_pago = pago - total_deducciones;

            String query = "insert into pagos (pago, ihss, fosovi, neto_pagar, total_deducciones, empleado)"
                + "values (@pago, @ihss, @fosovi, @neto_pagar, @total_deducciones, @empleado)";

            SqlCommand cmd = new SqlCommand(query, Conexion.conectar());

            cmd.Parameters.AddWithValue("@pago", pago);
            cmd.Parameters.AddWithValue("@ihss", ihss);
            cmd.Parameters.AddWithValue("@fosovi", fosovi);
            cmd.Parameters.AddWithValue("@neto_pagar", neto_pago);
            cmd.Parameters.AddWithValue("@total_deducciones", total_deducciones);
            cmd.Parameters.AddWithValue("@empleado", empleado);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pago realizado");
                updateDataGripView("select * from pagos", "pagos");


            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateDataGripView(String query, String tbl)
        {
            SqlDataAdapter ada = new SqlDataAdapter(query, Conexion.conectar());
            DataSet ds = new DataSet();
            ada.Fill(ds, tbl);
            dataGridView1.DataSource = ds;

            dataGridView1.DataMember = tbl;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            String query = "select * from pagos where empleado=" + cbEmpleado.Text;
            updateDataGripView("select * from pagos", "pagos");
        }
    }
}
