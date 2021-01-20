
namespace DSG
{
    using System.Drawing;
    using System.Windows.Forms;
    //

    public partial class DSG : Form
    {
        public DSG()
        {
            InitializeComponent();

            BTGenerarReporte.Temas(Tema.Verde);
            BTConeccion.Temas(Tema.Verde);
            BTBuscarBaseDatos.Temas(Tema.Verde);

            CBView.SelectedIndex = 0;
        }

        private void CBSinCredenciales_CheckedChanged(object sender, System.EventArgs e)
        {
            if(CBSinCredenciales.Checked == true)
            {
                TBUsuario.Enabled = false;
                TBContraseña.Enabled = false;
                CBSinCredenciales.BackColor = Color.FromArgb(109, 168, 68);
            }
            else
            {
                TBUsuario.Enabled = true;
                TBContraseña.Enabled = true;
                CBSinCredenciales.BackColor = Color.White;
            }
        }

        private async void BTConeccion_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if
            (
               TBServidor.IsEmptyErrorProvider() |
               CBBBaseDatos.Text == string.Empty |
               CBBBaseDatos.SelectedIndex == 0
            )
            {
                if (CBSinCredenciales.Checked == false)
                {
                    TBUsuario.IsEmptyErrorProvider();
                    TBContraseña.IsEmptyErrorProvider();
                }

                if(CBBBaseDatos.Text == string.Empty | CBBBaseDatos.SelectedIndex == 0) 
                {
                    MessageBox.Show("escriba una base de datos o busque una para lesecionar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                 if (CBSinCredenciales.Checked == false)
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
                         .GetTables(TBServidor.Text_, CBBBaseDatos.Text, CBSinCredenciales.Checked, CBView.Text, TBUsuario.Text_, TBContraseña.Text_))
                {
                    ListCBTablas.Items.Add(tableName);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void CBMarcarTodasTablas_CheckedChanged(object sender, System.EventArgs e)
        {
            for (int i = 0; i < ListCBTablas.Items.Count; i++)
            {
                ListCBTablas.SetItemChecked(i, CBMarcarTodasTablas.Checked);
            }
        }

        private async void BTGenerarReporte_Click(object sender, System.EventArgs e)
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

            if (tables.Length > 0)
            {
                try
                {
                    var listTable = await ConnectionString
                    .GetInstance()
                    .GetTablesProperty(TBServidor.Text_, CBBBaseDatos.Text, CBSinCredenciales.Checked, tables, TBUsuario.Text_, TBContraseña.Text_);

                    FromReport FromReport = new FromReport();

                    Reports.Report report = new Reports.Report();

                    report.CompanyName.Value = TBCompanyName.Text_;
                    report.table.DataSource = listTable;

                    FromReport.reportViewer.ShowPrintPreviewButton = true;
                    FromReport.reportViewer.Report = report;
                    FromReport.reportViewer.RefreshReport();

                    this.Cursor = Cursors.Default;

                    FromReport.Show();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sin " + CBView.Text + " marcado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Cursor = Cursors.Default;
        }

        private async void BTBuscarBaseDatos_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            CBBBaseDatos.Items.Add("Seleccione una Base de datos");

            foreach (string tableName in await ConnectionString
            .GetInstance()
            .GetDataBases(TBServidor.Text_, CBSinCredenciales.Checked, TBUsuario.Text_, TBContraseña.Text_))
            {
                CBBBaseDatos.Items.Add(tableName);
            }

            CBBBaseDatos.SelectedIndex = 0;

            this.Cursor = Cursors.Default;
        }
    }
}
