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
    public partial class Frm_Registro : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K33EK4L;Initial Catalog=db_Sfarmacia;Integrated Security=True"); 
        public Frm_Registro()
        {
            InitializeComponent();
        }

     

        private void Frm_Registro_Load(object sender, EventArgs e)
        {
           
            cargar_tusu();
        }
        void clear()
        {
            txt_nombre.Text = txt_apellido.Text = txt_nacimiento.Text = txt_dni.Text = txt_contraseña.Text = txt_correo.Text = txt_direccion.Text = "";
            
        }
        private void cargar_tusu()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select rol_id , rol_nombrev from tbl_rol where rol_estado= 'A'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dt.Columns.Add(" rol_id,", typeof(int));
                dt.Columns.Add("rol_nombrev", typeof(string));
                dt.Rows.Add(0, "SELECCIONE");
                sda.Fill(dt);
                con.Close();
                //coje los datos dt o tabla
                cmb_rol.DataSource = dt;
                cmb_rol.DisplayMember = "rol_nombrev";
                cmb_rol.ValueMember = "rol_id";
                con.Close();
            }
            catch (Exception )
            {
                MessageBox.Show("ERROR CARGA ROL ");
               
            }        
                       
        }
        private void saveuser()
        {
            try
            {
                con.Open();
                string query = "insert into Tbl_Usuario values (@nombre,@apellido,@nacimiento,@dni,@contraseña,'A',@correo,@direccion,@tusu)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text.Trim());
                cmd.Parameters.AddWithValue("@apellido", txt_apellido.Text.Trim());
                cmd.Parameters.AddWithValue("@nacimiento", txt_nacimiento.Text.Trim());
                cmd.Parameters.AddWithValue("@dni", txt_dni.Text.Trim());
                cmd.Parameters.AddWithValue("@contraseña", txt_contraseña.Text.Trim());
                cmd.Parameters.AddWithValue("@correo", txt_correo.Text.Trim());
                cmd.Parameters.AddWithValue("@direccion", txt_direccion.Text.Trim());
                cmd.Parameters.AddWithValue("@tusu", Convert.ToInt32(cmb_rol.SelectedValue));
                cmd.ExecuteNonQuery();
                MessageBox.Show("USUARIIO REGRISTRADO");
                clear();


            }
            catch (Exception)
            {

                throw;
            }

        }
      

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
           
            if (txt_nombre.Text.Trim()=="")
            {
                error_nombre.SetError(txt_nombre, "Ingrese nombre...");
                txt_nombre.Focus();
            }
            else
            {
                error_nombre.Clear();  
            }
        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {
            if (txt_apellido.Text.Trim() == "")
            {
                error_apellido.SetError(txt_apellido, "Ingrese apellido...");
                txt_apellido.Focus();
            }
            else
            {
                error_apellido.Clear();
            }
        }

        private void txt_nacimiento_TextChanged(object sender, EventArgs e)
        {
            if (txt_nacimiento.Text.Trim() == "")
            {
                error_nacimiento.SetError(txt_nacimiento, "Ingrese nacimiento...");
               txt_nacimiento.Focus();
            }
            else
            {
                error_nacimiento.Clear();
            }
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            if (txt_dni.Text.Trim() == "")
            {
                error_dni.SetError(txt_dni, "Ingrese dni...");
                txt_dni.Focus();
            }
            else
            {
                error_dni.Clear();
            }
        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {
            if (txt_contraseña.Text.Trim() == "")
            {
                error_contraseña.SetError(txt_contraseña, "Ingrese contraseña...");
                txt_contraseña.Focus();
            }
            else
            {
                error_contraseña.Clear();
            }
        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {
            if (txt_correo.Text.Trim() == "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*")
            {
                error_correo.SetError(txt_correo, "Ingrese un correo valido...");
                txt_correo.Focus();
            }
            else
            {
                error_correo.Clear();
            }
        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {
            if (txt_direccion.Text.Trim() == "")
            {
                error_direccion.SetError(txt_direccion, "Ingrese direcion...");
                txt_direccion.Focus();
            }
            else
            {
                error_direccion.Clear();
            }
        }
          private void btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nombre:" + txt_nombre.Text);
            saveuser();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
