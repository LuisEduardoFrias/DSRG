
using System.Drawing;
using System.Windows.Forms;

namespace DSG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BTGenerarReporte.Temas(Tema.Verde);
            BTConeccion.Temas(Tema.Verde);
        }

        private void CBSinCredenciales_CheckedChanged(object sender, System.EventArgs e)
        {
            if(CBSinCredenciales.Checked == true)
            {
                TBUsuario.Enabled = false;
                TBContraseña.Enabled = false;
                CBSinCredenciales.BackColor = Color.Green;
            }
            else
            {
                TBUsuario.Enabled = true;
                TBContraseña.Enabled = true;
                CBSinCredenciales.BackColor = Color.White;
            }
        }

        private void BTConeccion_Click(object sender, System.EventArgs e)
        {
            if
            (
               (TBServidor.IsEmptyErrorProvider() |
               TBBaseDatos.IsEmptyErrorProvider()) ||
               CBBGestor.SelectedIndex == 0
            )
            {
                if (CBSinCredenciales.Checked == false)
                {
                    TBUsuario.IsEmptyErrorProvider();
                    TBContraseña.IsEmptyErrorProvider();
                }
            }
            else
            {
                if (CBSinCredenciales.Checked == false)
                    if
                    (
                        TBUsuario.IsEmptyErrorProvider() |
                        TBContraseña.IsEmptyErrorProvider()
                    )
                    {

                    }
                    else
                    {
                        
                    }
            }
        }
    }
}
