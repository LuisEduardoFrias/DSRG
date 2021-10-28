using CrossCutting.Models;
using DataAccess.Class;
using Domainn;
using DSRG.Extensions;
using Newtonsoft.Json;
using Presentation.Recursos;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class DSRG : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public DSRG()
        {
            InitializeComponent();

            CBView.SelectedIndex = 0;
            CBBReportType.SelectedIndex = 0;

            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\Datos"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Datos");

                File.Create(Directory.GetCurrentDirectory() + @"\Datos\Datos.json").Close();
            }

            DatosCredenciales obj = JsonConvert.DeserializeObject<DatosCredenciales>(
                File.ReadAllText(Directory.GetCurrentDirectory() + @"\Datos\Datos.json", System.Text.Encoding.UTF8));

            if (obj is not null)
            {
                TBServer.Text = Business.Decrypt(obj.Servidor);
                CBBDataBase.Text = Business.Decrypt(obj.BaseDatos);
                TBUser.Text = Business.Decrypt(obj.Usuario);
                TBPasswork.Text = Business.Decrypt(obj.Contraseña);
                RBAutenticationS.Checked = !obj.AutenticacionWindows;
                CBSaveDatas.Checked = obj.GuardarDatos;
            }
        }

        //private void BTMinimize_Click(object sender, EventArgs e)
        //{
        //    WindowState = FormWindowState.Minimized;
        //}

        //private void BTNormal_Click(object sender, EventArgs e)
        //{
        //    BTNormal.Visible = false;
        //    BTNormal.Enabled = false;
        //    BTMaximize.Visible = true;
        //    BTMaximize.Enabled = true;
        //    WindowState = FormWindowState.Normal;
        //}

        //private void BTMaximize_Click(object sender, EventArgs e)
        //{
        //    BTNormal.Visible = true;
        //    BTNormal.Enabled = true;
        //    BTMaximize.Visible = false;
        //    BTMaximize.Enabled = false;
        //    WindowState = FormWindowState.Maximized;
        //}

        //private void BTClose_Click(object sender, EventArgs e)
        //{
        //    if (DialogResult.Yes == MessageBox.Show("¿SEGURO QUE DESEA CERRAR LA APLICACIÓN?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        //        Application.Exit();
        //}

        private void RBAutenticacionW_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAutenticationW.Checked is true)
                GBCredenciales.Enabled = false;
            else
                GBCredenciales.Enabled = true;
        }

        private async void TBGetDataBas_Click(object sender, EventArgs e)
        {
            if (!TBServer.IsEmptyIconErrorProvider("Servidor") & 
                (RBAutenticationS.Checked == true ? (!TBPasswork.IsEmptyIconErrorProvider("Contraseña") & !TBUser.IsEmptyIconErrorProvider("Usuario")) : true))
            {
                this.Cursor = Cursors.WaitCursor;

                CBBDataBase.Items.Clear();
                CBBDataBase.Items.Add("Seleccione una Base de datos");
                CBBDataBase.SelectedIndex = 0;

                List<string> structures = await Connection.GetInstance(TBServer.Text, RBAutenticationW.Checked, null, TBPort.ToInt(), TBUser.Text, TBPasswork.Text).GetConecction().GetDataBases();

                if(!structures.Equals(null))
                {
                    foreach (string tableName in structures)
                    {
                        CBBDataBase.Items.Add(tableName);
                    }

                    if (CBSaveDatas.Checked is true)
                        using (StreamWriter file = File.CreateText(Directory.GetCurrentDirectory() + @"\Datos\Datos.json"))
                            new JsonSerializer().Serialize(file, new DatosCredenciales
                            {
                                Servidor = Business.Encrypt(TBServer.Text),
                                BaseDatos = Business.Encrypt(CBBDataBase.Text),
                                Usuario = Business.Encrypt(TBUser.Text),
                                Contraseña = Business.Encrypt(TBPasswork.Text),
                                AutenticacionWindows = RBAutenticationW.Checked,
                                GuardarDatos = CBSaveDatas.Checked
                            });

                    CBBDataBase.Enabled = true;
                    CBBDataBase.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Error inesperado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Cursor = Cursors.Default;
            }

        }

        private void CBBBaseDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBDataBase.IsEmpty())
                ActivarBTConeccion(false);
            else
                ActivarBTConeccion(true);
        }

        private void CBView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BTSearch.Text = $"Buscar {CBView.SelectedItem}";
        }

        private void BTConeccion_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (!TBServer.IsEmptyIconErrorProvider("Servidor") &
                (RBAutenticationS.Checked == true ? (!TBPasswork.IsEmptyIconErrorProvider("Contraseña") & !TBUser.IsEmptyIconErrorProvider("Usuario")) : true) &
                !CBBDataBase.IsEmptyIconErrorProvider("Base de datos"))
            {
                GetStructure();
            }

            this.Cursor = Cursors.Default;
        }

        private void CBMarcarTodasTablas_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ListCB.Items.Count; i++)
                ListCB.SetItemChecked(i, ChBMarkAllStructures.Checked);
        }

        private async void BTGenerarReporte_Click(object sender, EventArgs e)
        {
            bool mensaje = false;
            for (int i = 0; i < ListCB.Items.Count; i++)
                if (ListCB.GetItemChecked(i))
                {
                    await GenerarReporte();
                    mensaje = false;
                    break;
                }
                else
                    mensaje = true;

            if(mensaje)
                MessageBox.Show("No hay tablas seleccionadas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ActivarBTConeccion(bool value)
        {
            BTSearch.Enabled = value;
        }

        private async void GetStructure()
        {
            ListCB.Items.Clear();

            foreach (string tableName in await Connection.GetInstance(TBServer.Text, RBAutenticationW.Checked, CBBDataBase.Text, TBPort.ToInt(), TBUser.Text, TBPasswork.Text).GetConecction().GetEstructuras(CBView.Text))
                ListCB.Items.Add(tableName);

            TablasCount.Text = $"Estructuras: {ListCB.Items.Count}";
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DSRG\n\"Database Structure Report Generator.\"\n\nVersión 1.5\n\nDSRG made by Luis Eduardo Frías, es una generado de reporte de base de datos relacionales, actual mente conpatible con Sql Server y  MySql.\n\nCopyRight © 2021\nTodos los derechos reservados.\n" +
                "Los Programas de Computadora (en lo adelante “software”), definidos en nuestra legislación están protegidos en la República " +
                "Dominicana a través de la figura del Derecho de Autor, la cual está contemplada en la Ley 65-00 sobre Derecho de Autor.",
                "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Determina que metodo ejecutar segun la estructura seleccionada.
        /// </summary>
        private async Task GenerarReporte()
        {
            this.Cursor = Cursors.WaitCursor;

            #region Obtener los checked seleccionados

                string[] tables = new string[ListCB.CheckedItems.Count];

                int c = 0;
                foreach (string table in ListCB.CheckedItems)
                {
                    tables[c] = table;

                    c++;
                }

            #endregion

            ListCB.ClearSelected();

            ChBMarkAllStructures.Checked = false;

            if (tables.Length > 0)
                await DataStructures(tables);
            else
                MessageBox.Show("No hay opciones marcadas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Cursor = Cursors.Default;
        }

        #region sin completar

        private async Task DataStructures(string[] tables)
        {
            async Task<List<Table>> Switch(string x) => x switch
            {
                "Tablas" => await Connection.GetInstance(TBServer.Text, RBAutenticationW.Checked, CBBDataBase.Text, TBPort.ToInt(),  TBUser.Text, TBPasswork.Text).GetConecction().GetTablesProperty(tables),

                //"Vistas" => await Connection.Get().GetStructureViews(TBServer.Text, CBBDataBase.Text, RBAutenticationW.Checked, tables, TBUser.Text, TBPasswork.Text),

                //"Procedimientos" => await Connection.Get().GetStructureProcedures(TBServer.Text, CBBDataBase.Text, RBAutenticationW.Checked, tables, TBUser.Text, TBPasswork.Text),

                //"Triggers" => await Connection.Get().GetStructureTriggers(TBServer.Text, CBBDataBase.Text, RBAutenticationW.Checked, tables, TBUser.Text, TBPasswork.Text),

                //"Functions" => await Connection.Get().GetStructureFunctions(TBServer.Text, CBBDataBase.Text, RBAutenticationW.Checked, tables, TBUser.Text, TBPasswork.Text),

                _ => await Connection.GetInstance(TBServer.Text,  RBAutenticationW.Checked, CBBDataBase.Text, TBPort.ToInt(), TBUser.Text, TBPasswork.Text).GetConecction().GetTablesProperty(tables)
            };

            List<Table> listTable = await Switch((string)CBView.SelectedItem);

            if (listTable is not null)
            {
                if (CBBReportType.SelectedIndex == 0)
                    ExcelReport(listTable);
                else if (CBBReportType.SelectedIndex == 1)
                    TelerikReport(listTable);
                else if (CBBReportType.SelectedIndex == 2)
                    HtmlReport(listTable);
            }
            else
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion


        private void ExcelReport(List<Table> listTable)
        {
            try
            {
                this.UseWaitCursor = true;

                List<DataTable> tables = new();
                DataTable dataTable = new();
                SLDocument document = new();

                //----------------------- Styles ---------------------------//

                SLPageSettings ps = new();

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

                    foreach (DataRow row in dataTable.Rows)
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

                tables = new List<DataTable>();
                dataTable = new DataTable();

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
                        tables.Add(new DataTable { TableName = table.TableName });

                        dataTable = tables.FirstOrDefault(x => x.TableName == table.TableName);

                        foreach (Tuple<string, Type> column in columns)
                        {
                            dataTable.Columns.Add(column.Item1, column.Item2);
                        }
                    }

                    string precision = table.PropertyPrecision ?? string.Empty;
                    string scale = table.PropertyScale ?? string.Empty;

                    string type = Business.StringToUpperCase(table.PropertyType);

                    dataTable.Rows.Add(
                        table.PropertyName,
                        type,
                        table.PropertyLeangth is null or "" ?
                        (type is "INT" ? string.Empty : (table.PropertyPrecision is null or "" ? string.Empty : $"({precision}, {scale})")) : table.PropertyLeangth,
                        table.IsNullable,
                        table.ColumnDefault ?? string.Empty,
                        table.ConstraintName ?? string.Empty);
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

                SaveFileDialog saveFileDialog = new();
                saveFileDialog.Filter = "Libro de Excel|*.xlsx";
                saveFileDialog.Title = "Save an html File";
                saveFileDialog.ShowDialog();

                document.SaveAs(saveFileDialog.FileName); //Path.Combine(, "Archivo de tablas.xlsx"));

                Listo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.UseWaitCursor = false;
        }

        private void TelerikReport(List<Table> listTable)
        {
            FromReport FromReport = new();

            Reports.Report report = new();

            //report.TBCompanyName.Value = TBCompanyName.Text;

            report.objectDataSource.DataSource = listTable;

            report.reportNameTextBox.Value = $"Resporte de tabla : Servidor = {TBServer.Text};  base de datos = {CBBDataBase.Text};";

            FromReport.reportViewer.ShowPrintPreviewButton = true;
            FromReport.reportViewer.ReportSource = report;
            FromReport.reportViewer.RefreshReport();

            this.Cursor = Cursors.Default;

            FromReport.Show();
        }

        private void HtmlReport(List<Table> listTable)
        {
            List<DataTable> tables = new();
            DataTable dataTable = new();

            Tuple<string, Type>[] columns = new Tuple<string, Type>[]
            {
                    Tuple.Create("Campo", typeof(string)),
                    Tuple.Create("Tipo de datos", typeof(string)),
                    Tuple.Create("Longitud", typeof(string)),
                    Tuple.Create("Null", typeof(string)),
                    Tuple.Create("Default", typeof(string)),
                    Tuple.Create("Restricción", typeof(string))
            };

            foreach (var table in listTable)
            {
                if (!tables.Any(x => x.TableName == table.TableName))
                {
                    tables.Add(new DataTable { TableName = table.TableName });

                    dataTable = tables.FirstOrDefault(x => x.TableName == table.TableName);

                    foreach (Tuple<string, Type> column in columns)
                    {
                        dataTable.Columns.Add(column.Item1, column.Item2);
                    }
                }

                string precision = table.PropertyPrecision ?? string.Empty;
                string scale = table.PropertyScale ?? string.Empty;

                string type = Business.StringToUpperCase(table.PropertyType);

                dataTable.Rows.Add(
                    table.PropertyName,
                    type,
                    table.PropertyLeangth is null or "" ?
                    (type is "INT" ? string.Empty : (table.PropertyPrecision is null or "" ? string.Empty : $"({precision}, {scale})")) : table.PropertyLeangth,
                    table.IsNullable,
                    table.ColumnDefault ?? string.Empty,
                    table.ConstraintName ?? string.Empty);
            }

            string html_ = HtmlResource.HTML;
            string table_ = HtmlResource.Table;
            string row_ = HtmlResource.Rows;

            string rows = default;
            string text = default;

            foreach (DataTable table in tables)
            {
                rows = default;

                foreach (DataRow row in table.Rows)
                {
                    rows += row_
                       .Replace("ROW1", row[0].ToString())
                       .Replace("ROW2", row[1].ToString())
                       .Replace("ROW3", row[2].ToString())
                       .Replace("ROW4", row[3].ToString())
                       .Replace("ROW5", row[4].ToString())
                       .Replace("ROW6", row[5].ToString());
                }

                text += table_.Replace("TABLENAME", table.TableName).Replace("ROWS", rows);
            }

            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "web html|*.html";
            saveFileDialog.Title = "Save an html File";
            saveFileDialog.ShowDialog();

            File.WriteAllText(saveFileDialog.FileName, html_.Replace("TABLES", text));

            Listo();
        }

        private void Listo()
        {
            Task.Run(() =>
            {
                MessageBox.Show("Listo.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }

    }
}