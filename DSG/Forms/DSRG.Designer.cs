
namespace DSRG
{
    partial class DSRG
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
            this.LBServidor = new System.Windows.Forms.Label();
            this.LBBaseDatos = new System.Windows.Forms.Label();
            this.LBUsuario = new System.Windows.Forms.Label();
            this.LBContrase = new System.Windows.Forms.Label();
            this.GBCredenciales = new System.Windows.Forms.GroupBox();
            this.RBAutenticacionW = new System.Windows.Forms.RadioButton();
            this.RBAutenticacionS = new System.Windows.Forms.RadioButton();
            this.TBUsuario = new Controles_Personalizado.TextBoxIEP();
            this.TBContraseña = new Controles_Personalizado.TextBoxIEP();
            this.ListCBTablas = new System.Windows.Forms.CheckedListBox();
            this.GBDatosConexion = new System.Windows.Forms.GroupBox();
            this.TBCompanyName = new Controles_Personalizado.TextBoxIEP();
            this.CBGuardarDatos = new System.Windows.Forms.CheckBox();
            this.LBNombreCompañia = new System.Windows.Forms.Label();
            this.TBServidor = new Controles_Personalizado.TextBoxIEP();
            this.BTBuscarBaseDatos = new System.Windows.Forms.Button();
            this.BTConeccion = new System.Windows.Forms.Button();
            this.GBBaseDatos = new System.Windows.Forms.GroupBox();
            this.CBMarcarTodasTablas = new System.Windows.Forms.CheckBox();
            this.BTGenerarReporte = new System.Windows.Forms.Button();
            this.LBObtener = new System.Windows.Forms.Label();
            this.LBTablas = new System.Windows.Forms.Label();
            this.PanelBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.LBLogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.BTAcercaDe = new Guna.UI2.WinForms.Guna2Button();
            this.BTAjustes = new Guna.UI2.WinForms.Guna2Button();
            this.CBFileExcel = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CBBBaseDatos = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBView = new System.Windows.Forms.ComboBox();
            this.BTClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BTMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BTMaximize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BTNormal = new Guna.UI2.WinForms.Guna2CircleButton();
            this.GBCredenciales.SuspendLayout();
            this.GBDatosConexion.SuspendLayout();
            this.GBBaseDatos.SuspendLayout();
            this.PanelBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelOpciones.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // LBServidor
            // 
            this.LBServidor.AutoSize = true;
            this.LBServidor.BackColor = System.Drawing.Color.Transparent;
            this.LBServidor.ForeColor = System.Drawing.Color.Black;
            this.LBServidor.Location = new System.Drawing.Point(19, 57);
            this.LBServidor.Name = "LBServidor";
            this.LBServidor.Size = new System.Drawing.Size(46, 13);
            this.LBServidor.TabIndex = 1;
            this.LBServidor.Text = "Servidor";
            // 
            // LBBaseDatos
            // 
            this.LBBaseDatos.AutoSize = true;
            this.LBBaseDatos.BackColor = System.Drawing.Color.Transparent;
            this.LBBaseDatos.ForeColor = System.Drawing.Color.Black;
            this.LBBaseDatos.Location = new System.Drawing.Point(19, 113);
            this.LBBaseDatos.Name = "LBBaseDatos";
            this.LBBaseDatos.Size = new System.Drawing.Size(75, 13);
            this.LBBaseDatos.TabIndex = 1;
            this.LBBaseDatos.Text = "Base de datos";
            // 
            // LBUsuario
            // 
            this.LBUsuario.AutoSize = true;
            this.LBUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LBUsuario.ForeColor = System.Drawing.Color.Black;
            this.LBUsuario.Location = new System.Drawing.Point(13, 22);
            this.LBUsuario.Name = "LBUsuario";
            this.LBUsuario.Size = new System.Drawing.Size(48, 13);
            this.LBUsuario.TabIndex = 1;
            this.LBUsuario.Text = "Usuarios";
            // 
            // LBContrase
            // 
            this.LBContrase.AutoSize = true;
            this.LBContrase.BackColor = System.Drawing.Color.Transparent;
            this.LBContrase.ForeColor = System.Drawing.Color.Black;
            this.LBContrase.Location = new System.Drawing.Point(13, 76);
            this.LBContrase.Name = "LBContrase";
            this.LBContrase.Size = new System.Drawing.Size(61, 13);
            this.LBContrase.TabIndex = 1;
            this.LBContrase.Text = "Contraseña";
            // 
            // GBCredenciales
            // 
            this.GBCredenciales.BackColor = System.Drawing.Color.Transparent;
            this.GBCredenciales.Controls.Add(this.RBAutenticacionW);
            this.GBCredenciales.Controls.Add(this.RBAutenticacionS);
            this.GBCredenciales.Controls.Add(this.TBUsuario);
            this.GBCredenciales.Controls.Add(this.TBContraseña);
            this.GBCredenciales.Controls.Add(this.LBUsuario);
            this.GBCredenciales.Controls.Add(this.LBContrase);
            this.GBCredenciales.ForeColor = System.Drawing.Color.Black;
            this.GBCredenciales.Location = new System.Drawing.Point(313, 19);
            this.GBCredenciales.Name = "GBCredenciales";
            this.GBCredenciales.Size = new System.Drawing.Size(230, 189);
            this.GBCredenciales.TabIndex = 3;
            this.GBCredenciales.TabStop = false;
            this.GBCredenciales.Text = "Credenciales";
            // 
            // RBAutenticacionW
            // 
            this.RBAutenticacionW.AutoSize = true;
            this.RBAutenticacionW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.RBAutenticacionW.Checked = true;
            this.RBAutenticacionW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBAutenticacionW.ForeColor = System.Drawing.Color.Black;
            this.RBAutenticacionW.Location = new System.Drawing.Point(6, 129);
            this.RBAutenticacionW.Name = "RBAutenticacionW";
            this.RBAutenticacionW.Size = new System.Drawing.Size(147, 17);
            this.RBAutenticacionW.TabIndex = 6;
            this.RBAutenticacionW.TabStop = true;
            this.RBAutenticacionW.Text = "Autenticacón de windows";
            this.RBAutenticacionW.UseVisualStyleBackColor = false;
            this.RBAutenticacionW.CheckedChanged += new System.EventHandler(this.RBAutenticacionW_CheckedChanged);
            // 
            // RBAutenticacionS
            // 
            this.RBAutenticacionS.AutoSize = true;
            this.RBAutenticacionS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBAutenticacionS.ForeColor = System.Drawing.Color.Black;
            this.RBAutenticacionS.Location = new System.Drawing.Point(6, 153);
            this.RBAutenticacionS.Name = "RBAutenticacionS";
            this.RBAutenticacionS.Size = new System.Drawing.Size(155, 17);
            this.RBAutenticacionS.TabIndex = 6;
            this.RBAutenticacionS.Text = "Autenticacón de Sql Server";
            this.RBAutenticacionS.UseVisualStyleBackColor = true;
            // 
            // TBUsuario
            // 
            this.TBUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TBUsuario.Enabled = false;
            this.TBUsuario.ErrorProvider = true;
            this.TBUsuario.Location = new System.Drawing.Point(6, 38);
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
            this.TBContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TBContraseña.Enabled = false;
            this.TBContraseña.ErrorProvider = true;
            this.TBContraseña.Location = new System.Drawing.Point(6, 92);
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
            this.TBContraseña.TabIndex = 4;
            this.TBContraseña.Text_ = "";
            this.TBContraseña.UseSystemPasswordChar = true;
            // 
            // ListCBTablas
            // 
            this.ListCBTablas.BackColor = System.Drawing.Color.White;
            this.ListCBTablas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListCBTablas.ColumnWidth = 250;
            this.ListCBTablas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListCBTablas.ForeColor = System.Drawing.Color.Black;
            this.ListCBTablas.FormattingEnabled = true;
            this.ListCBTablas.Location = new System.Drawing.Point(10, 88);
            this.ListCBTablas.MultiColumn = true;
            this.ListCBTablas.Name = "ListCBTablas";
            this.ListCBTablas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListCBTablas.Size = new System.Drawing.Size(533, 197);
            this.ListCBTablas.Sorted = true;
            this.ListCBTablas.TabIndex = 3;
            this.ListCBTablas.TabStop = false;
            // 
            // GBDatosConexion
            // 
            this.GBDatosConexion.BackColor = System.Drawing.Color.White;
            this.GBDatosConexion.Controls.Add(this.panel3);
            this.GBDatosConexion.Controls.Add(this.TBCompanyName);
            this.GBDatosConexion.Controls.Add(this.CBGuardarDatos);
            this.GBDatosConexion.Controls.Add(this.LBNombreCompañia);
            this.GBDatosConexion.Controls.Add(this.TBServidor);
            this.GBDatosConexion.Controls.Add(this.BTBuscarBaseDatos);
            this.GBDatosConexion.Controls.Add(this.GBCredenciales);
            this.GBDatosConexion.Controls.Add(this.LBBaseDatos);
            this.GBDatosConexion.Controls.Add(this.LBServidor);
            this.GBDatosConexion.ForeColor = System.Drawing.Color.Black;
            this.GBDatosConexion.Location = new System.Drawing.Point(0, 0);
            this.GBDatosConexion.Name = "GBDatosConexion";
            this.GBDatosConexion.Size = new System.Drawing.Size(555, 259);
            this.GBDatosConexion.TabIndex = 4;
            this.GBDatosConexion.TabStop = false;
            this.GBDatosConexion.Text = "Datos de conexión";
            // 
            // TBCompanyName
            // 
            this.TBCompanyName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TBCompanyName.ErrorProvider = true;
            this.TBCompanyName.Location = new System.Drawing.Point(22, 183);
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
            this.TBCompanyName.TabIndex = 2;
            this.TBCompanyName.Text_ = "";
            this.TBCompanyName.UseSystemPasswordChar = false;
            // 
            // CBGuardarDatos
            // 
            this.CBGuardarDatos.AutoSize = true;
            this.CBGuardarDatos.BackColor = System.Drawing.Color.Transparent;
            this.CBGuardarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBGuardarDatos.ForeColor = System.Drawing.Color.Black;
            this.CBGuardarDatos.Location = new System.Drawing.Point(22, 27);
            this.CBGuardarDatos.Name = "CBGuardarDatos";
            this.CBGuardarDatos.Size = new System.Drawing.Size(128, 17);
            this.CBGuardarDatos.TabIndex = 9;
            this.CBGuardarDatos.Text = "Guardar ultimos datos";
            this.CBGuardarDatos.UseVisualStyleBackColor = false;
            // 
            // LBNombreCompañia
            // 
            this.LBNombreCompañia.AutoSize = true;
            this.LBNombreCompañia.BackColor = System.Drawing.Color.Transparent;
            this.LBNombreCompañia.ForeColor = System.Drawing.Color.Black;
            this.LBNombreCompañia.Location = new System.Drawing.Point(19, 167);
            this.LBNombreCompañia.Name = "LBNombreCompañia";
            this.LBNombreCompañia.Size = new System.Drawing.Size(119, 13);
            this.LBNombreCompañia.TabIndex = 8;
            this.LBNombreCompañia.Text = "Nombre de la compañia";
            // 
            // TBServidor
            // 
            this.TBServidor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TBServidor.ErrorProvider = true;
            this.TBServidor.Location = new System.Drawing.Point(22, 75);
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
            this.TBServidor.TabIndex = 0;
            this.TBServidor.Text_ = "";
            this.TBServidor.UseSystemPasswordChar = false;
            // 
            // BTBuscarBaseDatos
            // 
            this.BTBuscarBaseDatos.FlatAppearance.BorderSize = 0;
            this.BTBuscarBaseDatos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BTBuscarBaseDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTBuscarBaseDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTBuscarBaseDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBuscarBaseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTBuscarBaseDatos.Location = new System.Drawing.Point(58, 214);
            this.BTBuscarBaseDatos.Name = "BTBuscarBaseDatos";
            this.BTBuscarBaseDatos.Size = new System.Drawing.Size(179, 29);
            this.BTBuscarBaseDatos.TabIndex = 6;
            this.BTBuscarBaseDatos.TabStop = false;
            this.BTBuscarBaseDatos.Text = "Buscar base de datos";
            this.BTBuscarBaseDatos.UseVisualStyleBackColor = true;
            this.BTBuscarBaseDatos.Click += new System.EventHandler(this.BTBuscarBaseDatos_Click);
            // 
            // BTConeccion
            // 
            this.BTConeccion.FlatAppearance.BorderSize = 0;
            this.BTConeccion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BTConeccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTConeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTConeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTConeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConeccion.Location = new System.Drawing.Point(417, 53);
            this.BTConeccion.Name = "BTConeccion";
            this.BTConeccion.Size = new System.Drawing.Size(126, 29);
            this.BTConeccion.TabIndex = 6;
            this.BTConeccion.TabStop = false;
            this.BTConeccion.Text = "Buscar tablas";
            this.BTConeccion.UseVisualStyleBackColor = true;
            this.BTConeccion.Click += new System.EventHandler(this.BTConeccion_Click);
            // 
            // GBBaseDatos
            // 
            this.GBBaseDatos.BackColor = System.Drawing.Color.Transparent;
            this.GBBaseDatos.Controls.Add(this.CBFileExcel);
            this.GBBaseDatos.Controls.Add(this.panel2);
            this.GBBaseDatos.Controls.Add(this.CBMarcarTodasTablas);
            this.GBBaseDatos.Controls.Add(this.BTGenerarReporte);
            this.GBBaseDatos.Controls.Add(this.LBObtener);
            this.GBBaseDatos.Controls.Add(this.LBTablas);
            this.GBBaseDatos.Controls.Add(this.ListCBTablas);
            this.GBBaseDatos.Controls.Add(this.BTConeccion);
            this.GBBaseDatos.ForeColor = System.Drawing.Color.Black;
            this.GBBaseDatos.Location = new System.Drawing.Point(0, 265);
            this.GBBaseDatos.Name = "GBBaseDatos";
            this.GBBaseDatos.Size = new System.Drawing.Size(555, 329);
            this.GBBaseDatos.TabIndex = 5;
            this.GBBaseDatos.TabStop = false;
            this.GBBaseDatos.Text = "Base de Datos : ";
            // 
            // CBMarcarTodasTablas
            // 
            this.CBMarcarTodasTablas.AutoSize = true;
            this.CBMarcarTodasTablas.BackColor = System.Drawing.Color.Transparent;
            this.CBMarcarTodasTablas.ForeColor = System.Drawing.Color.Black;
            this.CBMarcarTodasTablas.Location = new System.Drawing.Point(13, 64);
            this.CBMarcarTodasTablas.Name = "CBMarcarTodasTablas";
            this.CBMarcarTodasTablas.Size = new System.Drawing.Size(135, 17);
            this.CBMarcarTodasTablas.TabIndex = 6;
            this.CBMarcarTodasTablas.TabStop = false;
            this.CBMarcarTodasTablas.Text = "Marcar todas las tablas";
            this.CBMarcarTodasTablas.UseVisualStyleBackColor = false;
            this.CBMarcarTodasTablas.CheckedChanged += new System.EventHandler(this.CBMarcarTodasTablas_CheckedChanged);
            // 
            // BTGenerarReporte
            // 
            this.BTGenerarReporte.FlatAppearance.BorderSize = 0;
            this.BTGenerarReporte.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BTGenerarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTGenerarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGenerarReporte.Location = new System.Drawing.Point(216, 291);
            this.BTGenerarReporte.Name = "BTGenerarReporte";
            this.BTGenerarReporte.Size = new System.Drawing.Size(148, 29);
            this.BTGenerarReporte.TabIndex = 5;
            this.BTGenerarReporte.TabStop = false;
            this.BTGenerarReporte.Text = "Generar Reporte";
            this.BTGenerarReporte.UseVisualStyleBackColor = true;
            this.BTGenerarReporte.Click += new System.EventHandler(this.BTGenerarReporte_Click);
            // 
            // LBObtener
            // 
            this.LBObtener.AutoSize = true;
            this.LBObtener.BackColor = System.Drawing.Color.Transparent;
            this.LBObtener.ForeColor = System.Drawing.Color.Black;
            this.LBObtener.Location = new System.Drawing.Point(389, 22);
            this.LBObtener.Name = "LBObtener";
            this.LBObtener.Size = new System.Drawing.Size(45, 13);
            this.LBObtener.TabIndex = 4;
            this.LBObtener.Text = "Obtener";
            // 
            // LBTablas
            // 
            this.LBTablas.AutoSize = true;
            this.LBTablas.BackColor = System.Drawing.Color.Transparent;
            this.LBTablas.ForeColor = System.Drawing.Color.Black;
            this.LBTablas.Location = new System.Drawing.Point(7, 35);
            this.LBTablas.Name = "LBTablas";
            this.LBTablas.Size = new System.Drawing.Size(39, 13);
            this.LBTablas.TabIndex = 4;
            this.LBTablas.Text = "Tablas";
            // 
            // PanelBar
            // 
            this.PanelBar.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelBar.BorderColor = System.Drawing.Color.Black;
            this.PanelBar.Controls.Add(this.BTClose);
            this.PanelBar.Controls.Add(this.BTMinimize);
            this.PanelBar.Controls.Add(this.Logo);
            this.PanelBar.Controls.Add(this.LBLogo);
            this.PanelBar.Controls.Add(this.BTMaximize);
            this.PanelBar.Controls.Add(this.BTNormal);
            this.PanelBar.CustomBorderColor = System.Drawing.Color.Black;
            this.PanelBar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.PanelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBar.ForeColor = System.Drawing.Color.Black;
            this.PanelBar.Location = new System.Drawing.Point(0, 0);
            this.PanelBar.Name = "PanelBar";
            this.PanelBar.ShadowDecoration.BorderRadius = 0;
            this.PanelBar.ShadowDecoration.Enabled = true;
            this.PanelBar.ShadowDecoration.Parent = this.PanelBar;
            this.PanelBar.Size = new System.Drawing.Size(641, 30);
            this.PanelBar.TabIndex = 6;
            // 
            // LBLogo
            // 
            this.LBLogo.AutoSize = true;
            this.LBLogo.BackColor = System.Drawing.Color.Transparent;
            this.LBLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLogo.ForeColor = System.Drawing.Color.Black;
            this.LBLogo.Location = new System.Drawing.Point(36, 4);
            this.LBLogo.Name = "LBLogo";
            this.LBLogo.Size = new System.Drawing.Size(76, 25);
            this.LBLogo.TabIndex = 1;
            this.LBLogo.Text = "DSRG";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.GBDatosConexion);
            this.panel1.Controls.Add(this.GBBaseDatos);
            this.panel1.Location = new System.Drawing.Point(14, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 596);
            this.panel1.TabIndex = 7;
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.BackColor = System.Drawing.Color.Transparent;
            this.PanelOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOpciones.Controls.Add(this.BTAcercaDe);
            this.PanelOpciones.Controls.Add(this.BTAjustes);
            this.PanelOpciones.Location = new System.Drawing.Point(575, 41);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Size = new System.Drawing.Size(80, 65);
            this.PanelOpciones.TabIndex = 10;
            this.PanelOpciones.Visible = false;
            // 
            // BTAcercaDe
            // 
            this.BTAcercaDe.BorderRadius = 10;
            this.BTAcercaDe.CheckedState.Parent = this.BTAcercaDe;
            this.BTAcercaDe.CustomImages.Parent = this.BTAcercaDe;
            this.BTAcercaDe.FillColor = System.Drawing.Color.Black;
            this.BTAcercaDe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTAcercaDe.ForeColor = System.Drawing.Color.White;
            this.BTAcercaDe.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.BTAcercaDe.HoverState.Parent = this.BTAcercaDe;
            this.BTAcercaDe.Location = new System.Drawing.Point(5, 35);
            this.BTAcercaDe.Name = "BTAcercaDe";
            this.BTAcercaDe.PressedColor = System.Drawing.Color.Silver;
            this.BTAcercaDe.ShadowDecoration.Parent = this.BTAcercaDe;
            this.BTAcercaDe.Size = new System.Drawing.Size(70, 25);
            this.BTAcercaDe.TabIndex = 11;
            this.BTAcercaDe.Text = "Acerca de";
            this.BTAcercaDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTAcercaDe.Click += new System.EventHandler(this.BTAcercaDe_Click);
            // 
            // BTAjustes
            // 
            this.BTAjustes.BorderRadius = 10;
            this.BTAjustes.CheckedState.Parent = this.BTAjustes;
            this.BTAjustes.CustomImages.Parent = this.BTAjustes;
            this.BTAjustes.FillColor = System.Drawing.Color.Black;
            this.BTAjustes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTAjustes.ForeColor = System.Drawing.Color.White;
            this.BTAjustes.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.BTAjustes.HoverState.Parent = this.BTAjustes;
            this.BTAjustes.Location = new System.Drawing.Point(5, 5);
            this.BTAjustes.Name = "BTAjustes";
            this.BTAjustes.PressedColor = System.Drawing.Color.Silver;
            this.BTAjustes.ShadowDecoration.Parent = this.BTAjustes;
            this.BTAjustes.Size = new System.Drawing.Size(70, 25);
            this.BTAjustes.TabIndex = 11;
            this.BTAjustes.Text = "Ajustes";
            this.BTAjustes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTAjustes.Click += new System.EventHandler(this.BTAjustes_Click);
            // 
            // CBFileExcel
            // 
            this.CBFileExcel.AutoSize = true;
            this.CBFileExcel.Location = new System.Drawing.Point(226, 21);
            this.CBFileExcel.Name = "CBFileExcel";
            this.CBFileExcel.Size = new System.Drawing.Size(91, 17);
            this.CBFileExcel.TabIndex = 14;
            this.CBFileExcel.Text = "Archivo Excel";
            this.CBFileExcel.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::DSG.Properties.Resources.ImageTextBox;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.CBBBaseDatos);
            this.panel3.Location = new System.Drawing.Point(22, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 30);
            this.panel3.TabIndex = 13;
            // 
            // CBBBaseDatos
            // 
            this.CBBBaseDatos.BackColor = System.Drawing.Color.White;
            this.CBBBaseDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBBaseDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBBaseDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBBBaseDatos.ForeColor = System.Drawing.Color.Black;
            this.CBBBaseDatos.FormattingEnabled = true;
            this.CBBBaseDatos.Location = new System.Drawing.Point(4, 5);
            this.CBBBaseDatos.Name = "CBBBaseDatos";
            this.CBBBaseDatos.Size = new System.Drawing.Size(263, 21);
            this.CBBBaseDatos.TabIndex = 1;
            this.CBBBaseDatos.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DSG.Properties.Resources.ImageTextBox;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.CBView);
            this.panel2.Location = new System.Drawing.Point(434, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 30);
            this.panel2.TabIndex = 13;
            // 
            // CBView
            // 
            this.CBView.BackColor = System.Drawing.Color.White;
            this.CBView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBView.ForeColor = System.Drawing.Color.Black;
            this.CBView.FormattingEnabled = true;
            this.CBView.Items.AddRange(new object[] {
            "Tablas",
            "Vistas",
            "Procedimientos",
            "Triggers"});
            this.CBView.Location = new System.Drawing.Point(3, 5);
            this.CBView.Name = "CBView";
            this.CBView.Size = new System.Drawing.Size(103, 21);
            this.CBView.TabIndex = 7;
            this.CBView.TabStop = false;
            this.CBView.SelectedIndexChanged += new System.EventHandler(this.CBView_SelectedIndexChanged);
            // 
            // BTClose
            // 
            this.BTClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTClose.Animated = true;
            this.BTClose.BackColor = System.Drawing.Color.Transparent;
            this.BTClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTClose.BorderColor = System.Drawing.Color.Transparent;
            this.BTClose.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BTClose.CheckedState.Parent = this.BTClose;
            this.BTClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTClose.CustomBorderColor = System.Drawing.Color.Black;
            this.BTClose.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTClose.CustomImages.Parent = this.BTClose;
            this.BTClose.FillColor = System.Drawing.Color.Black;
            this.BTClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTClose.ForeColor = System.Drawing.Color.White;
            this.BTClose.HoverState.FillColor = System.Drawing.Color.Gray;
            this.BTClose.HoverState.Parent = this.BTClose;
            this.BTClose.Image = global::DSG.Properties.Resources.Close_White;
            this.BTClose.Location = new System.Drawing.Point(601, 0);
            this.BTClose.Name = "BTClose";
            this.BTClose.PressedColor = System.Drawing.Color.Silver;
            this.BTClose.PressedDepth = 20;
            this.BTClose.ShadowDecoration.Parent = this.BTClose;
            this.BTClose.Size = new System.Drawing.Size(30, 30);
            this.BTClose.TabIndex = 4;
            this.BTClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // BTMinimize
            // 
            this.BTMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTMinimize.Animated = true;
            this.BTMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BTMinimize.BorderColor = System.Drawing.Color.Transparent;
            this.BTMinimize.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BTMinimize.CheckedState.Parent = this.BTMinimize;
            this.BTMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTMinimize.CustomBorderColor = System.Drawing.Color.Black;
            this.BTMinimize.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTMinimize.CustomImages.Parent = this.BTMinimize;
            this.BTMinimize.FillColor = System.Drawing.Color.Black;
            this.BTMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTMinimize.ForeColor = System.Drawing.Color.White;
            this.BTMinimize.HoverState.FillColor = System.Drawing.Color.Gray;
            this.BTMinimize.HoverState.Parent = this.BTMinimize;
            this.BTMinimize.Image = global::DSG.Properties.Resources.Minimize_White;
            this.BTMinimize.Location = new System.Drawing.Point(529, 0);
            this.BTMinimize.Name = "BTMinimize";
            this.BTMinimize.PressedColor = System.Drawing.Color.Silver;
            this.BTMinimize.PressedDepth = 20;
            this.BTMinimize.ShadowDecoration.Parent = this.BTMinimize;
            this.BTMinimize.Size = new System.Drawing.Size(30, 30);
            this.BTMinimize.TabIndex = 4;
            this.BTMinimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::DSG.Properties.Resources.Report;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.ShadowDecoration.Parent = this.Logo;
            this.Logo.Size = new System.Drawing.Size(30, 30);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // BTMaximize
            // 
            this.BTMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTMaximize.Animated = true;
            this.BTMaximize.BackColor = System.Drawing.Color.Transparent;
            this.BTMaximize.BorderColor = System.Drawing.Color.Transparent;
            this.BTMaximize.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BTMaximize.CheckedState.Parent = this.BTMaximize;
            this.BTMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTMaximize.CustomBorderColor = System.Drawing.Color.Black;
            this.BTMaximize.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTMaximize.CustomImages.Parent = this.BTMaximize;
            this.BTMaximize.FillColor = System.Drawing.Color.Black;
            this.BTMaximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTMaximize.ForeColor = System.Drawing.Color.White;
            this.BTMaximize.HoverState.FillColor = System.Drawing.Color.Gray;
            this.BTMaximize.HoverState.Parent = this.BTMaximize;
            this.BTMaximize.Image = global::DSG.Properties.Resources.Maximize_White;
            this.BTMaximize.Location = new System.Drawing.Point(565, 0);
            this.BTMaximize.Name = "BTMaximize";
            this.BTMaximize.PressedColor = System.Drawing.Color.Silver;
            this.BTMaximize.PressedDepth = 20;
            this.BTMaximize.ShadowDecoration.Parent = this.BTMaximize;
            this.BTMaximize.Size = new System.Drawing.Size(30, 30);
            this.BTMaximize.TabIndex = 4;
            this.BTMaximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // BTNormal
            // 
            this.BTNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNormal.Animated = true;
            this.BTNormal.BackColor = System.Drawing.Color.Transparent;
            this.BTNormal.BorderColor = System.Drawing.Color.Transparent;
            this.BTNormal.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BTNormal.CheckedState.Parent = this.BTNormal;
            this.BTNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNormal.CustomBorderColor = System.Drawing.Color.Black;
            this.BTNormal.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNormal.CustomImages.Parent = this.BTNormal;
            this.BTNormal.FillColor = System.Drawing.Color.Black;
            this.BTNormal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNormal.ForeColor = System.Drawing.Color.White;
            this.BTNormal.HoverState.FillColor = System.Drawing.Color.Gray;
            this.BTNormal.HoverState.Parent = this.BTNormal;
            this.BTNormal.Image = global::DSG.Properties.Resources.Normal_White;
            this.BTNormal.Location = new System.Drawing.Point(565, 0);
            this.BTNormal.Name = "BTNormal";
            this.BTNormal.PressedColor = System.Drawing.Color.Silver;
            this.BTNormal.PressedDepth = 20;
            this.BTNormal.ShadowDecoration.Parent = this.BTNormal;
            this.BTNormal.Size = new System.Drawing.Size(30, 30);
            this.BTNormal.TabIndex = 4;
            this.BTNormal.Click += new System.EventHandler(this.Normal_Click);
            // 
            // DSRG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 629);
            this.ControlBox = false;
            this.Controls.Add(this.PanelOpciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DSRG";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.GBCredenciales.ResumeLayout(false);
            this.GBCredenciales.PerformLayout();
            this.GBDatosConexion.ResumeLayout(false);
            this.GBDatosConexion.PerformLayout();
            this.GBBaseDatos.ResumeLayout(false);
            this.GBBaseDatos.PerformLayout();
            this.PanelBar.ResumeLayout(false);
            this.PanelBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PanelOpciones.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private Controles_Personalizado.TextBoxIEP TBServidor;
        private Controles_Personalizado.TextBoxIEP TBUsuario;
        private Controles_Personalizado.TextBoxIEP TBContraseña;
        private System.Windows.Forms.Label LBServidor;
        private System.Windows.Forms.Label LBBaseDatos;
        private System.Windows.Forms.Label LBUsuario;
        private System.Windows.Forms.Label LBContrase;
        private System.Windows.Forms.GroupBox GBCredenciales;
        private System.Windows.Forms.CheckedListBox ListCBTablas;
        private System.Windows.Forms.GroupBox GBDatosConexion;
        private System.Windows.Forms.GroupBox GBBaseDatos;
        private System.Windows.Forms.Button BTGenerarReporte;
        private System.Windows.Forms.Label LBTablas;
        private System.Windows.Forms.Button BTConeccion;
        private System.Windows.Forms.CheckBox CBMarcarTodasTablas;
        private System.Windows.Forms.Label LBNombreCompañia;
        private System.Windows.Forms.Button BTBuscarBaseDatos;
        private System.Windows.Forms.ComboBox CBView;
        private System.Windows.Forms.Label LBObtener;
        private System.Windows.Forms.ComboBox CBBBaseDatos;
        private System.Windows.Forms.RadioButton RBAutenticacionW;
        private System.Windows.Forms.RadioButton RBAutenticacionS;
        private System.Windows.Forms.CheckBox CBGuardarDatos;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelBar;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Guna.UI2.WinForms.Guna2CircleButton BTClose;
        private Guna.UI2.WinForms.Guna2CircleButton BTMaximize;
        private Guna.UI2.WinForms.Guna2CircleButton BTNormal;
        private Guna.UI2.WinForms.Guna2CircleButton BTMinimize;
        private System.Windows.Forms.Label LBLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelOpciones;
        private Guna.UI2.WinForms.Guna2Button BTAcercaDe;
        private Guna.UI2.WinForms.Guna2Button BTAjustes;
        private Controles_Personalizado.TextBoxIEP TBCompanyName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox CBFileExcel;
    }
}

