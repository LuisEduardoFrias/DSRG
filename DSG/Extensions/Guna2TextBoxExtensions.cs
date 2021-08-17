using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace DSRG.Extensions
{
    public static class Guna2TextBoxExtensions
    {
        public static void IsEmptyErrorProvider(this Guna2TextBox guna2TextBox, string name, string errorMessage = null)
        {
            if (string.IsNullOrEmpty(guna2TextBox.Text.Trim()) is true)
                MessageBox.Show(errorMessage ?? $"El campo {name} está vacio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public static bool IsEmpty(this Guna2TextBox guna2TextBox) =>
            string.IsNullOrEmpty(guna2TextBox.Text.Trim());

        /// <summary>
        /// Verifica si el campo esta vacio, en dado caso invoca una aletar identificando campo vacio.
        /// </summary>
        /// <param name="guna2TextBox"></param>
        /// <param name="name">Nombre del componente como se le presenta al usuario.</param>
        /// <param name="errorMessage">Mensaje que deseas implementar sustituyendo el mensaje por defecto.</param>
        /// <returns>Retorna verdadero si el campo esta vacio, de lo contrario retorna falso.</returns>
        public static bool IsEmptyIconErrorProvider(this Guna2TextBox guna2TextBox, string name , string errorMessage = null)
        {
            ErrorProvider errorProvider = new();

            bool isEmpty = string.IsNullOrEmpty(guna2TextBox.Text.Trim());

            errorProvider.SetError(guna2TextBox, isEmpty ? errorMessage ?? $"El campo '{name}' está vacio." : "");

            guna2TextBox.TextChanged    += new EventHandler((sender, e) => { errorProvider.SetError(guna2TextBox, ""); } );
            guna2TextBox.EnabledChanged += new EventHandler((sender, e) => { if (!guna2TextBox.Enabled) errorProvider.SetError(guna2TextBox, ""); });

            return isEmpty;
        }

        public static int? ToInt(this Guna2TextBox guna2TextBox)
        {
            if (string.IsNullOrEmpty(guna2TextBox.Text)) 
                return null;

            return int.Parse(guna2TextBox.Text); 
        }
    }
}
