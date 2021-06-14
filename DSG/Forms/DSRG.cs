
namespace DSRG
{
    using DSG;
    using DSG.Extensions;
    using Extensions;
    using Forms;
    using Models;
    using Newtonsoft.Json;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Security.Principal;
    using System.Windows.Forms;
    using static Services.Enums;
    using SpreadsheetLight;
    //

    public partial class DSRG : Form
    {
        bool _DartLight;

        public DSRG()
        {
            InitializeComponent();

            CBView.SelectedIndex = 0;

            if(!Directory.Exists(Directory.GetCurrentDirectory() + @"\Datos"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Datos");

                File.Create(Directory.GetCurrentDirectory() + @"\Datos\Datos.json").Close();
            }

            DatosCredenciales obj = JsonConvert.DeserializeObject<DatosCredenciales>(
                File.ReadAllText(Directory.GetCurrentDirectory() +  @"\Datos\Datos.json", System.Text.Encoding.UTF8));

            if(obj is not null)
            {
                TBServidor.Text_ =          Decrypt(obj.Servidor);
                CBBBaseDatos.Text =         Decrypt(obj.BaseDatos);
                TBUsuario.Text_ =           Decrypt(obj.Usuario);
                TBContraseña.Text_ =        Decrypt(obj.Contraseña);
                RBAutenticacionS.Checked =         !obj.AutenticacionWindows;
                TBCompanyName.Text_ =       Decrypt(obj.NombreEmpresa);
                CBGuardarDatos.Checked =            obj.GuardarDatos;
                ConfiguracionTema(obj.Dart, BuscarTema(Decrypt(obj.Tema)));
            }

            PanelOpciones.Location = new Point(0, 30);
            this.Size = new Size(590, 700);
            panel1.Location = new Point(10, 41);
            GBBaseDatos.Text = $"{CBView.SelectedItem}";
        }


        #region tema

        private void ConfiguracionTema(bool Dart,Theme tema = Theme.Verde)
        {
            BTGenerarReporte.Temas(tema);
            BTConeccion.Temas(tema);
            BTBuscarBaseDatos.Temas(tema);

            _DartLight = Dart;

            if (Dart)
                DarMode();
            else
                LightMode();

            if (CBGuardarDatos.Checked is true)
                using (StreamWriter file = File.CreateText(Directory.GetCurrentDirectory() + @"\Datos\Datos.json"))
                    new JsonSerializer().Serialize(file, new DatosCredenciales
                    {
                        Servidor = Encrypt(TBServidor.Text_),
                        BaseDatos = Encrypt(CBBBaseDatos.Text),
                        Usuario = Encrypt(TBUsuario.Text_),
                        Contraseña = Encrypt(TBContraseña.Text_),
                        AutenticacionWindows = RBAutenticacionW.Checked,
                        NombreEmpresa = Encrypt(TBCompanyName.Text_),
                        GuardarDatos = CBGuardarDatos.Checked,
                        Tema = Encrypt(tema.ToString()),
                        Dart = Dart
                    });

        }

        private void DarMode()
        {
            // 
            // LBServidor
            this.LBServidor.ForeColor = System.Drawing.Color.White;//black
            // 
            // LBBaseDatos
            this.LBBaseDatos.ForeColor = System.Drawing.Color.White;//black
            // 
            // LBUsuario
            this.LBUsuario.ForeColor = System.Drawing.Color.White;//black
            // 
            // LBContrase
            this.LBContrase.ForeColor = System.Drawing.Color.White;//black
            // 
            // GBCredenciales
            this.GBCredenciales.ForeColor = System.Drawing.Color.White;//black
            // 
            // RBAutenticacionW
            this.RBAutenticacionW.ForeColor = System.Drawing.Color.White;//black
            // 
            // RBAutenticacionS
            this.RBAutenticacionS.ForeColor = System.Drawing.Color.White;//black
            // 
            // ListCBTablas
            this.ListCBTablas.BackColor = System.Drawing.Color.Black;//white
            this.ListCBTablas.ForeColor = System.Drawing.Color.White;//black
            // 
            // GBDatosConexion
            // 
            this.GBDatosConexion.BackColor = System.Drawing.Color.Black;//white
            this.GBDatosConexion.ForeColor = System.Drawing.Color.White;//black
            // 
            // CBGuardarDatos
            this.CBGuardarDatos.ForeColor = System.Drawing.Color.White;//black
            // 
            // CBBBaseDatos
            this.CBBBaseDatos.BackColor = System.Drawing.Color.Black;//white
            this.CBBBaseDatos.ForeColor = System.Drawing.Color.White;//black
            // 
            // LBNombreCompañia
            this.LBNombreCompañia.ForeColor = System.Drawing.Color.White;//black
            // 
            // GBBaseDatos
            this.GBBaseDatos.ForeColor = System.Drawing.Color.White;
            // 
            // CBView
            this.CBView.BackColor = System.Drawing.Color.Black;//white
            this.CBView.ForeColor = System.Drawing.Color.White;//black
            // 
            // CBMarcarTodasTablas
            this.CBMarcarTodasTablas.ForeColor = System.Drawing.Color.White;//black
            // 
            // LBObtener
            this.LBObtener.ForeColor = System.Drawing.Color.White;//black
            // 
            // LBTablas
            this.LBTablas.ForeColor = System.Drawing.Color.White;//black
            // 
            // LBLogo
            this.LBObtener.ForeColor = System.Drawing.Color.White;//black
            //// 
            //// TBCompanyName
            //// 
            //this.TBCompanyName.BackColor = System.Drawing.Color.Black;//white
            //this.TBCompanyName.ForeColor = System.Drawing.Color.White;//black
            //// 
            //// TBServidor
            //// 
            //this.TBServidor.BackColor = System.Drawing.Color.Black;//white
            //this.TBServidor.ForeColor = System.Drawing.Color.White;//black
            //// 
            //// TBUsuario
            //// 
            //this.TBUsuario.BackColor = System.Drawing.Color.Black;//white
            //this.TBUsuario.ForeColor = System.Drawing.Color.White;//black
            //// 
            //// TBContraseña
            //this.TBContraseña.BackColor = System.Drawing.Color.Black;//white
            //this.TBContraseña.ForeColor = System.Drawing.Color.White;//black
            // 
            // DSRG
            this.BackColor = System.Drawing.Color.Black;//white
            //
        }

        private void LightMode()
        {
            // 
            // LBServidor
            this.LBServidor.ForeColor = System.Drawing.Color.Black;
            // 
            // LBBaseDatos
            this.LBBaseDatos.ForeColor = System.Drawing.Color.Black;
            // 
            // LBUsuario
            this.LBUsuario.ForeColor = System.Drawing.Color.Black;
            // 
            // LBContrase
            this.LBContrase.ForeColor = System.Drawing.Color.Black;
            // 
            // GBCredenciales
            this.GBCredenciales.ForeColor = System.Drawing.Color.Black;
            // 
            // RBAutenticacionW
            this.RBAutenticacionW.ForeColor = System.Drawing.Color.Black;
            // 
            // RBAutenticacionS
            this.RBAutenticacionS.ForeColor = System.Drawing.Color.Black;
            // 
            // ListCBTablas
            this.ListCBTablas.BackColor = System.Drawing.Color.White;
            this.ListCBTablas.ForeColor = System.Drawing.Color.Black;
            // 
            // GBDatosConexion
            // 
            this.GBDatosConexion.BackColor = System.Drawing.Color.White;
            this.GBDatosConexion.ForeColor = System.Drawing.Color.Black;
            // 
            // CBGuardarDatos
            this.CBGuardarDatos.ForeColor = System.Drawing.Color.Black;
            // 
            // CBBBaseDatos
            this.CBBBaseDatos.BackColor = System.Drawing.Color.White;
            this.CBBBaseDatos.ForeColor = System.Drawing.Color.Black;
            // 
            // LBNombreCompañia
            this.LBNombreCompañia.ForeColor = System.Drawing.Color.Black;
            // 
            // GBBaseDatos
            this.GBBaseDatos.ForeColor = System.Drawing.Color.Black;
            // 
            // CBView
            this.CBView.BackColor = System.Drawing.Color.White;
            this.CBView.ForeColor = System.Drawing.Color.Black;
            // 
            // CBMarcarTodasTablas
            this.CBMarcarTodasTablas.ForeColor = System.Drawing.Color.Black;
            // 
            // LBObtener
            this.LBObtener.ForeColor = System.Drawing.Color.Black;
            // 
            // LBTablas
            this.LBTablas.ForeColor = System.Drawing.Color.Black;
            // 
            // LBLogo
            this.LBObtener.ForeColor = System.Drawing.Color.Black;
            // 
            // TBCompanyName
            // 
            this.TBCompanyName.BackColor = System.Drawing.Color.White;
            this.TBCompanyName.ForeColor = System.Drawing.Color.Black;
            // 
            // TBServidor
            // 
            this.TBServidor.BackColor = System.Drawing.Color.White;
            this.TBServidor.ForeColor = System.Drawing.Color.Black;
            // 
            // TBUsuario
            // 
            this.TBUsuario.BackColor = System.Drawing.Color.White;
            this.TBUsuario.ForeColor = System.Drawing.Color.Black;
            // 
            // TBContraseña
            this.TBContraseña.BackColor = System.Drawing.Color.White;
            this.TBContraseña.ForeColor = System.Drawing.Color.Black;
            // 
            // DSRG
            this.BackColor = System.Drawing.Color.White;
        }

        private Theme BuscarTema(string tema) =>
            tema switch
            {
                "Negro" => Theme.Negro,
                "Blanco" => Theme.Blanco,
                "Azul" => Theme.Azul,
                "Verde" => Theme.Verde,
                "Gris" => Theme.Gris,
                "Naranja" => Theme.Naranja,
                "Amarillo" => Theme.Amarillo,
                "DarMode" => Theme.DarMode,
                "LightMode" => Theme.LightMode,
                _ => Theme.Azul
            };

        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBAutenticacionW_CheckedChanged(object sender, System.EventArgs e)
        {
            if (RBAutenticacionW.Checked is true)
            {
                TBUsuario.Enabled = false;
                TBContraseña.Enabled = false;
                RBAutenticacionW.BackColor = Color.FromArgb(109, 168, 68);
                RBAutenticacionS.BackColor = Color.Transparent;
            }
            else
            {
                TBUsuario.Enabled = true;
                TBContraseña.Enabled = true;
                RBAutenticacionS.BackColor = Color.FromArgb(109, 168, 68);
                RBAutenticacionW.BackColor = Color.Transparent;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTConeccion_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if(TBServidor.IsEmptyErrorProvider() | CBBBaseDatos.IsEmpty())
            {
                if (RBAutenticacionW.Checked == false)
                {
                    TBUsuario.IsEmptyErrorProvider();
                    TBContraseña.IsEmptyErrorProvider();
                }

                if(CBBBaseDatos.IsEmpty()) 
                    MessageBox.Show("Escriba un nombre de una base de datos o busque una para seleccionar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                 if (RBAutenticacionW.Checked is false)
                 {
                    if (!TBUsuario.IsEmptyErrorProvider() | !TBContraseña.IsEmptyErrorProvider())
                        GetTables();
                 }
                 else
                    GetTables();
            }

            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// 
        /// </summary>
        private async void GetTables()
        {
            ListCBTablas.Items.Clear();

            try
            {
                foreach (string tableName in await SqlServerConnection
                         .GetInstance()
                         .GetTables(TBServidor.Text_, CBBBaseDatos.Text, RBAutenticacionW.Checked, CBView.Text, TBUsuario.Text_, TBContraseña.Text_))
                {
                    ListCBTablas.Items.Add(tableName);
                }

                if(CBGuardarDatos.Checked is true)
                    using (StreamWriter file = File.CreateText(Directory.GetCurrentDirectory() +  @"\Datos\Datos.json"))
                        new JsonSerializer().Serialize(file, new DatosCredenciales
                        {
                            Servidor = Encrypt(TBServidor.Text_),
                            BaseDatos = Encrypt(CBBBaseDatos.Text),
                            Usuario = Encrypt(TBUsuario.Text_),
                            Contraseña = Encrypt(TBContraseña.Text_),
                            AutenticacionWindows = RBAutenticacionW.Checked,
                            NombreEmpresa = Encrypt(TBCompanyName.Text_),
                            GuardarDatos = CBGuardarDatos.Checked
                        });

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        #region Encriptaciones

        public string Encrypt(string _stringToEncrypt)
        {
            if (!string.IsNullOrEmpty(_stringToEncrypt))
            {
                string result;

                byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_stringToEncrypt);

                result = Convert.ToBase64String(encryted);

                return result;
            }

            return _stringToEncrypt;
        }

        public string Decrypt(string _stringToDecrypt)
        {
            if (!string.IsNullOrEmpty(_stringToDecrypt))
            {
                try
                {
                    string result;

                    byte[] decryted = Convert.FromBase64String(_stringToDecrypt);

                    result = System.Text.Encoding.Unicode.GetString(decryted);

                    return result;
                }
                catch
                {
                   //return Resource.CorruptedData + _stringToDecrypt;
                }
            }

            return _stringToDecrypt;
        }

        #endregion


        private void CBMarcarTodasTablas_CheckedChanged(object sender, System.EventArgs e)
        {
            for (int i = 0; i < ListCBTablas.Items.Count; i++)
                ListCBTablas.SetItemChecked(i, CBMarcarTodasTablas.Checked);
        }

        private void BTGenerarReporte_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string[] tables = new string[ListCBTablas.CheckedItems.Count];

            int c = 0;
            foreach(string table in ListCBTablas.CheckedItems)
            {
                tables[c] = table;

                c++;
            }

            for (int i = 0; i < ListCBTablas.Items.Count; i++)
                ListCBTablas.SetItemChecked(i, false);

            CBMarcarTodasTablas.Checked = false;

            void action()
            {
                PropertyTables(tables);
            }

            if (tables.Length > 0)
            {
                _ = CBView.SelectedItem switch
                {
                    "Tablas" => () =>
                    {
                        /*--La consulta muestra todas las tablas de la base de datos*/
                        PropertyTables(tables);
                    }
                    ,
                    "Vistas" => () =>
                    {
                        /*--La consulta muestra todas las vistas de la base de datos*/
                        StructureViews(tables);
                    }
                    ,
                    "Procedimientos" => () =>
                    {
                        /*--La consulta muestra todos los procedimientos de la base de datos*/
                        StructureProcedure(tables);
                    }
                    ,
                    "Triggers" => () =>
                    {
                        /*--La consulta muestra todos los triggers de la base de datos*/
                        StructureTriggers(tables);
                    }
                    ,
                    "Functions" => () =>
                    {
                        /*--La consulta muestra todos los Functions de la base de datos*/

                        StructureFunctions(tables);
                    }
                    ,
                    _ => (Action)action
                };
            }
            else
                MessageBox.Show("No hay opciones marcadas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tables"></param>
        private async void PropertyTables(string[] tables)
        {
            try
            {
                var listTable = await SqlServerConnection
                .GetInstance()
                .GetTablesProperty(TBServidor.Text_, CBBBaseDatos.Text, RBAutenticacionW.Checked, tables, TBUsuario.Text_, TBContraseña.Text_);

                if (listTable is not null)
                {
                    FromReport FromReport = new FromReport();

                    Reports.Report report = new Reports.Report();

                    report.TBCompanyName.Value = TBCompanyName.Text_;

                    report.objectDataSource.DataSource = listTable;

                    report.reportNameTextBox.Value = $"Resporte de tabla : Servidor = {TBServidor.Text_};  base de datos = {CBBBaseDatos.Text};";
     
                    FromReport.reportViewer.ShowPrintPreviewButton = true;
                    FromReport.reportViewer.ReportSource = report;
                    FromReport.reportViewer.RefreshReport();

                    this.Cursor = Cursors.Default;

                    FromReport.Show();
                }
                else
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch{}
        }

        private void ExcelFile()
        {
            FolderBrowserDialog openFile = new FolderBrowserDialog();
            DialogResult file = openFile.ShowDialog();

            SLDocument document = new SLDocument();

            System.Data.DataTable table = new System.Data.DataTable();

            //columnas 
            string[] columns = new string[] { "cl1", "cl2", "cl3", "cl4", "cl5" };

            foreach(var column in columns)
                table.Columns.Add(column, typeof(string));

            //row 
            var rows = new []
            { 
                new string[] { "val1-1", "val2-1", "val3-1" },
                new string[] { "val1-2", "val2-2", "val3-2" },
                new string[] { "val1-3", "val2-3", "val3-3" } 
            };

            foreach (var row in rows)
                table.Rows.Add(row[0], row[1], row[2]);

            document.ImportDataTable(2, 2, table, true);

            document.SaveAs(Path.Combine(openFile.SelectedPath,"Tablas.xlsx"));

        }

        #region sin completar

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tables"></param>
        private async void StructureViews(string[] tables)
        {
            var listTable = await SqlServerConnection
                .GetInstance()
                .GetStructureViews(TBServidor.Text_, CBBBaseDatos.Text, RBAutenticacionW.Checked, tables, TBUsuario.Text_, TBContraseña.Text_);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tables"></param>
        private async void StructureProcedure(string[] tables)
        {
            var listTable = await SqlServerConnection
                .GetInstance()
                .GetStructureProcedures(TBServidor.Text_, CBBBaseDatos.Text, RBAutenticacionW.Checked, tables, TBUsuario.Text_, TBContraseña.Text_);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tables"></param>
        private async void StructureTriggers(string[] tables)
        {
            var listTable = await SqlServerConnection
                .GetInstance()
                .GetStructureTriggers(TBServidor.Text_, CBBBaseDatos.Text, RBAutenticacionW.Checked, tables, TBUsuario.Text_, TBContraseña.Text_);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tables"></param>
        private async void StructureFunctions(string[] tables)
        {
            var listTable = await SqlServerConnection
                .GetInstance()
                .GetStructureFunctions(TBServidor.Text_, CBBBaseDatos.Text, RBAutenticacionW.Checked, tables, TBUsuario.Text_, TBContraseña.Text_);
        }

        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BTBuscarBaseDatos_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (TBServidor.IsEmpty())
                {
                    ExcelFile();

                    if (RBAutenticacionW.Checked is false)
                    {
                        TBUsuario.IsEmptyErrorProvider();
                        TBContraseña.IsEmptyErrorProvider();
                    }

                    if (TBServidor.IsEmpty())
                        MessageBox.Show("El campo servidor está en blanco.\nInserte algunos de los nombres locales.\n\n" +
                            $"- {WindowsIdentity.GetCurrent().Name}\n" +
                            "- .\n" +
                            "- local"
                            , "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Cursor = Cursors.WaitCursor;

                    CBBBaseDatos.Items.Clear();

                    CBBBaseDatos.Items.Add("Seleccione una Base de datos");

                    foreach (string tableName in await SqlServerConnection
                    .GetInstance()
                    .GetDataBases(TBServidor.Text_, RBAutenticacionW.Checked, TBUsuario.Text_, TBContraseña.Text_))
                    {
                        CBBBaseDatos.Items.Add(tableName);
                    }

                    CBBBaseDatos.SelectedIndex = 0;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"{ex.Message}\nEste error puede deberse a un error en las credenciales o conexión a internet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Cursor = Cursors.Default;

        }


        private void CBView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BTConeccion.Text = $"Buscar {CBView.SelectedItem}";
            GBBaseDatos.Text = $"{CBView.SelectedItem}";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿SEGURO QUE DESEA CERRAR LA APLICACIÓN?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            BTNormal.Visible = true;
            BTNormal.Enabled = true;
            BTMaximize.Visible = false;
            BTMaximize.Enabled = false;
            WindowState = FormWindowState.Maximized;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            BTNormal.Visible = false;
            BTNormal.Enabled = false;
            BTMaximize.Visible = true;
            BTMaximize.Enabled = true;
            WindowState = FormWindowState.Normal;
            Size = new Size(593, 680);

            if (DesktopLocation.Y <= 0)
                Location = new Point(Location.X, Location.Y + 50);

        }

        private void Logo_Click(object sender, EventArgs e)
        {
            PanelOpciones.Visible = !PanelOpciones.Visible;
        }

        private void BTAcercaDe_Click(object sender, EventArgs e)
        {
            PanelOpciones.Visible = false;

            MessageBox.Show("DSRG\n\"Database structure report generator.\"\n\nVersión 1.5\n\nDSRG made by Luis Eduardo Frías, es una generado de reporte de tu base de datos relacionar, conpatible actual mente con Sql Server.\n\nCopyRight © 2021\nTodos los derechos reservados.\n" +
                "Los Programas de Computadora (en lo adelante “software”), definidos en nuestra legislación están protegidos en la República " +
                "Dominicana a través de la figura del Derecho de Autor, la cual está contemplada en la Ley 65-00 sobre Derecho de Autor.",
                "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTAjustes_Click(object sender, EventArgs e)
        {
            PanelOpciones.Visible = false;

            this.AddOwnedForm(Tema.GetInstance(ConfiguracionTema, _DartLight).ShowTheme());
        }

    }
}
