
namespace DSRG
{
    using System;
    using System.Windows.Forms;
    using static global::DSRG.Services.Enums;

    static class ButtonExtensiones
    {
        private static Theme _Tema;
        public static Theme Tema(this Button Button)
        {
            return _Tema;
        }


        public static void Temas(this Button Button, Theme tema)
        {
            _Tema = tema;

            Button.BackColor = System.Drawing.Color.Transparent;
            Button.BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundBlue1;
            Button.BackgroundImageLayout = ImageLayout.Stretch;
            Button.Cursor = Cursors.Hand;
            Button.FlatAppearance.BorderSize = 0;
            Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            Button.FlatStyle = FlatStyle.Flat;
            Button.Margin = new Padding(0);
            Button.UseVisualStyleBackColor = false;

            Button.ForeColor = System.Drawing.Color.Black;

            switch (tema)
            {
                case Theme.Azul:
                    {
                        Button.BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundBlue3;

                        break;
                    }
                case Theme.Blanco:
                    {
                        Button.BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundWhite3;

                        break;
                    }
                case Theme.Amarillo:
                    {
                        Button.BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundYellow3;

                        break;
                    }
                case Theme.Gris:
                    {
                        Button.BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundGray3;

                        break;
                    }
                case Theme.Negro:
                    {
                        Button.BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundBlack3;
                        Button.ForeColor = System.Drawing.Color.White;

                        break;
                    }
                case Theme.Naranja:
                    {
                        Button.BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundOrange3;

                        break;
                    }
                case Theme.Verde:
                    {
                        Button.BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundGreen3;

                        break;
                    }
                case Theme.DarMode:
                    {
                        Button.BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundWhite3;

                        break;
                    }

            };

            Button.MouseDown += new MouseEventHandler((object sender, MouseEventArgs e) =>
            {
                Button.ForeColor = System.Drawing.Color.Black;

                switch (tema)
                {
                    case Theme.Azul:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundBlue3;

                            break;
                        }
                    case Theme.Blanco:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundWhite3;

                            break;
                        }
                    case Theme.Amarillo:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundYellow3;

                            break;
                        }
                    case Theme.Gris:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundGray3;

                            break;
                        }
                    case Theme.Negro:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundBlack3;
                            ((Button)sender).ForeColor = System.Drawing.Color.White;

                            break;
                        }
                    case Theme.Naranja:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundOrange3;

                            break;
                        }
                    case Theme.Verde:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundGreen3;

                            break;
                        }
                    case Theme.DarMode:
                        {
                            Button.BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundWhite3;

                            break;
                        }
                };

            });

            Button.MouseEnter += new EventHandler((object sender, EventArgs e) =>
            {
                Button.ForeColor = System.Drawing.Color.Black;

                switch (tema)
                {
                    case Theme.Azul:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundBlue2;

                            break;
                        }
                    case Theme.Blanco:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundWhite2;

                            break;
                        }
                    case Theme.Amarillo:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundYellow2;

                            break;
                        }
                    case Theme.Gris:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundGray2;

                            break;
                        }
                    case Theme.Negro:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundBlack2;
                            ((Button)sender).ForeColor = System.Drawing.Color.White;

                            break;
                        }
                    case Theme.Naranja:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundOrange2;

                            break;
                        }
                    case Theme.Verde:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundGreen2;

                            break;
                        }
                    case Theme.DarMode:
                        {
                            Button.BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundWhite3;

                            break;
                        }
                };

            });

            Button.MouseLeave += new EventHandler((object sender, EventArgs e) =>
            {
                Button.ForeColor = System.Drawing.Color.Black;

                switch (tema)
                {
                    case Theme.Azul:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundBlue1;

                            break;
                        }
                    case Theme.Blanco:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundWhite1;

                            break;
                        }
                    case Theme.Amarillo:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundYellow1;

                            break;
                        }
                    case Theme.Gris:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundGray1;

                            break;
                        }
                    case Theme.Negro:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundBlack1;
                            ((Button)sender).ForeColor = System.Drawing.Color.White;

                            break;
                        }
                    case Theme.Naranja:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundOrange1;

                            break;
                        }
                    case Theme.Verde:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundGreen1;

                            break;
                        }
                    case Theme.DarMode:
                        {
                            Button.BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundWhite3;

                            break;
                        }
                };

            });

            Button.MouseUp += new MouseEventHandler((object sender, MouseEventArgs e) =>
            {
                Button.ForeColor = System.Drawing.Color.Black;

                switch (tema)
                {
                    case Theme.Azul:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundBlue2;

                            break;
                        }
                    case Theme.Blanco:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundWhite2;

                            break;
                        }
                    case Theme.Amarillo:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundYellow2;

                            break;
                        }
                    case Theme.Gris:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundGray2;

                            break;
                        }
                    case Theme.Negro:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundBlack2;
                            ((Button)sender).ForeColor = System.Drawing.Color.White;

                            break;
                        }
                    case Theme.Naranja:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundOrange2;

                            break;
                        }
                    case Theme.Verde:
                        {
                            ((Button)sender).BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundGreen2;

                            break;
                        }
                    case Theme.DarMode:
                        {
                            Button.BackgroundImage = global::DSRG.Properties.Resources.ButtomBackgroundWhite3;

                            break;
                        }
                };

            });

            
        }

    }
}
