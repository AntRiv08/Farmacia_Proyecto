
namespace Farmacia.Vistas
{
    partial class Frm_Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Registro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.cmb_rol = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nacimiento = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error_nombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_nacimiento = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_contraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_direccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_apellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_dni = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_correo = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_nombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_nacimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_contraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_direccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_apellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_dni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_correo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.cmb_rol);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.txt_correo);
            this.panel1.Controls.Add(this.txt_dni);
            this.panel1.Controls.Add(this.txt_apellido);
            this.panel1.Controls.Add(this.txt_contraseña);
            this.panel1.Controls.Add(this.txt_direccion);
            this.panel1.Controls.Add(this.txt_nacimiento);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 465);
            this.panel1.TabIndex = 0;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(305, 382);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(109, 59);
            this.btn_eliminar.TabIndex = 20;
            this.btn_eliminar.Text = "ELIMINAR ";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // cmb_rol
            // 
            this.cmb_rol.FormattingEnabled = true;
            this.cmb_rol.Location = new System.Drawing.Point(477, 297);
            this.cmb_rol.Name = "cmb_rol";
            this.cmb_rol.Size = new System.Drawing.Size(178, 21);
            this.cmb_rol.TabIndex = 19;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(459, 382);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(137, 59);
            this.btn_cancelar.TabIndex = 18;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(150, 382);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(117, 59);
            this.btn_guardar.TabIndex = 17;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(477, 223);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(178, 20);
            this.txt_correo.TabIndex = 15;
            this.txt_correo.TextChanged += new System.EventHandler(this.txt_correo_TextChanged);
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(477, 157);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(178, 20);
            this.txt_dni.TabIndex = 14;
            this.txt_dni.TextChanged += new System.EventHandler(this.txt_dni_TextChanged);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(477, 98);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(178, 20);
            this.txt_apellido.TabIndex = 13;
            this.txt_apellido.TextChanged += new System.EventHandler(this.txt_apellido_TextChanged);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(188, 228);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(136, 20);
            this.txt_contraseña.TabIndex = 12;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.txt_contraseña_TextChanged);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(188, 296);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(136, 20);
            this.txt_direccion.TabIndex = 11;
            this.txt_direccion.TextChanged += new System.EventHandler(this.txt_direccion_TextChanged);
            // 
            // txt_nacimiento
            // 
            this.txt_nacimiento.Location = new System.Drawing.Point(188, 160);
            this.txt_nacimiento.Name = "txt_nacimiento";
            this.txt_nacimiento.Size = new System.Drawing.Size(136, 20);
            this.txt_nacimiento.TabIndex = 10;
            this.txt_nacimiento.TextChanged += new System.EventHandler(this.txt_nacimiento_TextChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(188, 102);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(136, 20);
            this.txt_nombre.TabIndex = 9;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(375, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "ROL:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "DIRECCION:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(375, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "CORREO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "CONTRASEÑA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA NACIMIENTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRAR USUARIOS ";
            // 
            // error_nombre
            // 
            this.error_nombre.ContainerControl = this;
            // 
            // error_nacimiento
            // 
            this.error_nacimiento.ContainerControl = this;
            // 
            // error_contraseña
            // 
            this.error_contraseña.ContainerControl = this;
            // 
            // error_direccion
            // 
            this.error_direccion.ContainerControl = this;
            // 
            // error_apellido
            // 
            this.error_apellido.ContainerControl = this;
            // 
            // error_dni
            // 
            this.error_dni.ContainerControl = this;
            // 
            // error_correo
            // 
            this.error_correo.ContainerControl = this;
            // 
            // Frm_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 498);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Registro";
            this.Text = "Frm_Registro";
            this.Load += new System.EventHandler(this.Frm_Registro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_nombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_nacimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_contraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_direccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_apellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_dni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_correo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_correo;
        public System.Windows.Forms.TextBox txt_dni;
        public System.Windows.Forms.TextBox txt_apellido;
        public System.Windows.Forms.TextBox txt_contraseña;
        public System.Windows.Forms.TextBox txt_direccion;
        public System.Windows.Forms.TextBox txt_nacimiento;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.ComboBox cmb_rol;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.ErrorProvider error_nombre;
        private System.Windows.Forms.ErrorProvider error_nacimiento;
        private System.Windows.Forms.ErrorProvider error_contraseña;
        private System.Windows.Forms.ErrorProvider error_direccion;
        private System.Windows.Forms.ErrorProvider error_apellido;
        private System.Windows.Forms.ErrorProvider error_dni;
        private System.Windows.Forms.ErrorProvider error_correo;
    }
}