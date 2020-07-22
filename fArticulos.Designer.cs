namespace Sistem_de_inventario
{
    partial class fArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fArtLblTitulo = new System.Windows.Forms.Label();
            this.fArtTxtPorcentaje = new System.Windows.Forms.TextBox();
            this.fArtTxtPrecio = new System.Windows.Forms.TextBox();
            this.fArtTxtNombre = new System.Windows.Forms.TextBox();
            this.fArtLbl4 = new System.Windows.Forms.Label();
            this.fArtLbl3 = new System.Windows.Forms.Label();
            this.fArtLbl1 = new System.Windows.Forms.Label();
            this.fArtBtnCancelar = new System.Windows.Forms.Button();
            this.fArtBtnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fArtLblTitulo
            // 
            this.fArtLblTitulo.AutoSize = true;
            this.fArtLblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fArtLblTitulo.Location = new System.Drawing.Point(274, 9);
            this.fArtLblTitulo.Name = "fArtLblTitulo";
            this.fArtLblTitulo.Size = new System.Drawing.Size(62, 20);
            this.fArtLblTitulo.TabIndex = 51;
            this.fArtLblTitulo.Text = "Artículo";
            // 
            // fArtTxtPorcentaje
            // 
            this.fArtTxtPorcentaje.Location = new System.Drawing.Point(156, 132);
            this.fArtTxtPorcentaje.Name = "fArtTxtPorcentaje";
            this.fArtTxtPorcentaje.Size = new System.Drawing.Size(342, 20);
            this.fArtTxtPorcentaje.TabIndex = 55;
            this.fArtTxtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FArtTxtPorcentaje_KeyPress);
            this.fArtTxtPorcentaje.Validating += new System.ComponentModel.CancelEventHandler(this.FArtTxtPorcentaje_Validating);
            // 
            // fArtTxtPrecio
            // 
            this.fArtTxtPrecio.Location = new System.Drawing.Point(156, 92);
            this.fArtTxtPrecio.Name = "fArtTxtPrecio";
            this.fArtTxtPrecio.Size = new System.Drawing.Size(342, 20);
            this.fArtTxtPrecio.TabIndex = 54;
            this.fArtTxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FArtTxtPrecio_KeyPress);
            this.fArtTxtPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.FArtTxtPrecio_Validating);
            // 
            // fArtTxtNombre
            // 
            this.fArtTxtNombre.Location = new System.Drawing.Point(156, 52);
            this.fArtTxtNombre.Name = "fArtTxtNombre";
            this.fArtTxtNombre.Size = new System.Drawing.Size(342, 20);
            this.fArtTxtNombre.TabIndex = 53;
            this.fArtTxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FArtTxtNombre_KeyPress);
            this.fArtTxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.FArtTxtNombre_Validating);
            // 
            // fArtLbl4
            // 
            this.fArtLbl4.AutoSize = true;
            this.fArtLbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fArtLbl4.Location = new System.Drawing.Point(109, 132);
            this.fArtLbl4.Name = "fArtLbl4";
            this.fArtLbl4.Size = new System.Drawing.Size(23, 20);
            this.fArtLbl4.TabIndex = 50;
            this.fArtLbl4.Text = "%";
            // 
            // fArtLbl3
            // 
            this.fArtLbl3.AutoSize = true;
            this.fArtLbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fArtLbl3.Location = new System.Drawing.Point(79, 92);
            this.fArtLbl3.Name = "fArtLbl3";
            this.fArtLbl3.Size = new System.Drawing.Size(53, 20);
            this.fArtLbl3.TabIndex = 49;
            this.fArtLbl3.Text = "Precio";
            // 
            // fArtLbl1
            // 
            this.fArtLbl1.AutoSize = true;
            this.fArtLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fArtLbl1.Location = new System.Drawing.Point(69, 52);
            this.fArtLbl1.Name = "fArtLbl1";
            this.fArtLbl1.Size = new System.Drawing.Size(65, 20);
            this.fArtLbl1.TabIndex = 48;
            this.fArtLbl1.Text = "Nombre";
            // 
            // fArtBtnCancelar
            // 
            this.fArtBtnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.fArtBtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fArtBtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fArtBtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fArtBtnCancelar.ForeColor = System.Drawing.Color.White;
            this.fArtBtnCancelar.Location = new System.Drawing.Point(340, 188);
            this.fArtBtnCancelar.Name = "fArtBtnCancelar";
            this.fArtBtnCancelar.Size = new System.Drawing.Size(101, 29);
            this.fArtBtnCancelar.TabIndex = 57;
            this.fArtBtnCancelar.Text = "Cancelar";
            this.fArtBtnCancelar.UseVisualStyleBackColor = false;
            this.fArtBtnCancelar.Click += new System.EventHandler(this.FArtBtnCancelar_Click);
            // 
            // fArtBtnAceptar
            // 
            this.fArtBtnAceptar.BackColor = System.Drawing.Color.DarkGreen;
            this.fArtBtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fArtBtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fArtBtnAceptar.ForeColor = System.Drawing.Color.White;
            this.fArtBtnAceptar.Location = new System.Drawing.Point(172, 188);
            this.fArtBtnAceptar.Name = "fArtBtnAceptar";
            this.fArtBtnAceptar.Size = new System.Drawing.Size(101, 29);
            this.fArtBtnAceptar.TabIndex = 56;
            this.fArtBtnAceptar.Text = "Aceptar";
            this.fArtBtnAceptar.UseVisualStyleBackColor = false;
            this.fArtBtnAceptar.Click += new System.EventHandler(this.FArtBtnAceptar_Click);
            // 
            // fArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fArtBtnCancelar;
            this.ClientSize = new System.Drawing.Size(612, 246);
            this.ControlBox = false;
            this.Controls.Add(this.fArtLblTitulo);
            this.Controls.Add(this.fArtTxtPorcentaje);
            this.Controls.Add(this.fArtTxtPrecio);
            this.Controls.Add(this.fArtTxtNombre);
            this.Controls.Add(this.fArtLbl4);
            this.Controls.Add(this.fArtLbl3);
            this.Controls.Add(this.fArtLbl1);
            this.Controls.Add(this.fArtBtnCancelar);
            this.Controls.Add(this.fArtBtnAceptar);
            this.Name = "fArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fArtLblTitulo;
        private System.Windows.Forms.TextBox fArtTxtPorcentaje;
        private System.Windows.Forms.TextBox fArtTxtPrecio;
        private System.Windows.Forms.TextBox fArtTxtNombre;
        private System.Windows.Forms.Label fArtLbl4;
        private System.Windows.Forms.Label fArtLbl3;
        private System.Windows.Forms.Label fArtLbl1;
        private System.Windows.Forms.Button fArtBtnCancelar;
        private System.Windows.Forms.Button fArtBtnAceptar;
    }
}