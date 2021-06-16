
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
    using System.Collections.Generic;
    using System.Linq;

    //

    public partial class DSRG : Form
    {
        bool _DartLight;

        public DSRG()
        {
            InitializeComponent();

            TBServidor_TextBoxIEP_TextChanged(null, null);

            CBView.SelectedIndex = 0;
            CBBTipoReporte.SelectedIndex = 0;

            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\Datos"))
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
            // this.LBTablas.ForeColor = System.Drawing.Color.White;//black
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
            // this.LBTablas.ForeColor = System.Drawing.Color.Black;
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

                TablasCount.Text = $"Tablas: {ListCBTablas.Items.Count}";
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
                if (CBBTipoReporte.SelectedIndex == 0)
                {
                    PropertyTablesForExcel(tables);
                }
                else
                {
                    //_ = CBView.SelectedItem switch
                    switch(CBView.SelectedItem)
                    {
                        case "Tablas":// => () =>
                        {
                            /*--La consulta muestra todas las tablas de la base de datos*/
                            PropertyTables(tables);
                                break;
                        }
                        case "Vistas":// => () =>
                        {
                            /*--La consulta muestra todas las vistas de la base de datos*/
                            StructureViews(tables);
                                break;
                        }
                        case "Procedimientos":// => () =>
                        {
                            /*--La consulta muestra todos los procedimientos de la base de datos*/
                            StructureProcedure(tables);
                                break;
                        }
                        case "Triggers":// => () =>
                        {
                            /*--La consulta muestra todos los triggers de la base de datos*/
                            StructureTriggers(tables);
                                break;
                        }
                        case "Functions":// => () =>
                        {
                            /*--La consulta muestra todos los Functions de la base de datos*/

                            StructureFunctions(tables);
                                break;
                        }
                        //_ => (Action)action
                    };

                }
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
                List<Table> listTable = await SqlServerConnection
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


        private async void PropertyTablesForExcel(string[] tables)
        {
            try
            {
                List<Table> listTable = await SqlServerConnection
                .GetInstance()
                .GetTablesProperty(TBServidor.Text_, CBBBaseDatos.Text, RBAutenticacionW.Checked, tables, TBUsuario.Text_, TBContraseña.Text_);

                if (listTable is not null)
                {
                    ExcelFile(listTable);
                }
                else
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { }
        }


        private void ExcelFile(List<Table> listTable)
        {   
            try
            {
                this.UseWaitCursor = true;

                FolderBrowserDialog openFile = new FolderBrowserDialog();
                openFile.ShowDialog();

                List<System.Data.DataTable> tables = new List<System.Data.DataTable>();
                System.Data.DataTable dataTable = new System.Data.DataTable();
                SLDocument document = new SLDocument();

                //----------------------- Styles ---------------------------//
               
                SLPageSettings ps = new SLPageSettings();

                SLStyle style = document.CreateStyle();
                SLStyle fontBold = document.CreateStyle();
                SLStyle font = document.CreateStyle();
                SLStyle fontColor = document.CreateStyle();
                SLStyle headerBackGroudColor = document.CreateStyle();
                SLStyle backGroudColor = document.CreateStyle();
                SLStyle border = document.CreateStyle();
                SLStyle topBorder = document.CreateStyle();
                SLStyle leftBorder = document.CreateStyle();
                SLStyle rightBorder = document.CreateStyle();
                SLStyle bottomBorder = document.CreateStyle();

                fontBold.SetFontBold(true);
                fontBold.Font.FontName = "Times New Roman";

                font.Font.FontName = "Times New Roman";

                fontColor.Font.FontColor = Color.White;

                headerBackGroudColor.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, Color.FromArgb(34, 43, 53), Color.FromArgb(34, 43, 53));

                backGroudColor.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, Color.White, Color.Black);

                border.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Dotted;

                topBorder.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thick;
                leftBorder.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thick;
                rightBorder.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thick;
                bottomBorder.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thick;

                style.SetWrapText(true);
                style.Fill.SetPatternBackgroundColor(Color.White);
                style.Alignment.Horizontal = DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Center;
                style.Alignment.Vertical = DocumentFormat.OpenXml.Spreadsheet.VerticalAlignmentValues.Bottom;
                style.Alignment.ReadingOrder = SLAlignmentReadingOrderValues.LeftToRight;
                style.Alignment.ShrinkToFit = false;
                style.Alignment.WrapText = false;
                style.SetWrapText(true);

                //----------------------- Index ----------------------------//

                Tuple<string, Type>[] columnsForIndex = new Tuple<string, Type>[]
                {
                    Tuple.Create("Número", typeof(int)),
                    Tuple.Create("Tabla", typeof(string)),
                    Tuple.Create("Descripción", typeof(string)),
                    Tuple.Create("Subsistema", typeof(string)),
                    Tuple.Create("Descripción de sistema", typeof(string)),
                    Tuple.Create("Detallada", typeof(string)),
                    Tuple.Create("Analizada", typeof(string)),
                    Tuple.Create("Rediseñada", typeof(string)),
                    Tuple.Create("Comentario", typeof(string))
                };
                
                foreach (Tuple<string, Type> column in columnsForIndex)
                {
                    dataTable.Columns.Add(column.Item1, column.Item2);
                }

                int index = 1;
                foreach (var table in listTable)
                {
                    bool insert = true;

                    foreach (System.Data.DataRow row in dataTable.Rows)
                        if (row[1].ToString() == table.TableName)
                            insert = false;

                    if (insert == true) 
                    {
                        dataTable.Rows.Add(index, table.TableName, "", "", "", "SI", "NO", "NO", "");
                        index++;
                    }
                }

                document.AddWorksheet("Indice");

                document.ImportDataTable(4, 3, dataTable, true);

                //fuente 
                document.SetCellStyle(3, 2, 3 + dataTable.Rows.Count, 12, font);

                //fondo blanco
                document.SetCellStyle(3, 2, 5 + dataTable.Rows.Count, 12, backGroudColor);

                //border al rededor
                document.SetCellStyle(3, 2, 3, 12, topBorder);
                document.SetCellStyle(3, 2, 5 + dataTable.Rows.Count, 2, leftBorder);
                document.SetCellStyle(3, 12, 5 + dataTable.Rows.Count, 12, rightBorder);
                document.SetCellStyle(5 + dataTable.Rows.Count, 2, 5 + dataTable.Rows.Count, 12, bottomBorder);

                //cabecera 
                //document.SetCellStyle(4, 4, 6, 7, style);
                document.SetCellStyle(4, 3, 4, 11, fontColor);
                document.SetCellStyle(4, 3, 4, 11, headerBackGroudColor);
                document.SetCellStyle(4, 3, 4, 11, fontBold);

                //campos
                document.SetCellStyle(5, 3, 4 + dataTable.Rows.Count, 11, border);
                document.SetCellStyle(5, 8, 5 + dataTable.Rows.Count, 11, style);
                document.SetCellStyle(5, 3, 5 + dataTable.Rows.Count, 11, backGroudColor);

                //agrandar columnas y filas
                document.SetRowHeight(5, 4 + dataTable.Rows.Count, 25.0D);
                document.AutoFitColumn(4, 11);

                // ----------------------- tablas ---------------------------//

                tables = new List<System.Data.DataTable>();
                dataTable = new System.Data.DataTable();

                Tuple<string, Type>[] columns = new Tuple<string, Type>[] 
                { 
                    Tuple.Create("Campo", typeof(string)),
                    Tuple.Create("Tipo de datos", typeof(string)),
                    Tuple.Create("Longitud", typeof(string)),
                    Tuple.Create("Null", typeof(string)),
                    Tuple.Create("Default", typeof(string)),
                    Tuple.Create("Restricción", typeof(string)),
                    Tuple.Create("Descripción", typeof(string))
                };

                foreach (var table in listTable)
                {
                    if (!tables.Any(x => x.TableName == table.TableName))
                    {
                        tables.Add(new System.Data.DataTable { TableName = table.TableName});
                    
                        dataTable = tables.FirstOrDefault(x => x.TableName == table.TableName);

                        foreach(Tuple<string, Type> column in columns)
                        {
                            dataTable.Columns.Add(column.Item1, column.Item2);
                        }   
                    }

                    string precision = table.PropertyPrecision == null ? string.Empty : table.PropertyPrecision;
                    string scale = table.PropertyScale == null ? string.Empty : table.PropertyScale;

                    string type = StringToUpperCase(table.PropertyType);

                    dataTable.Rows.Add(
                        table.PropertyName,
                        type, 
                        table.PropertyLeangth   is null or "" ?
                        (type is "INT" ? string.Empty : (table.PropertyPrecision is null or "" ? string.Empty : $"({precision})({scale})")) : table.PropertyLeangth,
                        table.IsNullable, 
                        table.ColumnDefault == null ? string.Empty : table.ColumnDefault,
                        table.ConstraintName == null ? string.Empty : table.ConstraintName);
                }

                foreach (var table in tables)
                {
                    document.AddWorksheet(table.TableName);

                    //Color de hoja.
                    ps = document.GetPageSettings();
                    ps.TabColor = Color.Red;
                    document.SetPageSettings(ps);

                    document.SetCellValue(3, 3, $"Tabla");
                    document.SetCellValue(3, 4, $"{table.TableName}");
                    
                    document.SetCellValue(4, 3, "Descripcion");
                    
                    document.ImportDataTable(6, 3, table, true);

                    //fuente 
                    document.SetCellStyle(2, 2, 8 + table.Rows.Count, 10, font);

                    //fondo blanco
                    document.SetCellStyle(2, 2, 8 + table.Rows.Count, 10, backGroudColor);

                    //border al rededor
                    document.SetCellStyle(2, 2, 2, 10, topBorder);
                    document.SetCellStyle(2, 2, 8 + table.Rows.Count, 2, leftBorder);
                    document.SetCellStyle(2, 10, 8 + table.Rows.Count, 10, rightBorder);
                    document.SetCellStyle(8 + table.Rows.Count, 2, 8 + table.Rows.Count, 10, bottomBorder);

                    //nombre tabla
                    document.SetCellStyle(3, 3, 4, 3, fontBold);

                    //cabecera 
                    document.SetCellStyle(6, 4, 6, 7, style);
                    document.SetCellStyle(6, 3, 6, 9, fontColor);
                    document.SetCellStyle(6, 3, 6, 9, headerBackGroudColor);
                    document.SetCellStyle(6, 3, 6, 9, fontBold);

                    //campos
                    document.SetCellStyle(7, 3, 6 + table.Rows.Count, 9, border);
                    document.SetCellStyle(7, 4, 7 + table.Rows.Count, 7, style);
                    document.SetCellStyle(7, 4, 7 + table.Rows.Count, 7, backGroudColor);
                    
                    //agrandar columnas y filas
                    document.SetRowHeight(7, 6 + table.Rows.Count, 25.0D);
                    document.AutoFitColumn(3, 9);
                }

                document.SaveAs(Path.Combine(openFile.SelectedPath,"Archivo de tablas.xlsx"));
     
                System.Threading.Tasks.Task.Run(() => 
                { 
                    MessageBox.Show("Listo.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.UseWaitCursor = false;
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

        private string StringToUpperCase(string word)
        {
            string newWord = string.Empty;

            foreach (char lyrics in word)
                newWord += char.ToUpper(lyrics);

            return newWord;
        }

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

        private void CBBBaseDatos_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void CBBBaseDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBBaseDatos.SelectedIndex >= 1)
                GBBaseDatos.Enabled = true;
            else
                GBBaseDatos.Enabled = false;
        }

        private void ListCBTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListCBTablas.CheckedItems.Count >= 1)
                BTGenerarReporte.Enabled = true;
            else
                BTGenerarReporte.Enabled = false;

            LBTablaSelect.Text = $"Tablas selecionadas: {ListCBTablas.CheckedItems.Count}";
        }

        private void TBServidor_TextBoxIEP_TextChanged(object sender, EventArgs e)
        {
            if(TBServidor.Text_.Length >= 1)
                BTBuscarBaseDatos.Enabled = true;
            else
                BTBuscarBaseDatos.Enabled = false;
        }

        private void ListCBTablas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
   
        }
    }
}
