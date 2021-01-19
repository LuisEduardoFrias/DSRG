
namespace DSG
{
    using System;
    using System.Windows.Forms;


    public enum Tema
    {
        Negro,
        Blanco,
        Azul,
        Verde,
        Gris,
        Naranja,
        Amarillo,
        DarMode
    }

    static class ButtonExtensiones
    {
        public static void Temas(this Button Button, Tema tema_)
        {
            Button.BackColor = System.Drawing.Color.Transparent;
            Button.BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundBlue1;
            Button.BackgroundImageLayout = ImageLayout.Stretch;
            Button.Cursor = Cursors.Hand;
            Button.FlatAppearance.BorderSize = 0;
            Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            Button.FlatStyle = FlatStyle.Flat;
            Button.Margin = new Padding(0);
            Button.UseVisualStyleBackColor = false;

            Button.ForeColor = System.Drawing.Color.Black;

            switch (tema_)
            {
                case Tema.Azul:
                    {
                        Button.BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundBlue3;

                        break;
                    }
                case Tema.Blanco:
                    {
                        Button.BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundWhite3;

                        break;
                    }
                case Tema.Amarillo:
                    {
                        Button.BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundYellow3;

                        break;
                    }
                case Tema.Gris:
                    {
                        Button.BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundGray3;

                        break;
                    }
                case Tema.Negro:
                    {
                        Button.BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundBlack3;
                        Button.ForeColor = System.Drawing.Color.White;

                        break;
                    }
                case Tema.Naranja:
                    {
                        Button.BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundOrange3;

                        break;
                    }
                case Tema.Verde:
                    {
                        Button.BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundGreen3;

                        break;
                    }
                case Tema.DarMode:
                    {
                        Button.BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundWhite3;

                        break;
                    }

            };

            Button.MouseDown += new MouseEventHandler((object sender, MouseEventArgs e) =>
            {
                Button.ForeColor = System.Drawing.Color.Black;

                switch (tema_)
                {
                    case Tema.Azul:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundBlue3;

                            break;
                        }
                    case Tema.Blanco:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundWhite3;

                            break;
                        }
                    case Tema.Amarillo:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundYellow3;

                            break;
                        }
                    case Tema.Gris:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundGray3;

                            break;
                        }
                    case Tema.Negro:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundBlack3;
                            ((Button)sender).ForeColor = System.Drawing.Color.White;

                            break;
                        }
                    case Tema.Naranja:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundOrange3;

                            break;
                        }
                    case Tema.Verde:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundGreen3;

                            break;
                        }
                    case Tema.DarMode:
                        {
                            Button.BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundWhite3;

                            break;
                        }
                };

            });

            Button.MouseEnter += new EventHandler((object sender, EventArgs e) =>
            {
                Button.ForeColor = System.Drawing.Color.Black;

                switch (tema_)
                {
                    case Tema.Azul:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundBlue2;

                            break;
                        }
                    case Tema.Blanco:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundWhite2;

                            break;
                        }
                    case Tema.Amarillo:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundYellow2;

                            break;
                        }
                    case Tema.Gris:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundGray2;

                            break;
                        }
                    case Tema.Negro:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundBlack2;
                            ((Button)sender).ForeColor = System.Drawing.Color.White;

                            break;
                        }
                    case Tema.Naranja:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundOrange2;

                            break;
                        }
                    case Tema.Verde:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundGreen2;

                            break;
                        }
                    case Tema.DarMode:
                        {
                            Button.BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundWhite3;

                            break;
                        }
                };

            });

            Button.MouseLeave += new EventHandler((object sender, EventArgs e) =>
            {
                Button.ForeColor = System.Drawing.Color.Black;

                switch (tema_)
                {
                    case Tema.Azul:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundBlue1;

                            break;
                        }
                    case Tema.Blanco:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundWhite1;

                            break;
                        }
                    case Tema.Amarillo:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundYellow1;

                            break;
                        }
                    case Tema.Gris:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundGray1;

                            break;
                        }
                    case Tema.Negro:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundBlack1;
                            ((Button)sender).ForeColor = System.Drawing.Color.White;

                            break;
                        }
                    case Tema.Naranja:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundOrange1;

                            break;
                        }
                    case Tema.Verde:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundGreen1;

                            break;
                        }
                    case Tema.DarMode:
                        {
                            Button.BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundWhite3;

                            break;
                        }
                };

            });

            Button.MouseUp += new MouseEventHandler((object sender, MouseEventArgs e) =>
            {
                Button.ForeColor = System.Drawing.Color.Black;

                switch (tema_)
                {
                    case Tema.Azul:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundBlue2;

                            break;
                        }
                    case Tema.Blanco:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundWhite2;

                            break;
                        }
                    case Tema.Amarillo:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundYellow2;

                            break;
                        }
                    case Tema.Gris:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundGray2;

                            break;
                        }
                    case Tema.Negro:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundBlack2;
                            ((Button)sender).ForeColor = System.Drawing.Color.White;

                            break;
                        }
                    case Tema.Naranja:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundOrange2;

                            break;
                        }
                    case Tema.Verde:
                        {
                            ((Button)sender).BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundGreen2;

                            break;
                        }
                    case Tema.DarMode:
                        {
                            Button.BackgroundImage = global::DSG.Properties.Resources.ButtomBackgroundWhite3;

                            break;
                        }
                };

            });

        }

    }
}
