
namespace DSG
{
    partial class DSG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSG));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GBCredenciales = new System.Windows.Forms.GroupBox();
            this.TBUsuario = new Controles_Personalizado.TextBoxIEP();
            this.TBContraseña = new Controles_Personalizado.TextBoxIEP();
            this.CBSinCredenciales = new System.Windows.Forms.CheckBox();
            this.ListCBTablas = new System.Windows.Forms.CheckedListBox();
            this.GBDatosConexion = new System.Windows.Forms.GroupBox();
            this.CBBBaseDatos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBCompanyName = new Controles_Personalizado.TextBoxIEP();
            this.TBServidor = new Controles_Personalizado.TextBoxIEP();
            this.BTBuscarBaseDatos = new System.Windows.Forms.Button();
            this.BTConeccion = new System.Windows.Forms.Button();
            this.GBBaseDatos = new System.Windows.Forms.GroupBox();
            this.CBView = new System.Windows.Forms.ComboBox();
            this.CBMarcarTodasTablas = new System.Windows.Forms.CheckBox();
            this.BTGenerarReporte = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GBCredenciales.SuspendLayout();
            this.GBDatosConexion.SuspendLayout();
            this.GBBaseDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 94);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Contraseña";
            // 
            // GBCredenciales
            // 
            this.GBCredenciales.Controls.Add(this.TBUsuario);
            this.GBCredenciales.Controls.Add(this.TBContraseña);
            this.GBCredenciales.Controls.Add(this.CBSinCredenciales);
            this.GBCredenciales.Controls.Add(this.label3);
            this.GBCredenciales.Controls.Add(this.label4);
            this.GBCredenciales.Location = new System.Drawing.Point(313, 19);
            this.GBCredenciales.Name = "GBCredenciales";
            this.GBCredenciales.Size = new System.Drawing.Size(230, 176);
            this.GBCredenciales.TabIndex = 2;
            this.GBCredenciales.TabStop = false;
            this.GBCredenciales.Text = "Credenciales";
            // 
            // TBUsuario
            // 
            this.TBUsuario.BackColor = System.Drawing.Color.White;
            this.TBUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TBUsuario.BackgroundImage")));
            this.TBUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TBUsuario.Enabled = false;
            this.TBUsuario.ErrorProvider = true;
            this.TBUsuario.Location = new System.Drawing.Point(6, 37);
            this.TBUsuario.MaxLength = 32767;
            this.TBUsuario.Multiline = false;
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Name_ = "TextBox_";
            this.TBUsuario.OnlyDecimal = false;
            this.TBUsuario.OnlyLetter = false;
            this.TBUsuario.OnlyNumery = false;
            this.TBUsuario.PlaceHolder = "";
            this.TBUsuario.ReadOnly = false;
            this.TBUsuario.Size = new System.Drawing.Size(218, 25);
            this.TBUsuario.TabIndex = 3;
            this.TBUsuario.Text_ = "";
            this.TBUsuario.UseSystemPasswordChar = false;
            // 
            // TBContraseña
            // 
            this.TBContraseña.BackColor = System.Drawing.Color.White;
            this.TBContraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TBContraseña.BackgroundImage")));
            this.TBContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TBContraseña.Enabled = false;
            this.TBContraseña.ErrorProvider = true;
            this.TBContraseña.Location = new System.Drawing.Point(6, 91);
            this.TBContraseña.MaxLength = 32767;
            this.TBContraseña.Multiline = false;
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Name_ = "TextBox_";
            this.TBContraseña.OnlyDecimal = false;
            this.TBContraseña.OnlyLetter = false;
            this.TBContraseña.OnlyNumery = false;
            this.TBContraseña.PlaceHolder = "";
            this.TBContraseña.ReadOnly = false;
            this.TBContraseña.Size = new System.Drawing.Size(218, 25);
            this.TBContraseña.TabIndex = 3;
            this.TBContraseña.Text_ = "";
            this.TBContraseña.UseSystemPasswordChar = false;
            // 
            // CBSinCredenciales
            // 
            this.CBSinCredenciales.Appearance = System.Windows.Forms.Appearance.Button;
            this.CBSinCredenciales.AutoSize = true;
            this.CBSinCredenciales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.CBSinCredenciales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CBSinCredenciales.Checked = true;
            this.CBSinCredenciales.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBSinCredenciales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBSinCredenciales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBSinCredenciales.Location = new System.Drawing.Point(6, 134);
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
            this.ListCBTablas.Location = new System.Drawing.Point(10, 78);
            this.ListCBTablas.MultiColumn = true;
            this.ListCBTablas.Name = "ListCBTablas";
            this.ListCBTablas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListCBTablas.Size = new System.Drawing.Size(533, 197);
            this.ListCBTablas.Sorted = true;
            this.ListCBTablas.TabIndex = 3;
            // 
            // GBDatosConexion
            // 
            this.GBDatosConexion.Controls.Add(this.CBBBaseDatos);
            this.GBDatosConexion.Controls.Add(this.label6);
            this.GBDatosConexion.Controls.Add(this.TBCompanyName);
            this.GBDatosConexion.Controls.Add(this.TBServidor);
            this.GBDatosConexion.Controls.Add(this.BTBuscarBaseDatos);
            this.GBDatosConexion.Controls.Add(this.BTConeccion);
            this.GBDatosConexion.Controls.Add(this.GBCredenciales);
            this.GBDatosConexion.Controls.Add(this.label2);
            this.GBDatosConexion.Controls.Add(this.label1);
            this.GBDatosConexion.Location = new System.Drawing.Point(12, 12);
            this.GBDatosConexion.Name = "GBDatosConexion";
            this.GBDatosConexion.Size = new System.Drawing.Size(555, 259);
            this.GBDatosConexion.TabIndex = 4;
            this.GBDatosConexion.TabStop = false;
            this.GBDatosConexion.Text = "Datos de conexión";
            // 
            // CBBBaseDatos
            // 
            this.CBBBaseDatos.FormattingEnabled = true;
            this.CBBBaseDatos.Location = new System.Drawing.Point(22, 110);
            this.CBBBaseDatos.Name = "CBBBaseDatos";
            this.CBBBaseDatos.Size = new System.Drawing.Size(271, 21);
            this.CBBBaseDatos.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nombre de la compañia";
            // 
            // TBCompanyName
            // 
            this.TBCompanyName.BackColor = System.Drawing.Color.White;
            this.TBCompanyName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TBCompanyName.BackgroundImage")));
            this.TBCompanyName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TBCompanyName.ErrorProvider = true;
            this.TBCompanyName.Location = new System.Drawing.Point(22, 164);
            this.TBCompanyName.MaxLength = 32767;
            this.TBCompanyName.Multiline = false;
            this.TBCompanyName.Name = "TBCompanyName";
            this.TBCompanyName.Name_ = "TextBox_";
            this.TBCompanyName.OnlyDecimal = false;
            this.TBCompanyName.OnlyLetter = false;
            this.TBCompanyName.OnlyNumery = false;
            this.TBCompanyName.PlaceHolder = "";
            this.TBCompanyName.ReadOnly = false;
            this.TBCompanyName.Size = new System.Drawing.Size(271, 25);
            this.TBCompanyName.TabIndex = 7;
            this.TBCompanyName.Text_ = "TRIDENTE SRL";
            this.TBCompanyName.UseSystemPasswordChar = false;
            // 
            // TBServidor
            // 
            this.TBServidor.BackColor = System.Drawing.Color.White;
            this.TBServidor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TBServidor.BackgroundImage")));
            this.TBServidor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TBServidor.ErrorProvider = true;
            this.TBServidor.Location = new System.Drawing.Point(22, 56);
            this.TBServidor.MaxLength = 32767;
            this.TBServidor.Multiline = false;
            this.TBServidor.Name = "TBServidor";
            this.TBServidor.Name_ = "TextBox_";
            this.TBServidor.OnlyDecimal = false;
            this.TBServidor.OnlyLetter = false;
            this.TBServidor.OnlyNumery = false;
            this.TBServidor.PlaceHolder = "";
            this.TBServidor.ReadOnly = false;
            this.TBServidor.Size = new System.Drawing.Size(271, 25);
            this.TBServidor.TabIndex = 3;
            this.TBServidor.Text_ = "(LOCALDB)\\MSSQLLOCALDB";
            this.TBServidor.UseSystemPasswordChar = false;
            // 
            // BTBuscarBaseDatos
            // 
            this.BTBuscarBaseDatos.Location = new System.Drawing.Point(22, 214);
            this.BTBuscarBaseDatos.Name = "BTBuscarBaseDatos";
            this.BTBuscarBaseDatos.Size = new System.Drawing.Size(230, 29);
            this.BTBuscarBaseDatos.TabIndex = 6;
            this.BTBuscarBaseDatos.Text = "Buscar Base de datos";
            this.BTBuscarBaseDatos.UseVisualStyleBackColor = true;
            this.BTBuscarBaseDatos.Click += new System.EventHandler(this.BTBuscarBaseDatos_Click);
            // 
            // BTConeccion
            // 
            this.BTConeccion.Location = new System.Drawing.Point(313, 214);
            this.BTConeccion.Name = "BTConeccion";
            this.BTConeccion.Size = new System.Drawing.Size(230, 29);
            this.BTConeccion.TabIndex = 6;
            this.BTConeccion.Text = "Conectarse";
            this.BTConeccion.UseVisualStyleBackColor = true;
            this.BTConeccion.Click += new System.EventHandler(this.BTConeccion_Click);
            // 
            // GBBaseDatos
            // 
            this.GBBaseDatos.Controls.Add(this.CBView);
            this.GBBaseDatos.Controls.Add(this.CBMarcarTodasTablas);
            this.GBBaseDatos.Controls.Add(this.BTGenerarReporte);
            this.GBBaseDatos.Controls.Add(this.label7);
            this.GBBaseDatos.Controls.Add(this.label5);
            this.GBBaseDatos.Controls.Add(this.ListCBTablas);
            this.GBBaseDatos.Location = new System.Drawing.Point(12, 286);
            this.GBBaseDatos.Name = "GBBaseDatos";
            this.GBBaseDatos.Size = new System.Drawing.Size(555, 321);
            this.GBBaseDatos.TabIndex = 5;
            this.GBBaseDatos.TabStop = false;
            this.GBBaseDatos.Text = "Base de Datos : ";
            // 
            // CBView
            // 
            this.CBView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBView.FormattingEnabled = true;
            this.CBView.Items.AddRange(new object[] {
            "Tablas",
            "Vistas",
            "Procedimientos",
            "Triggers"});
            this.CBView.Location = new System.Drawing.Point(440, 34);
            this.CBView.Name = "CBView";
            this.CBView.Size = new System.Drawing.Size(103, 21);
            this.CBView.TabIndex = 7;
            // 
            // CBMarcarTodasTablas
            // 
            this.CBMarcarTodasTablas.AutoSize = true;
            this.CBMarcarTodasTablas.Location = new System.Drawing.Point(13, 54);
            this.CBMarcarTodasTablas.Name = "CBMarcarTodasTablas";
            this.CBMarcarTodasTablas.Size = new System.Drawing.Size(135, 17);
            this.CBMarcarTodasTablas.TabIndex = 6;
            this.CBMarcarTodasTablas.Text = "Marcar todas las tablas";
            this.CBMarcarTodasTablas.UseVisualStyleBackColor = true;
            this.CBMarcarTodasTablas.CheckedChanged += new System.EventHandler(this.CBMarcarTodasTablas_CheckedChanged);
            // 
            // BTGenerarReporte
            // 
            this.BTGenerarReporte.Location = new System.Drawing.Point(10, 283);
            this.BTGenerarReporte.Name = "BTGenerarReporte";
            this.BTGenerarReporte.Size = new System.Drawing.Size(533, 29);
            this.BTGenerarReporte.TabIndex = 5;
            this.BTGenerarReporte.Text = "Generar Reporte";
            this.BTGenerarReporte.UseVisualStyleBackColor = true;
            this.BTGenerarReporte.Click += new System.EventHandler(this.BTGenerarReporte_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ver";
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
            // DSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 622);
            this.Controls.Add(this.GBBaseDatos);
            this.Controls.Add(this.GBDatosConexion);
            this.Name = "DSG";
            this.Text = "Form1";
            this.GBCredenciales.ResumeLayout(false);
            this.GBCredenciales.PerformLayout();
            this.GBDatosConexion.ResumeLayout(false);
            this.GBDatosConexion.PerformLayout();
            this.GBBaseDatos.ResumeLayout(false);
            this.GBBaseDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private Controles_Personalizado.TextBoxIEP TBServidor;
        private Controles_Personalizado.TextBoxIEP TBUsuario;
        private Controles_Personalizado.TextBoxIEP TBContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GBCredenciales;
        private System.Windows.Forms.CheckBox CBSinCredenciales;
        private System.Windows.Forms.CheckedListBox ListCBTablas;
        private System.Windows.Forms.GroupBox GBDatosConexion;
        private System.Windows.Forms.GroupBox GBBaseDatos;
        private System.Windows.Forms.Button BTGenerarReporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTConeccion;
        private System.Windows.Forms.CheckBox CBMarcarTodasTablas;
        private System.Windows.Forms.Label label6;
        private Controles_Personalizado.TextBoxIEP TBCompanyName;
        private System.Windows.Forms.Button BTBuscarBaseDatos;
        private System.Windows.Forms.ComboBox CBView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBBBaseDatos;
    }
}

