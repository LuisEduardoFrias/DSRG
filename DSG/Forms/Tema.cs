

namespace DSRG.Forms
{   
    using System;
    using System.Windows.Forms;
    using static global::DSRG.Services.Enums;
    //

    public partial class Tema : Form
    {
        Action<bool,Theme> _MetodoTema;
        bool _DartLightModo;

        private static Tema _Instance;
        public static Tema GetInstance(Action<bool, Theme> MetodoTema, bool DartLight)
        {
            if (_Instance == null)
                _Instance = new Tema(MetodoTema, DartLight);

            return _Instance;
        }

        private Tema(Action<bool, Theme> MetodoTema, bool DartLight)
        {
            InitializeComponent();

            BTLightMode.Location = new System.Drawing.Point(120, 137);
            panelTema.Size = new System.Drawing.Size(229, 173);
            this.Size = new System.Drawing.Size(245, 212);

            _DartLightModo = DartLight;

            if (DartLight)
            {
                BTDarMode.Visible = false;
                BTLightMode.Visible = true;
            }
            else
            {
                BTDarMode.Visible = true;
                BTLightMode.Visible = false;
            }

            _MetodoTema = MetodoTema;
        }


        private void BTBlackTheme_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "BTThemeNegro":
                    {
                        _MetodoTema(_DartLightModo, Theme.Negro);
                        BTDarMode.Temas(Theme.Negro);
                        BTLightMode.Temas(Theme.Negro);

                        break;
                    }
                case "BTThemeGris":
                    {
                        _MetodoTema(_DartLightModo, Theme.Gris);
                        BTDarMode.Temas(Theme.Gris);
                        BTLightMode.Temas(Theme.Gris);

                        break;
                    }
                case "BTThemeNaranja":
                    {
                        _MetodoTema(_DartLightModo, Theme.Naranja);
                        BTDarMode.Temas(Theme.Naranja);
                        BTLightMode.Temas(Theme.Naranja);

                        break;
                    }
                case "BTThemeBlanco":
                    {
                        _MetodoTema(_DartLightModo, Theme.Blanco);
                        BTDarMode.Temas(Theme.Blanco);
                        BTLightMode.Temas(Theme.Blanco);

                        break;
                    }
                case "BTThemeVerde":
                    {
                        _MetodoTema(_DartLightModo, Theme.Verde);
                        BTDarMode.Temas(Theme.Verde);
                        BTLightMode.Temas(Theme.Verde);

                        break;
                    }
                case "BTThemeAzul":
                    {
                        _MetodoTema(_DartLightModo, Theme.Azul);
                        BTDarMode.Temas(Theme.Azul);
                        BTLightMode.Temas(Theme.Azul);

                        break;
                    }
                case "BTThemeAmarillo":
                    {
                        _MetodoTema(_DartLightModo,Theme.Amarillo);
                        BTDarMode.Temas(Theme.Amarillo);
                        BTLightMode.Temas(Theme.Amarillo);

                        break;
                    }
                case "BTDarMode":
                    {
                        BTDarMode.Visible = false;
                        BTLightMode.Visible = true;

                        _DartLightModo = true;
                        _MetodoTema(_DartLightModo, BTDarMode.Tema());

                        break;
                    }
                case "BTLightMode":
                    {
                        BTDarMode.Visible = true;
                        BTLightMode.Visible = false;

                        _DartLightModo = false;
                        _MetodoTema(_DartLightModo, BTLightMode.Tema());

                        break;
                    }

            }
        }

        private void BTClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
