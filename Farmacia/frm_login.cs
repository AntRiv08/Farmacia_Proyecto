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

namespace Farmacia
{
    public partial class frm_login : Form
    {
        //Conexion con la base de datos

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-70AG0U86;Initial Catalog=DB_Farmacias;Integrated Security=True");

        public frm_login() 
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void logear(string nombre, string pass)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_usuario where usu_nombre = @nom", con);
                cmd.Parameters.AddWithValue("nom", nombre);
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
            }
            catch (Exception)
            {
                 
                throw;
            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            logear(txt_usuario.Text, txt_pass.Text);
        }
    }
}
