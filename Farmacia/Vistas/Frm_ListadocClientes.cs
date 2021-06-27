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


namespace Farmacia.Vistas
{
   
    public partial class Frm_ListadocClientes : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K33EK4L;Initial Catalog=db_Sfarmacia;Integrated Security=True");
        tbl_usuario modelo = new tbl_usuario();
        public Frm_ListadocClientes()
        {
            InitializeComponent();
            llenar_grid();
        }

        private void Frm_ListadocClientes_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("conexion exitosa");
            dgv_usuarios.DataSource = llenar_grid(); 
        
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Form formulario_crud = new Frm_Registro();
            formulario_crud.Show();
            con.Open();
            MessageBox.Show("conexion exitosa"); 
            dgv_usuarios.DataSource = llenar_grid();
        }
        
        public DataTable llenar_grid()
        {
            
            tbl_usuario grid = new tbl_usuario();
            DataTable dt = new  DataTable();
            SqlCommand cmd = new SqlCommand("Select * from tbl_usuario ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

      
    }
}
