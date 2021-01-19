
namespace DSG
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TBServidor = new Controles_Personalizado.TextBoxIEP();
            this.TBBaseDatos = new Controles_Personalizado.TextBoxIEP();
            this.TBUsuario = new Controles_Personalizado.TextBoxIEP();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBContraseña = new Controles_Personalizado.TextBoxIEP();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBSinCredenciales = new System.Windows.Forms.CheckBox();
            this.ListCBTablas = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTGenerarReporte = new System.Windows.Forms.Button();
            this.CBBGestor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTConeccion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBServidor
            // 
            this.TBServidor.BackColor = System.Drawing.Color.White;
            this.TBServidor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TBServidor.BackgroundImage")));
            this.TBServidor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TBServidor.ErrorProvider = false;
            this.TBServidor.Location = new System.Drawing.Point(26, 34);
            this.TBServidor.MaxLength = 32767;
            this.TBServidor.Multiline = false;
            this.TBServidor.Name = "TBServidor";
            this.TBServidor.Name_ = "TextBox_";
            this.TBServidor.OnlyDecimal = false;
            this.TBServidor.OnlyLetter = false;
            this.TBServidor.OnlyNumery = false;
            this.TBServidor.PlaceHolder = "";
            this.TBServidor.ReadOnly = false;
            this.TBServidor.Size = new System.Drawing.Size(152, 25);
            this.TBServidor.TabIndex = 0;
            this.TBServidor.Text_ = "";
            this.TBServidor.UseSystemPasswordChar = false;
            // 
            // TBBaseDatos
            // 
            this.TBBaseDatos.BackColor = System.Drawing.Color.White;
            this.TBBaseDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TBBaseDatos.BackgroundImage")));
            this.TBBaseDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TBBaseDatos.ErrorProvider = false;
            this.TBBaseDatos.Location = new System.Drawing.Point(201, 34);
            this.TBBaseDatos.MaxLength = 32767;
            this.TBBaseDatos.Multiline = false;
            this.TBBaseDatos.Name = "TBBaseDatos";
            this.TBBaseDatos.Name_ = "TextBox_";
            this.TBBaseDatos.OnlyDecimal = false;
            this.TBBaseDatos.OnlyLetter = false;
            this.TBBaseDatos.OnlyNumery = false;
            this.TBBaseDatos.PlaceHolder = "";
            this.TBBaseDatos.ReadOnly = false;
            this.TBBaseDatos.Size = new System.Drawing.Size(152, 25);
            this.TBBaseDatos.TabIndex = 0;
            this.TBBaseDatos.Text_ = "";
            this.TBBaseDatos.UseSystemPasswordChar = false;
            // 
            // TBUsuario
            // 
            this.TBUsuario.BackColor = System.Drawing.Color.White;
            this.TBUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TBUsuario.BackgroundImage")));
            this.TBUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TBUsuario.Enabled = false;
            this.TBUsuario.ErrorProvider = true;
            this.TBUsuario.Location = new System.Drawing.Point(16, 34);
            this.TBUsuario.MaxLength = 32767;
            this.TBUsuario.Multiline = false;
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Name_ = "TextBox_";
            this.TBUsuario.OnlyDecimal = false;
            this.TBUsuario.OnlyLetter = false;
            this.TBUsuario.OnlyNumery = false;
            this.TBUsuario.PlaceHolder = "";
            this.TBUsuario.ReadOnly = false;
            this.TBUsuario.Size = new System.Drawing.Size(152, 25);
            this.TBUsuario.TabIndex = 0;
            this.TBUsuario.Text_ = "";
            this.TBUsuario.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base de datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuarios";
            // 
            // TBContraseña
            // 
            this.TBContraseña.BackColor = System.Drawing.Color.White;
            this.TBContraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TBContraseña.BackgroundImage")));
            this.TBContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TBContraseña.Enabled = false;
            this.TBContraseña.ErrorProvider = true;
            this.TBContraseña.Location = new System.Drawing.Point(191, 34);
            this.TBContraseña.MaxLength = 32767;
            this.TBContraseña.Multiline = false;
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Name_ = "TextBox_";
            this.TBContraseña.OnlyDecimal = false;
            this.TBContraseña.OnlyLetter = false;
            this.TBContraseña.OnlyNumery = false;
            this.TBContraseña.PlaceHolder = "";
            this.TBContraseña.ReadOnly = false;
            this.TBContraseña.Size = new System.Drawing.Size(152, 25);
            this.TBContraseña.TabIndex = 0;
            this.TBContraseña.Text_ = "";
            this.TBContraseña.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Contraseña";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBSinCredenciales);
            this.groupBox1.Controls.Add(this.TBContraseña);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TBUsuario);
            this.groupBox1.Location = new System.Drawing.Point(10, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // CBSinCredenciales
            // 
            this.CBSinCredenciales.Appearance = System.Windows.Forms.Appearance.Button;
            this.CBSinCredenciales.AutoSize = true;
            this.CBSinCredenciales.BackColor = System.Drawing.Color.Green;
            this.CBSinCredenciales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CBSinCredenciales.Checked = true;
            this.CBSinCredenciales.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBSinCredenciales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBSinCredenciales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBSinCredenciales.Location = new System.Drawing.Point(362, 34);
            this.CBSinCredenciales.Name = "CBSinCredenciales";
            this.CBSinCredenciales.Size = new System.Drawing.Size(96, 23);
            this.CBSinCredenciales.TabIndex = 2;
            this.CBSinCredenciales.Text = "Sin Credenciales";
            this.CBSinCredenciales.UseVisualStyleBackColor = false;
            this.CBSinCredenciales.CheckedChanged += new System.EventHandler(this.CBSinCredenciales_CheckedChanged);
            // 
            // ListCBTablas
            // 
            this.ListCBTablas.BackColor = System.Drawing.Color.White;
            this.ListCBTablas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListCBTablas.ColumnWidth = 250;
            this.ListCBTablas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListCBTablas.ForeColor = System.Drawing.Color.Black;
            this.ListCBTablas.FormattingEnabled = true;
            this.ListCBTablas.Items.AddRange(new object[] {
            "Categoria",
            "Cliente",
            "CreditoCxc",
            "DebitoCxc",
            "DetalleCreditoCxc",
            "DetallePromesaPago",
            "Empleado",
            "EntradaCxc",
            "Garante",
            "GestionCobro",
            "HistoricoGestionCobro",
            "Impresora",
            "ImpresoraOpcionesImpresora",
            "Menu",
            "MenuOpcionesMenu",
            "Ncf",
            "Nivel",
            "OpcionesImpresora",
            "OpcionesMenu",
            "OpcionesPerfile",
            "Perfile",
            "PerfileOpcionesPerfile",
            "PeriodoEnvejecimientoCxc",
            "PromesaPago",
            "Rnc",
            "Sector",
            "SecuenciaNcf",
            "SolicitudCredito",
            "TipoCliente",
            "TipoNcf",
            "Usuario",
            "UsuarioOpcionesImpresora",
            "UsuarioOpcionesMenu",
            "UsuarioOpcionesPerfile",
            "Vendedor",
            "Zona"});
            this.ListCBTablas.Location = new System.Drawing.Point(10, 41);
            this.ListCBTablas.MultiColumn = true;
            this.ListCBTablas.Name = "ListCBTablas";
            this.ListCBTablas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListCBTablas.Size = new System.Drawing.Size(533, 227);
            this.ListCBTablas.Sorted = true;
            this.ListCBTablas.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTConeccion);
            this.groupBox2.Controls.Add(this.CBBGestor);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.TBServidor);
            this.groupBox2.Controls.Add(this.TBBaseDatos);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 191);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de coneccion";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTGenerarReporte);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ListCBTablas);
            this.groupBox3.Location = new System.Drawing.Point(12, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 321);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Base de Datos : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tablas";
            // 
            // BTGenerarReporte
            // 
            this.BTGenerarReporte.Location = new System.Drawing.Point(10, 278);
            this.BTGenerarReporte.Name = "BTGenerarReporte";
            this.BTGenerarReporte.Size = new System.Drawing.Size(533, 29);
            this.BTGenerarReporte.TabIndex = 5;
            this.BTGenerarReporte.Text = "Generar Reporte";
            this.BTGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // CBBGestor
            // 
            this.CBBGestor.FormattingEnabled = true;
            this.CBBGestor.Items.AddRange(new object[] {
            "Seleccione un gestor",
            "Sql Server",
            "My Sql"});
            this.CBBGestor.Location = new System.Drawing.Point(372, 34);
            this.CBBGestor.Name = "CBBGestor";
            this.CBBGestor.Size = new System.Drawing.Size(140, 21);
            this.CBBGestor.TabIndex = 3;
            this.CBBGestor.Text = "Seleccione un gestor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gestores";
            // 
            // BTConeccion
            // 
            this.BTConeccion.Location = new System.Drawing.Point(10, 147);
            this.BTConeccion.Name = "BTConeccion";
            this.BTConeccion.Size = new System.Drawing.Size(533, 29);
            this.BTConeccion.TabIndex = 6;
            this.BTConeccion.Text = "Conectarse";
            this.BTConeccion.UseVisualStyleBackColor = true;
            this.BTConeccion.Click += new System.EventHandler(this.BTConeccion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 572);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles_Personalizado.TextBoxIEP TBServidor;
        private Controles_Personalizado.TextBoxIEP TBBaseDatos;
        private Controles_Personalizado.TextBoxIEP TBUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controles_Personalizado.TextBoxIEP TBContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CBSinCredenciales;
        private System.Windows.Forms.CheckedListBox ListCBTablas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTGenerarReporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTConeccion;
        private System.Windows.Forms.ComboBox CBBGestor;
        private System.Windows.Forms.Label label6;
    }
}

