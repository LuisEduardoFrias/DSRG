
namespace Controles_Personalizado
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using System.ComponentModel;
    //

    public partial class TextBoxIEP : UserControl
    {

        #region propiedades

        private string _PlaceHolder = string.Empty;
        private bool _UseSystemPasswordChar;
        private bool _ErrorProvider;
        private bool _OnlyNumery;
        private bool _OnlyDecimal;
        private bool _OnlyLetter;

        public int MaxLength 
        {
            get
            {
                return TextBox_.MaxLength;
            }

            set
            {
                TextBox_.MaxLength = value;
            }
        }

        public string Name_
        { 
            get
            {
                return TextBox_.Name;
            }

            set
            {
                TextBox_.Name = value;
            }
        }

        public bool UseSystemPasswordChar
        {
            get
            {
                return _UseSystemPasswordChar;
            }

            set
            {
                _UseSystemPasswordChar = value;

                TextBox_.UseSystemPasswordChar = _UseSystemPasswordChar;

                if (!string.IsNullOrEmpty(_PlaceHolder))
                    TextBox_.UseSystemPasswordChar = false;
            }
        }
        
        public string Text_
        {
            get
            {
                return TextBox_.Text;
            }

            set
            {
                TextBox_.Text = value;
            }
        }

        public new string Text
        {
            get
            {
                return TextBox_.Text;
            }

            set
            {
                TextBox_.Text = value;
            }
        }

        public string PlaceHolder
        {
            get
            {
                return _PlaceHolder;
            }

            set
            {
                _PlaceHolder = value;

                if (!string.IsNullOrEmpty(_PlaceHolder))
                {
                    TextBox_.Text = _PlaceHolder;
                    TextBox_.ForeColor = Color.Gray;
                    MethodPlaceHolder();
                }
            }
        }

        public Color ForeColor
        {
            get
            {
                return TextBox_.ForeColor;
            }

            set
            {
                TextBox_.ForeColor = value;
            }
        }

        public Color BackColor
        {
            get
            {
                return TextBox_.BackColor;
            }

            set
            {
                TextBox_.BackColor = value;
            }
        }

        public bool ReadOnly
        {
            get
            {
                return TextBox_.ReadOnly;
            }

            set
            {
                TextBox_.ReadOnly = value;
            }
        }

        public bool Multiline
        {
            get
            {
                return TextBox_.Multiline;
            }

            set
            {
                TextBox_.Multiline = value;

                if (TextBox_.Multiline == true)
                {
                    this.Height = TextBox_.Height + 10;
                }
                else
                {
                    this.Height = 25;
                }
            }
        }

        public bool ErrorProvider
        {
            get
            {
                return _ErrorProvider;
            }

            set
            {
                _ErrorProvider = value;
            }
        }

        public bool OnlyNumery
        {
            get
            {
                return _OnlyNumery;
            }

            set
            {
                _OnlyNumery = value;

                if (_OnlyNumery == true)
                {
                    _OnlyDecimal = false;
                    _OnlyLetter = false;
                }
            }
        }

        public bool OnlyDecimal
        {
            get
            {
                return _OnlyDecimal;
            }

            set
            {
                _OnlyDecimal = value;

                if (_OnlyDecimal == true)
                {
                    _OnlyNumery = false;
                    _OnlyLetter = false;
                }
            }
        }

        public bool OnlyLetter
        {
            get
            {
                return _OnlyLetter;
            }

            set
            {
                _OnlyLetter = value;

                if (_OnlyLetter == true)
                {
                    _OnlyDecimal = false;
                    _OnlyNumery = false;
                }
            }
        }

        #endregion

        #region Eventos 

        public new TextBox TabIndexChanged { get { return this.TextBox_; } }
        public event EventHandler TextBoxIEP_TabIndexChanged
        {
            add { TextBox_.TabIndexChanged += value; }
            remove { TextBox_.TabIndexChanged -= value; }
        }

        public new TextBox TextChanged { get { return this.TextBox_; } }
        public event EventHandler TextBoxIEP_TextChanged
        {
            add { TextBox_.TextChanged += value; }
            remove { TextBox_.TextChanged -= value; }
        }

        public new TextBox Enter { get { return this.TextBox_; } }
        public event EventHandler TextBoxIEP_Enter
        {
            add { TextBox_.Enter += value; }
            remove { TextBox_.Enter -= value; }
        }

        public new TextBox KeyDown { get { return this.TextBox_; } }
        public event KeyEventHandler TextBoxIEP_KeyDown
        {
            add { TextBox_.KeyDown += value; }
            remove { TextBox_.KeyDown -= value; }
        }

        public new TextBox KeyPress { get { return this.TextBox_; } }
        public event KeyPressEventHandler TextBoxIEP_KeyPress
        {
            add { TextBox_.KeyPress += value; }
            remove { TextBox_.KeyPress -= value; }
        }

        public new TextBox KeyUp { get { return this.TextBox_; } }
        public event KeyEventHandler TextBoxIEP_KeyUp
        {
            add { TextBox_.KeyUp += value; }
            remove { TextBox_.KeyUp -= value; }
        }

        public new TextBox Leave { get { return this.TextBox_; } }
        public event EventHandler TextBoxIEP_Leave
        {
            add { TextBox_.Leave += value; }
            remove { TextBox_.Leave -= value; }
        }

        public new TextBox PreviewKeyDown { get { return this.TextBox_; } }
        public event PreviewKeyDownEventHandler TextBoxIEP_PreviewKeyDown
        {
            add { TextBox_.PreviewKeyDown += value; }
            remove { TextBox_.PreviewKeyDown -= value; }
        }

        #endregion


        public TextBoxIEP()
        {
            InitializeComponent();

        }


        #region metodo y evento del PlaceHolder

        private void MethodPlaceHolder()
        {
            TextBox_.MouseClick += new MouseEventHandler(textbox_MouseClick);

            //TextBox_.KeyPress += new KeyPressEventHandler(textbox_KeyPress);
            TextBox_.TextChanged += new EventHandler(textbox_TextChanged);

           TextBox_.Leave += new EventHandler(textbox_Leave);
        }

        private void textbox_MouseClick(object sender, EventArgs e)
        {
            TextBox_.SelectAll();
            TextBox_.HideSelection = true;
        }
        private void textbox_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_.Text == _PlaceHolder)
            {
                if (_UseSystemPasswordChar == true)
                    TextBox_.UseSystemPasswordChar = false;

                TextBox_.ForeColor = Color.Gray;
            }
            else
            {
                if (_UseSystemPasswordChar == true)
                    TextBox_.UseSystemPasswordChar = true;

                TextBox_.ForeColor = Color.Black;
            }
        }

        private void textbox_KeyPress(object sender, EventArgs e)
        {
            //if (TextBox_.Text == _PlaceHolder)
            //{
            //    if(_UseSystemPasswordChar == true)
            //        TextBox_.UseSystemPasswordChar = false;

            //    TextBox_.ForeColor = Color.Gray;
            //}
            //else
            //{
            //    if (_UseSystemPasswordChar == true)
            //        TextBox_.UseSystemPasswordChar = true;

            //    TextBox_.ForeColor = Color.Black;
            //}      
        }

        private void textbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox_.Text) && !string.IsNullOrEmpty(_PlaceHolder))
            {
                TextBox_.Text = _PlaceHolder;
                TextBox_.ForeColor = Color.Gray;
            }
        }


        #endregion

 

        private void TextBoxIEP_SizeChanged(object sender, EventArgs e)
        {
            if (TextBox_.Multiline == false)
            {
                this.Height = 25;

                TextBox_.Size = new Size(this.Width - 29, 15);

                if (TextBox_.Size.Width <= 16)
                    this.Width = 42;
            }
            else
            {
                TextBox_.Size = new Size(this.Width - 29, this.Height - 10);

                if (TextBox_.Size.Width <= 16)
                    this.Width = 42;
            }
        }

        public bool IsEmptyErrorProvider(string ErrorProviderMessaje = "ESTE CAMPO ES OBLIGATORIO.")
        {
            if (string.IsNullOrEmpty(TextBox_.Text.Trim()) ||
                TextBox_.Text == _PlaceHolder)
            {
                if (_ErrorProvider == true)
                {
                    errorProvider.SetError(TextBox_, ErrorProviderMessaje.ToUpper());
                }

                return true;
            }
            else
            {
                errorProvider.SetError(TextBox_, string.Empty);

                return false;
            }
        }

        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(TextBox_.Text.Trim()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Empty() => TextBox_.Text = string.Empty;

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_OnlyNumery)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }
            }

            if (_OnlyDecimal)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)46))
                {
                    e.Handled = true;
                    return;
                }

                if (e.KeyChar == (char)46)
                {
                    e.KeyChar = (char)44;
                }
            }

            if (_OnlyLetter)
            {
                if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void TextBox__SizeChanged(object sender, EventArgs e)
        {
            TextBox_.Width = this.Width - 29;
        }
    
    }
}
