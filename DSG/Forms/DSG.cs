
namespace DSG
{
    using global::DSG.Models;
    using Newtonsoft.Json;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    //

    public partial class DSG : Form
    {
        public DSG()
        {
            InitializeComponent();

            var tema = Tema.Naranja;

            BTGenerarReporte.Temas(tema);
            BTConeccion.Temas(tema);
            BTBuscarBaseDatos.Temas(tema);

            CBView.SelectedIndex = 0;


            if(!Directory.Exists(Directory.GetCurrentDirectory() + @"\Datos"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Datos");

                File.Create(Directory.GetCurrentDirectory() + @"\Datos\Datos.json").Close();
            }

            DatosCredenciales obj = JsonConvert.DeserializeObject<DatosCredenciales>(
                File.ReadAllText(Directory.GetCurrentDirectory() +  @"\Datos\Datos.json", System.Text.Encoding.UTF8));

            if(obj != null)
            {
                TBServidor.Text_ = decrypt(obj.Servidor);
                CBBBaseDatos.Text = decrypt(obj.BaseDatos);
                TBUsuario.Text_ = decrypt(obj.Usuario);
                TBContraseña.Text_ = decrypt(obj.Contraseña);
                RBAutenticacionW.Checked = obj.AutenticacionWindows == null ? true : obj.AutenticacionWindows;
                RBAutenticacionS.Checked = !obj.AutenticacionWindows == null ? false : !obj.AutenticacionWindows;
                TBCompanyName.Text_ = decrypt(obj.NombreEmpresa);
                CBGuardarDatos.Checked = obj.GuardarDatos == null ? false : obj.GuardarDatos;
            }
        }

        private void RBAutenticacionW_CheckedChanged(object sender, System.EventArgs e)
        {
            if (RBAutenticacionW.Checked == true)
            {
                TBUsuario.Enabled = false;
                TBContraseña.Enabled = false;
                RBAutenticacionW.BackColor = Color.FromArgb(109, 168, 68);
                RBAutenticacionS.BackColor = Color.White;
            }
            else
            {
                TBUsuario.Enabled = true;
                TBContraseña.Enabled = true;
                RBAutenticacionS.BackColor = Color.FromArgb(109, 168, 68);
                RBAutenticacionW.BackColor = Color.White;
            }
        }

        private void BTConeccion_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if
            (
               TBServidor.IsEmptyErrorProvider() |
               CBBBaseDatos.Text == string.Empty |
               CBBBaseDatos.SelectedIndex == 0
            )
            {
                if (RBAutenticacionW.Checked == false)
                {
                    TBUsuario.IsEmptyErrorProvider();
                    TBContraseña.IsEmptyErrorProvider();
                }

                if(CBBBaseDatos.Text == string.Empty | CBBBaseDatos.SelectedIndex == 0) 
                {
                    MessageBox.Show("Escriba un nombre de una base de datos o busque una para seleccionar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                 if (RBAutenticacionW.Checked == false)
                 {
                     if
                     (
                         !TBUsuario.IsEmptyErrorProvider() |
                         !TBContraseña.IsEmptyErrorProvider()
                     )
                     {
                        GetTables();
                     }
                 }
                 else
                 {
                    GetTables();
                 }
            }

            this.Cursor = Cursors.Default;
        }

        private async void GetTables()
        {
            ListCBTablas.Items.Clear();

            try
            {
                foreach (string tableName in await ConnectionString
                         .GetInstance()
                         .GetTables(TBServidor.Text_, CBBBaseDatos.Text, RBAutenticacionW.Checked, CBView.Text, TBUsuario.Text_, TBContraseña.Text_))
                {
                    ListCBTablas.Items.Add(tableName);
                }

                if(CBGuardarDatos.Checked == true)
                    using (StreamWriter file = File.CreateText(Directory.GetCurrentDirectory() +  @"\Datos\Datos.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(file, new DatosCredenciales
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
                string result = string.Empty;

                byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_stringToEncrypt);

                result = Convert.ToBase64String(encryted);

                return result;
            }

            return _stringToEncrypt;
        }

        public string decrypt(string _stringToDecrypt)
        {
            if (!string.IsNullOrEmpty(_stringToDecrypt))
            {
                try
                {
                    string result = string.Empty;

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
            {
                ListCBTablas.SetItemChecked(i, CBMarcarTodasTablas.Checked);
            }
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
            {
                ListCBTablas.SetItemChecked(i, false);
            }

            CBMarcarTodasTablas.Checked = false;

            if (tables.Length > 0)
            {
                switch (CBView.SelectedItem)
                {
                    case "Tablas":
                        {
                            /*--La consulta muestra todas las tablas de la base de datos*/
                            PropertyTables(tables);

                            break;
                        }
                    case "Vistas":
                        {
                            /*--La consulta muestra todas las vistas de la base de datos*/
                            StructureViews(tables);

                            break;
                        }
                    case "Procedimientos":
                        {
                            /*--La consulta muestra todos los procedimientos de la base de datos*/
                            StructureProcedure(tables);

                            break;
                        }
                    case "Triggers":
                        {
                            /*--La consulta muestra todos los triggers de la base de datos*/
                            StructureTriggers(tables);

                            break;
                        }
                    case "Functions":
                        {
                            /*--La consulta muestra todos los Functions de la base de datos*/

                            StructureFunctions(tables);

                            break;
                        }
                    default:
                        {
                            PropertyTables(tables);

                            break;
                        }

                }

            }
            else
            {
                MessageBox.Show("Sin " + CBView.Text + " marcado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Cursor = Cursors.Default;
        }


        private async void PropertyTables(string[] tables)
        {
            try
            {
                var listTable = await ConnectionString
                .GetInstance()
                .GetTablesProperty(TBServidor.Text_, CBBBaseDatos.Text, RBAutenticacionW.Checked, tables, TBUsuario.Text_, TBContraseña.Text_);

                if (listTable != null)
                {
                    FromReport FromReport = new FromReport();

                    Reports.Report report = new Reports.Report();

                    report.TBCompanyName.Value = TBCompanyName.Text_;

                    report.objectDataSource.DataSource = listTable;


                    report.reportNameTextBox.Value = "Resporte de tabla : Servidor = " +
                                                            TBServidor.Text_ + "; " +
                                                            "Base de datos = " +
                                                            CBBBaseDatos.Text + ";";

     
                    FromReport.reportViewer.ShowPrintPreviewButton = true;
                    FromReport.reportViewer.ReportSource = report;
                    FromReport.reportViewer.RefreshReport();

                    this.Cursor = Cursors.Default;

                    FromReport.Show();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
            }
        }

        private async void StructureViews(string[] tables)
        {
            var listTable = await ConnectionString
                .GetInstance()
                .GetStructureViews(TBServidor.Text_, CBBBaseDatos.Text, RBAutenticacionW.Checked, tables, TBUsuario.Text_, TBContraseña.Text_);
        }

        private async void StructureProcedure(string[] tables)
        {
            var listTable = await ConnectionString
                .GetInstance()
                .GetStructureProcedures(TBServidor.Text_, CBBBaseDatos.Text, RBAutenticacionW.Checked, tables, TBUsuario.Text_, TBContraseña.Text_);
        }

        private async void StructureTriggers(string[] tables)
        {
            var listTable = await ConnectionString
                .GetInstance()
                .GetStructureTriggers(TBServidor.Text_, CBBBaseDatos.Text, RBAutenticacionW.Checked, tables, TBUsuario.Text_, TBContraseña.Text_);
        }

        private async void StructureFunctions(string[] tables)
        {
            var listTable = await ConnectionString
                .GetInstance()
                .GetStructureFunctions(TBServidor.Text_, CBBBaseDatos.Text, RBAutenticacionW.Checked, tables, TBUsuario.Text_, TBContraseña.Text_);
        }
        
        private async void BTBuscarBaseDatos_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                CBBBaseDatos.Items.Add("Seleccione una Base de datos");

                foreach (string tableName in await ConnectionString
                .GetInstance()
                .GetDataBases(TBServidor.Text_, RBAutenticacionW.Checked, TBUsuario.Text_, TBContraseña.Text_))
                {
                    CBBBaseDatos.Items.Add(tableName);
                }

                CBBBaseDatos.SelectedIndex = 0;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Cursor = Cursors.Default;
        }

        private void CBView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BTConeccion.Text = "Buscar " + CBView.SelectedItem;
        }

    }
}
