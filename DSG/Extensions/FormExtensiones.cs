

namespace DSRG.Extensions
{
    using global::DSRG.Forms;
    //

    public static class FormExtensiones
    {
        public static Tema ShowTheme(this Tema tema)
        {
            tema.Show();
            return tema;
        }
    }
}
