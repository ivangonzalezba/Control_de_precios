namespace Sistem_de_inventario
{
    partial class fEntradaSimple
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
            this.fEntradaBtnAceptar = new System.Windows.Forms.Button();
            this.fEntradaBtnCancelar = new System.Windows.Forms.Button();
            this.fPorcentajeTxtbox = new System.Windows.Forms.TextBox();
            this.fEntradalbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fEntradaBtnAceptar
            // 
            this.fEntradaBtnAceptar.BackColor = System.Drawing.Color.DarkGreen;
            this.fEntradaBtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fEntradaBtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fEntradaBtnAceptar.ForeColor = System.Drawing.Color.White;
            this.fEntradaBtnAceptar.Location = new System.Drawing.Point(107, 148);
            this.fEntradaBtnAceptar.Name = "fEntradaBtnAceptar";
            this.fEntradaBtnAceptar.Size = new System.Drawing.Size(101, 29);
            this.fEntradaBtnAceptar.TabIndex = 35;
            this.fEntradaBtnAceptar.Text = "Aceptar";
            this.fEntradaBtnAceptar.UseVisualStyleBackColor = false;
            this.fEntradaBtnAceptar.Click += new System.EventHandler(this.fEntradaBtnAceptar_Click);
            // 
            // fEntradaBtnCancelar
            // 
            this.fEntradaBtnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.fEntradaBtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fEntradaBtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fEntradaBtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fEntradaBtnCancelar.ForeColor = System.Drawing.Color.White;
            this.fEntradaBtnCancelar.Location = new System.Drawing.Point(274, 148);
            this.fEntradaBtnCancelar.Name = "fEntradaBtnCancelar";
            this.fEntradaBtnCancelar.Size = new System.Drawing.Size(101, 29);
            this.fEntradaBtnCancelar.TabIndex = 36;
            this.fEntradaBtnCancelar.Text = "Cancelar";
            this.fEntradaBtnCancelar.UseVisualStyleBackColor = false;
            this.fEntradaBtnCancelar.Click += new System.EventHandler(this.fEntradaBtnCancelar_Click);
            // 
            // fPorcentajeTxtbox
            // 
            this.fPorcentajeTxtbox.Location = new System.Drawing.Point(46, 73);
            this.fPorcentajeTxtbox.Name = "fPorcentajeTxtbox";
            this.fPorcentajeTxtbox.Size = new System.Drawing.Size(150, 20);
            this.fPorcentajeTxtbox.TabIndex = 37;
            this.fPorcentajeTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fPorcentajeTxtbox_KeyPress);
            this.fPorcentajeTxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // fEntradalbl
            // 
            this.fEntradalbl.AutoSize = true;
            this.fEntradalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fEntradalbl.Location = new System.Drawing.Point(42, 37);
            this.fEntradalbl.Name = "fEntradalbl";
            this.fEntradalbl.Size = new System.Drawing.Size(166, 20);
            this.fEntradalbl.TabIndex = 38;
            this.fEntradalbl.Text = "Ingrese el porcentaje. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ej. \"10\" para sumar, \"-10\" para restar.";
            // 
            // fEntradaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fEntradaBtnCancelar;
            this.ClientSize = new System.Drawing.Size(516, 214);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fEntradalbl);
            this.Controls.Add(this.fPorcentajeTxtbox);
            this.Controls.Add(this.fEntradaBtnCancelar);
            this.Controls.Add(this.fEntradaBtnAceptar);
            this.Name = "fEntradaSimple";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Porcentaje de ganancia";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fEntradaBtnAceptar;
        private System.Windows.Forms.Button fEntradaBtnCancelar;
        private System.Windows.Forms.TextBox fPorcentajeTxtbox;
        private System.Windows.Forms.Label fEntradalbl;
        private System.Windows.Forms.Label label1;
    }
}