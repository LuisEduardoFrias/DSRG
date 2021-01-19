namespace Controles_Personalizado
{
    partial class TextBoxIEP
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBox_ = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_
            // 
            this.TextBox_.BackColor = System.Drawing.Color.White;
            this.TextBox_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBox_.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_.ForeColor = System.Drawing.Color.Black;
            this.TextBox_.Location = new System.Drawing.Point(5, 5);
            this.TextBox_.MinimumSize = new System.Drawing.Size(15, 15);
            this.TextBox_.Name = "TextBox_";
            this.TextBox_.Size = new System.Drawing.Size(100, 15);
            this.TextBox_.TabIndex = 1;
            this.TextBox_.SizeChanged += new System.EventHandler(this.TextBox__SizeChanged);
            this.TextBox_.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // TextBoxIEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Controles_Personalizado.Properties.Resources.ImageTextBox;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.TextBox_);
            this.DoubleBuffered = true;
            this.Name = "TextBoxIEP";
            this.Size = new System.Drawing.Size(125, 25);
            this.SizeChanged += new System.EventHandler(this.TextBoxIEP_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
