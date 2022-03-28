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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Pago().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejemploDataSet3.empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter1.Fill(this.ejemploDataSet3.empleado);
            // TODO: esta línea de código carga datos en la tabla 'ejemploDataSet.empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.ejemploDataSet.empleado);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String query = "insert into empleado (nombre, apellido, direccion, cargo)"
                 + "values (@nombre,@apellido,@direccion,@cargo)";
            SqlCommand cmd = new SqlCommand(query, Conexion.conectar());

            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se guardo el empleado!!");
                updateDataGripView("select * from empleado", "empleado");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String query = "update empleado set nombre=@nombre, apellido=@apellido, direccion=@direccion, cargo=@cargo where id_empleado = @id";
            SqlCommand cmd = new SqlCommand(query, Conexion.conectar());
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);
            cmd.Parameters.AddWithValue("@id", cbSelectId.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se actualizó el empleado!!");
                updateDataGripView("select * from empleado", "empleado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String query = "delete from empleado where id_empleado = @id";
            SqlCommand cmd = new SqlCommand(query, Conexion.conectar());

            cmd.Parameters.AddWithValue("@id", cbSelectId.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se eliminó el empleado!!");
                updateDataGripView("select * from empleado", "empleado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void updateDataGripView(String query, String tbl)
        {
            SqlDataAdapter ada = new SqlDataAdapter(query, Conexion.conectar());
            DataSet ds = new DataSet();
            ada.Fill(ds,tbl);
            dataGridView1.DataSource = ds;

            dataGridView1.DataMember = tbl;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String query = "select * from empleado where nombre like '%" + txtSearch.Text + "%'";
            updateDataGripView(query, "empleado");
        }
    }
}
