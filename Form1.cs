using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BackLog
{
    public partial class Form1 : Form
    {
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["GestionVentasBD"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    MostrarEstado(true);
                }
            }
            catch (Exception)
            {
                MostrarEstado(false);
            }
        }
        private void MostrarEstado(bool conectado)
        {
            lblEstadoBD.Text = conectado ? "Estado BD: Conectado a LocalDB" : "Estado BD: Desconectado";
            lblEstadoBD.ForeColor = conectado ? Color.DarkGreen : Color.DarkRed;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = null;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    MostrarEstado(true);
                    string consulta = "SELECT Id, Cliente, Monto, FechaVenta FROM dbo.Ventas WHERE FechaVenta >= @FechaInicio ORDER BY FechaVenta DESC, Id DESC";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = dtpFechaInicio.Value.Date;
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            DataTable ventas = new DataTable();
                            adaptador.Fill(ventas);
                            dgvVentas.DataSource = ventas;
                        }
                    }
                }
            }
            catch (Exception ex)
                {
                    Form1_Load(sender, e);
                    MessageBox.Show("No se pudieron consultar las ventas. Revise la conexión y la tabla Ventas.\n\n" + ex.Message,
                        "Consulta de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}

