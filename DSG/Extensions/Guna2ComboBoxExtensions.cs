using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace DSRG.Extensions
{
    public static class Guna2ComboBoxExtensions
    {
        public static bool IsEmpty(this Guna2ComboBox guna2TextBox) =>
            !(guna2TextBox.SelectedIndex != 0);

        /// <summary>
        /// Verifica si el indice seleccionado es 0, en dado caso invoca una aletar identificando que el indice seleccionado es 0.
        /// </summary>
        /// <param name="guna2TextBox"></param>
        /// <param name="name">Nombre del componente como se le presenta al usuario.</param>
        /// <param name="errorMessage">Mensaje que deseas implementar sustituyendo el mensaje por defecto.</param>
        /// <returns>Retorna verdadero si el indice seleccionado es mayor que 0, de lo contrario retorna falso.</returns>
        public static bool IsEmptyIconErrorProvider(this Guna2ComboBox guna2TextBox, string name, string errorMessage = null)
        {
            ErrorProvider errorProvider = new();

            bool isEmpty = guna2TextBox.SelectedIndex == 0;

            errorProvider.SetError(guna2TextBox, isEmpty ? errorMessage ?? $"El campo '{name}' está vacio." : "");

            guna2TextBox.TextChanged += new EventHandler((sender, e) => { errorProvider.SetError(guna2TextBox, ""); });

            return isEmpty;
        }

    }
}
