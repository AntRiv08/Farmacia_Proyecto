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
using Farmacia.Vistas;

namespace Farmacia
{
    public partial class frm_login : Form
    {
        //Conexion con la base de datos

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K33EK4L;Initial Catalog=db_Sfarmacia;Integrated Security=true");

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
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            logear(txt_usuario.Text, txt_pass.Text);
        }
        private void logear(string nombre, string pass)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_usuario where usu_nombre= @nom" , con);
                cmd.Parameters.AddWithValue("nom", nombre);
                string nombreusu = nombre;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                if (dt.Rows.Count == 1)
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select usu_nombre, rol_id from tbl_usuario where usu_nombre= @nom and usu_contraseña = @passw", con);
                    cmd1.Parameters.AddWithValue("nom", nombre);
                    cmd1.Parameters.AddWithValue("passw", pass);
                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);

                    con.Close();
                    if (dt1.Rows.Count == 1)
                    {
                        this.Hide();
                        if (dt1.Rows[0][1].ToString() == "1")
                        {
                            Frm_ListadocClientes capadmin = new Frm_ListadocClientes();
                            capadmin.ShowDialog();
                            
                        }
                        else if (dt1.Rows[0][1].ToString() == "2")
                        {
                            FrmFarmacia capfarm = new FrmFarmacia();
                            capfarm.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("usuario no registrado");
                }
                       
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        

        private void frm_login_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Registro capregistro = new Frm_Registro();
            capregistro.ShowDialog();
        }
    }
}
