namespace Sistem_de_inventario
{
    partial class FPoliester
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
            this.fPolLblTitulo = new System.Windows.Forms.Label();
            this.fPolTxtPorcentaje = new System.Windows.Forms.TextBox();
            this.fPolTxtPrecio = new System.Windows.Forms.TextBox();
            this.fPolTxtNombre = new System.Windows.Forms.TextBox();
            this.fPolLblPrecio = new System.Windows.Forms.Label();
            this.fPolLbl4 = new System.Windows.Forms.Label();
            this.fPolLbl3 = new System.Windows.Forms.Label();
            this.fPolLbl1 = new System.Windows.Forms.Label();
            this.fPolBtnCancelar = new System.Windows.Forms.Button();
            this.fPolBtnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fPolLblTitulo
            // 
            this.fPolLblTitulo.AutoSize = true;
            this.fPolLblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPolLblTitulo.Location = new System.Drawing.Point(274, 9);
            this.fPolLblTitulo.Name = "fPolLblTitulo";
            this.fPolLblTitulo.Size = new System.Drawing.Size(70, 20);
            this.fPolLblTitulo.TabIndex = 40;
            this.fPolLblTitulo.Text = "Poliester";
            // 
            // fPolTxtPorcentaje
            // 
            this.fPolTxtPorcentaje.Location = new System.Drawing.Point(156, 132);
            this.fPolTxtPorcentaje.Name = "fPolTxtPorcentaje";
            this.fPolTxtPorcentaje.Size = new System.Drawing.Size(342, 20);
            this.fPolTxtPorcentaje.TabIndex = 45;
            this.fPolTxtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FPolTxtPorcentaje_KeyPress);
            this.fPolTxtPorcentaje.Validating += new System.ComponentModel.CancelEventHandler(this.FPolTxtPorcentaje_Validating);
            // 
            // fPolTxtPrecio
            // 
            this.fPolTxtPrecio.Location = new System.Drawing.Point(156, 92);
            this.fPolTxtPrecio.Name = "fPolTxtPrecio";
            this.fPolTxtPrecio.Size = new System.Drawing.Size(342, 20);
            this.fPolTxtPrecio.TabIndex = 44;
            this.fPolTxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FPolTxtPrecio_KeyPress);
            this.fPolTxtPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.FPolTxtPrecio_Validating);
            // 
            // fPolTxtNombre
            // 
            this.fPolTxtNombre.Location = new System.Drawing.Point(156, 52);
            this.fPolTxtNombre.Name = "fPolTxtNombre";
            this.fPolTxtNombre.Size = new System.Drawing.Size(342, 20);
            this.fPolTxtNombre.TabIndex = 42;
            this.fPolTxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FPolTxtNombre_KeyPress);
            this.fPolTxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.FPolTxtNombre_Validating);
            // 
            // fPolLblPrecio
            // 
            this.fPolLblPrecio.AutoSize = true;
            this.fPolLblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPolLblPrecio.Location = new System.Drawing.Point(522, 92);
            this.fPolLblPrecio.Name = "fPolLblPrecio";
            this.fPolLblPrecio.Size = new System.Drawing.Size(21, 20);
            this.fPolLblPrecio.TabIndex = 41;
            this.fPolLblPrecio.Text = "...";
            // 
            // fPolLbl4
            // 
            this.fPolLbl4.AutoSize = true;
            this.fPolLbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPolLbl4.Location = new System.Drawing.Point(109, 132);
            this.fPolLbl4.Name = "fPolLbl4";
            this.fPolLbl4.Size = new System.Drawing.Size(23, 20);
            this.fPolLbl4.TabIndex = 39;
            this.fPolLbl4.Text = "%";
            // 
            // fPolLbl3
            // 
            this.fPolLbl3.AutoSize = true;
            this.fPolLbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPolLbl3.Location = new System.Drawing.Point(79, 92);
            this.fPolLbl3.Name = "fPolLbl3";
            this.fPolLbl3.Size = new System.Drawing.Size(53, 20);
            this.fPolLbl3.TabIndex = 38;
            this.fPolLbl3.Text = "Precio";
            // 
            // fPolLbl1
            // 
            this.fPolLbl1.AutoSize = true;
            this.fPolLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPolLbl1.Location = new System.Drawing.Point(69, 52);
            this.fPolLbl1.Name = "fPolLbl1";
            this.fPolLbl1.Size = new System.Drawing.Size(65, 20);
            this.fPolLbl1.TabIndex = 36;
            this.fPolLbl1.Text = "Nombre";
            // 
            // fPolBtnCancelar
            // 
            this.fPolBtnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.fPolBtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fPolBtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fPolBtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPolBtnCancelar.ForeColor = System.Drawing.Color.White;
            this.fPolBtnCancelar.Location = new System.Drawing.Point(340, 188);
            this.fPolBtnCancelar.Name = "fPolBtnCancelar";
            this.fPolBtnCancelar.Size = new System.Drawing.Size(101, 29);
            this.fPolBtnCancelar.TabIndex = 47;
            this.fPolBtnCancelar.Text = "Cancelar";
            this.fPolBtnCancelar.UseVisualStyleBackColor = false;
            this.fPolBtnCancelar.Click += new System.EventHandler(this.FPolBtnCancelar_Click);
            // 
            // fPolBtnAceptar
            // 
            this.fPolBtnAceptar.BackColor = System.Drawing.Color.DarkGreen;
            this.fPolBtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fPolBtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPolBtnAceptar.ForeColor = System.Drawing.Color.White;
            this.fPolBtnAceptar.Location = new System.Drawing.Point(172, 188);
            this.fPolBtnAceptar.Name = "fPolBtnAceptar";
            this.fPolBtnAceptar.Size = new System.Drawing.Size(101, 29);
            this.fPolBtnAceptar.TabIndex = 46;
            this.fPolBtnAceptar.Text = "Aceptar";
            this.fPolBtnAceptar.UseVisualStyleBackColor = false;
            this.fPolBtnAceptar.Click += new System.EventHandler(this.FPolBtnAceptar_Click);
            // 
            // fPoliester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fPolBtnCancelar;
            this.ClientSize = new System.Drawing.Size(612, 246);
            this.ControlBox = false;
            this.Controls.Add(this.fPolLblTitulo);
            this.Controls.Add(this.fPolTxtPorcentaje);
            this.Controls.Add(this.fPolTxtPrecio);
            this.Controls.Add(this.fPolTxtNombre);
            this.Controls.Add(this.fPolLblPrecio);
            this.Controls.Add(this.fPolLbl4);
            this.Controls.Add(this.fPolLbl3);
            this.Controls.Add(this.fPolLbl1);
            this.Controls.Add(this.fPolBtnCancelar);
            this.Controls.Add(this.fPolBtnAceptar);
            this.Name = "fPoliester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fPolLblTitulo;
        private System.Windows.Forms.TextBox fPolTxtPorcentaje;
        private System.Windows.Forms.TextBox fPolTxtPrecio;
        private System.Windows.Forms.TextBox fPolTxtNombre;
        private System.Windows.Forms.Label fPolLblPrecio;
        private System.Windows.Forms.Label fPolLbl4;
        private System.Windows.Forms.Label fPolLbl3;
        private System.Windows.Forms.Label fPolLbl1;
        private System.Windows.Forms.Button fPolBtnCancelar;
        private System.Windows.Forms.Button fPolBtnAceptar;
    }
}