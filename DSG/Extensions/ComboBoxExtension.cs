
namespace DSRG.Extensions
{
    using System.Windows.Forms;
    //

    public static class ComboBoxExtension
    {
        public static void Empty(this ComboBox combobox)
        {
            combobox.SelectedIndex = 0;
        }

        public static bool IsEmpty(this ComboBox combobox)
        {
            return combobox.SelectedIndex is 0 && combobox.Text == string.Empty;
        }

        public static void Initial(this ComboBox combobox)
        {
            combobox.SelectedIndex = 0;
            combobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
