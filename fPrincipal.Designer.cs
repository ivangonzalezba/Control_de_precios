namespace Sistem_de_inventario
{
    partial class FPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
            this.cPestañas = new System.Windows.Forms.TabControl();
            this.pPoliester = new System.Windows.Forms.TabPage();
            this.listViewPoliester = new System.Windows.Forms.ListView();
            this.colPoliesterID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPoliesterNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPoliesterPrecioDolar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPoliesterPorcentaje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPoliesterPrecioM2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pCuerinas = new System.Windows.Forms.TabPage();
            this.listViewCuerinas = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAncho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecioDolar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPorcentaje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecioMLineal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pArticulos = new System.Windows.Forms.TabPage();
            this.listViewArticulos = new System.Windows.Forms.ListView();
            this.colArticulosID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArticulosDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArticulosPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArticulosPorcentaje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArticulosPrecioFinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDolarBlue = new System.Windows.Forms.TextBox();
            this.lblBlue = new System.Windows.Forms.Label();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.lblOficial = new System.Windows.Forms.Label();
            this.txtDolarOficial = new System.Windows.Forms.TextBox();
            this.lblSolidario = new System.Windows.Forms.Label();
            this.txtDolarImpuesto = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtDolarLocal = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblLargo = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.lblAnchoLargo = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTotalFondo = new System.Windows.Forms.Label();
            this.lblSimboloPesos = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.fPrincipalCheckBox1 = new System.Windows.Forms.CheckBox();
            this.fPrincipalCheckBox2 = new System.Windows.Forms.CheckBox();
            this.fPrincipalCheckBox3 = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblSimboloPesos2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cPestañas.SuspendLayout();
            this.pPoliester.SuspendLayout();
            this.pCuerinas.SuspendLayout();
            this.pArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // cPestañas
            // 
            this.cPestañas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cPestañas.Controls.Add(this.pPoliester);
            this.cPestañas.Controls.Add(this.pCuerinas);
            this.cPestañas.Controls.Add(this.pArticulos);
            this.cPestañas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPestañas.Location = new System.Drawing.Point(0, 103);
            this.cPestañas.Name = "cPestañas";
            this.cPestañas.SelectedIndex = 0;
            this.cPestañas.Size = new System.Drawing.Size(805, 428);
            this.cPestañas.TabIndex = 0;
            this.cPestañas.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.CPestañas_Selecting);
            // 
            // pPoliester
            // 
            this.pPoliester.Controls.Add(this.listViewPoliester);
            this.pPoliester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPoliester.Location = new System.Drawing.Point(4, 29);
            this.pPoliester.Name = "pPoliester";
            this.pPoliester.Padding = new System.Windows.Forms.Padding(3);
            this.pPoliester.Size = new System.Drawing.Size(797, 395);
            this.pPoliester.TabIndex = 0;
            this.pPoliester.Text = "Poliester";
            this.pPoliester.UseVisualStyleBackColor = true;
            // 
            // listViewPoliester
            // 
            this.listViewPoliester.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPoliesterID,
            this.colPoliesterNombre,
            this.colPoliesterPrecioDolar,
            this.colPoliesterPorcentaje,
            this.colPoliesterPrecioM2});
            this.listViewPoliester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPoliester.FullRowSelect = true;
            this.listViewPoliester.HideSelection = false;
            this.listViewPoliester.Location = new System.Drawing.Point(3, 3);
            this.listViewPoliester.Name = "listViewPoliester";
            this.listViewPoliester.Size = new System.Drawing.Size(791, 389);
            this.listViewPoliester.TabIndex = 0;
            this.listViewPoliester.UseCompatibleStateImageBehavior = false;
            this.listViewPoliester.View = System.Windows.Forms.View.Details;
            // 
            // colPoliesterID
            // 
            this.colPoliesterID.Text = "ID";
            this.colPoliesterID.Width = 30;
            // 
            // colPoliesterNombre
            // 
            this.colPoliesterNombre.Text = "Descripción";
            this.colPoliesterNombre.Width = 510;
            // 
            // colPoliesterPrecioDolar
            // 
            this.colPoliesterPrecioDolar.Text = "Dolar";
            // 
            // colPoliesterPorcentaje
            // 
            this.colPoliesterPorcentaje.Text = "%";
            this.colPoliesterPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPoliesterPorcentaje.Width = 40;
            // 
            // colPoliesterPrecioM2
            // 
            this.colPoliesterPrecioM2.Text = "M2 en pesos";
            this.colPoliesterPrecioM2.Width = 120;
            // 
            // pCuerinas
            // 
            this.pCuerinas.Controls.Add(this.listViewCuerinas);
            this.pCuerinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCuerinas.Location = new System.Drawing.Point(4, 29);
            this.pCuerinas.Name = "pCuerinas";
            this.pCuerinas.Padding = new System.Windows.Forms.Padding(3);
            this.pCuerinas.Size = new System.Drawing.Size(797, 395);
            this.pCuerinas.TabIndex = 1;
            this.pCuerinas.Text = "Cuerinas";
            this.pCuerinas.UseVisualStyleBackColor = true;
            // 
            // listViewCuerinas
            // 
            this.listViewCuerinas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colNombre,
            this.colAncho,
            this.colPrecioDolar,
            this.colPorcentaje,
            this.colPrecioMLineal});
            this.listViewCuerinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCuerinas.FullRowSelect = true;
            this.listViewCuerinas.HideSelection = false;
            this.listViewCuerinas.Location = new System.Drawing.Point(3, 3);
            this.listViewCuerinas.MultiSelect = false;
            this.listViewCuerinas.Name = "listViewCuerinas";
            this.listViewCuerinas.Size = new System.Drawing.Size(791, 389);
            this.listViewCuerinas.TabIndex = 0;
            this.listViewCuerinas.UseCompatibleStateImageBehavior = false;
            this.listViewCuerinas.View = System.Windows.Forms.View.Details;
            this.listViewCuerinas.SelectedIndexChanged += new System.EventHandler(this.ListViewCuerinas_SelectedIndexChanged);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 30;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Descripción";
            this.colNombre.Width = 450;
            // 
            // colAncho
            // 
            this.colAncho.Text = "Ancho";
            // 
            // colPrecioDolar
            // 
            this.colPrecioDolar.Text = "Dolar";
            // 
            // colPorcentaje
            // 
            this.colPorcentaje.Text = "%";
            this.colPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPorcentaje.Width = 40;
            // 
            // colPrecioMLineal
            // 
            this.colPrecioMLineal.Text = "MLin. en pesos";
            this.colPrecioMLineal.Width = 120;
            // 
            // pArticulos
            // 
            this.pArticulos.Controls.Add(this.listViewArticulos);
            this.pArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pArticulos.Location = new System.Drawing.Point(4, 29);
            this.pArticulos.Name = "pArticulos";
            this.pArticulos.Size = new System.Drawing.Size(797, 395);
            this.pArticulos.TabIndex = 2;
            this.pArticulos.Text = "Artículos";
            this.pArticulos.UseVisualStyleBackColor = true;
            // 
            // listViewArticulos
            // 
            this.listViewArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewArticulos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colArticulosID,
            this.colArticulosDescripcion,
            this.colArticulosPrecio,
            this.colArticulosPorcentaje,
            this.colArticulosPrecioFinal});
            this.listViewArticulos.FullRowSelect = true;
            this.listViewArticulos.HideSelection = false;
            this.listViewArticulos.Location = new System.Drawing.Point(3, 3);
            this.listViewArticulos.Name = "listViewArticulos";
            this.listViewArticulos.Size = new System.Drawing.Size(791, 419);
            this.listViewArticulos.TabIndex = 0;
            this.listViewArticulos.UseCompatibleStateImageBehavior = false;
            this.listViewArticulos.View = System.Windows.Forms.View.Details;
            // 
            // colArticulosID
            // 
            this.colArticulosID.Text = "ID";
            this.colArticulosID.Width = 30;
            // 
            // colArticulosDescripcion
            // 
            this.colArticulosDescripcion.Text = "Descripción";
            this.colArticulosDescripcion.Width = 470;
            // 
            // colArticulosPrecio
            // 
            this.colArticulosPrecio.Text = "Pesos";
            this.colArticulosPrecio.Width = 100;
            // 
            // colArticulosPorcentaje
            // 
            this.colArticulosPorcentaje.Text = "%";
            this.colArticulosPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colArticulosPorcentaje.Width = 40;
            // 
            // colArticulosPrecioFinal
            // 
            this.colArticulosPrecioFinal.Text = "Final en pesos";
            this.colArticulosPrecioFinal.Width = 120;
            // 
            // txtDolarBlue
            // 
            this.txtDolarBlue.BackColor = System.Drawing.Color.DarkGreen;
            this.txtDolarBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarBlue.ForeColor = System.Drawing.Color.White;
            this.txtDolarBlue.Location = new System.Drawing.Point(649, 6);
            this.txtDolarBlue.Name = "txtDolarBlue";
            this.txtDolarBlue.ReadOnly = true;
            this.txtDolarBlue.Size = new System.Drawing.Size(63, 26);
            this.txtDolarBlue.TabIndex = 1;
            this.txtDolarBlue.TabStop = false;
            this.txtDolarBlue.Text = "103";
            this.txtDolarBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.BackColor = System.Drawing.Color.DarkGreen;
            this.lblBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.ForeColor = System.Drawing.Color.White;
            this.lblBlue.Location = new System.Drawing.Point(525, 9);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(125, 20);
            this.lblBlue.TabIndex = 2;
            this.lblBlue.Text = "DÓLAR BLUE $";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBoxTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(1008, 38);
            this.pictureBoxTitulo.TabIndex = 3;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // lblOficial
            // 
            this.lblOficial.AutoSize = true;
            this.lblOficial.BackColor = System.Drawing.Color.DarkGreen;
            this.lblOficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOficial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOficial.ForeColor = System.Drawing.Color.White;
            this.lblOficial.Location = new System.Drawing.Point(3, 9);
            this.lblOficial.Name = "lblOficial";
            this.lblOficial.Size = new System.Drawing.Size(145, 20);
            this.lblOficial.TabIndex = 5;
            this.lblOficial.Text = "DÓLAR OFICIAL $";
            this.lblOficial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDolarOficial
            // 
            this.txtDolarOficial.BackColor = System.Drawing.Color.DarkGreen;
            this.txtDolarOficial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarOficial.ForeColor = System.Drawing.Color.White;
            this.txtDolarOficial.Location = new System.Drawing.Point(147, 6);
            this.txtDolarOficial.Name = "txtDolarOficial";
            this.txtDolarOficial.ReadOnly = true;
            this.txtDolarOficial.Size = new System.Drawing.Size(63, 26);
            this.txtDolarOficial.TabIndex = 5;
            this.txtDolarOficial.TabStop = false;
            this.txtDolarOficial.Text = "68";
            this.txtDolarOficial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSolidario
            // 
            this.lblSolidario.AutoSize = true;
            this.lblSolidario.BackColor = System.Drawing.Color.DarkGreen;
            this.lblSolidario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSolidario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolidario.ForeColor = System.Drawing.Color.White;
            this.lblSolidario.Location = new System.Drawing.Point(257, 9);
            this.lblSolidario.Name = "lblSolidario";
            this.lblSolidario.Size = new System.Drawing.Size(165, 20);
            this.lblSolidario.TabIndex = 14;
            this.lblSolidario.Text = "DÓLAR IMPUESTO $";
            this.lblSolidario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDolarImpuesto
            // 
            this.txtDolarImpuesto.BackColor = System.Drawing.Color.DarkGreen;
            this.txtDolarImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarImpuesto.ForeColor = System.Drawing.Color.White;
            this.txtDolarImpuesto.Location = new System.Drawing.Point(421, 6);
            this.txtDolarImpuesto.Name = "txtDolarImpuesto";
            this.txtDolarImpuesto.ReadOnly = true;
            this.txtDolarImpuesto.Size = new System.Drawing.Size(63, 26);
            this.txtDolarImpuesto.TabIndex = 13;
            this.txtDolarImpuesto.TabStop = false;
            this.txtDolarImpuesto.Text = "88";
            this.txtDolarImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.BackColor = System.Drawing.Color.DarkGreen;
            this.lblLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.White;
            this.lblLocal.Location = new System.Drawing.Point(753, 9);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(134, 20);
            this.lblLocal.TabIndex = 16;
            this.lblLocal.Text = "DÓLAR LOCAL $";
            this.lblLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDolarLocal
            // 
            this.txtDolarLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarLocal.Location = new System.Drawing.Point(887, 6);
            this.txtDolarLocal.Name = "txtDolarLocal";
            this.txtDolarLocal.Size = new System.Drawing.Size(63, 26);
            this.txtDolarLocal.TabIndex = 1;
            this.txtDolarLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDolarLocal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDolarLocal_KeyPress);
            this.txtDolarLocal.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDolarLocal_Validating);
            this.txtDolarLocal.Validated += new System.EventHandler(this.TxtDolarLocal_Validated);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(408, 41);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(193, 56);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(811, 41);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(193, 56);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(206, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(193, 56);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(4, 41);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(193, 56);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo artículo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.DarkGreen;
            this.lblX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.White;
            this.lblX.Location = new System.Drawing.Point(698, 68);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(16, 20);
            this.lblX.TabIndex = 21;
            this.lblX.Text = "x";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.BackColor = System.Drawing.Color.DarkGreen;
            this.lblLargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargo.ForeColor = System.Drawing.Color.White;
            this.lblLargo.Location = new System.Drawing.Point(723, 44);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(73, 20);
            this.lblLargo.TabIndex = 20;
            this.lblLargo.Text = "Largo / C";
            this.lblLargo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.BackColor = System.Drawing.Color.DarkGreen;
            this.lblAncho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAncho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncho.ForeColor = System.Drawing.Color.White;
            this.lblAncho.Location = new System.Drawing.Point(626, 44);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(55, 20);
            this.lblAncho.TabIndex = 19;
            this.lblAncho.Text = "Ancho";
            this.lblAncho.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(722, 67);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(75, 20);
            this.txtLargo.TabIndex = 7;
            this.txtLargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLargo_KeyPress);
            this.txtLargo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLargo_Validating);
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(615, 67);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(75, 20);
            this.txtAncho.TabIndex = 6;
            this.txtAncho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAncho_KeyPress);
            this.txtAncho.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAncho_Validating);
            // 
            // lblAnchoLargo
            // 
            this.lblAnchoLargo.BackColor = System.Drawing.Color.DarkGreen;
            this.lblAnchoLargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnchoLargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAnchoLargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnchoLargo.ForeColor = System.Drawing.Color.White;
            this.lblAnchoLargo.Location = new System.Drawing.Point(610, 41);
            this.lblAnchoLargo.Name = "lblAnchoLargo";
            this.lblAnchoLargo.Size = new System.Drawing.Size(193, 56);
            this.lblAnchoLargo.TabIndex = 24;
            this.lblAnchoLargo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(857, 163);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 26);
            this.txtSubTotal.TabIndex = 27;
            this.txtSubTotal.TabStop = false;
            this.txtSubTotal.TextChanged += new System.EventHandler(this.TxtSubTotal_TextChanged);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.DarkGreen;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.White;
            this.lblSubTotal.Location = new System.Drawing.Point(873, 140);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(69, 20);
            this.lblSubTotal.TabIndex = 28;
            this.lblSubTotal.Text = "Subtotal";
            // 
            // lblTotalFondo
            // 
            this.lblTotalFondo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFondo.BackColor = System.Drawing.Color.DarkGreen;
            this.lblTotalFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalFondo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFondo.ForeColor = System.Drawing.Color.White;
            this.lblTotalFondo.Location = new System.Drawing.Point(811, 134);
            this.lblTotalFondo.Name = "lblTotalFondo";
            this.lblTotalFondo.Size = new System.Drawing.Size(193, 390);
            this.lblTotalFondo.TabIndex = 29;
            this.lblTotalFondo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSimboloPesos
            // 
            this.lblSimboloPesos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimboloPesos.AutoSize = true;
            this.lblSimboloPesos.BackColor = System.Drawing.Color.DarkGreen;
            this.lblSimboloPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimboloPesos.ForeColor = System.Drawing.Color.White;
            this.lblSimboloPesos.Location = new System.Drawing.Point(833, 166);
            this.lblSimboloPesos.Name = "lblSimboloPesos";
            this.lblSimboloPesos.Size = new System.Drawing.Size(18, 20);
            this.lblSimboloPesos.TabIndex = 30;
            this.lblSimboloPesos.Text = "$";
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColor.BackgroundImage")));
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColor.Location = new System.Drawing.Point(969, 6);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(33, 26);
            this.btnColor.TabIndex = 2;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // fPrincipalCheckBox1
            // 
            this.fPrincipalCheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fPrincipalCheckBox1.BackColor = System.Drawing.SystemColors.Control;
            this.fPrincipalCheckBox1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fPrincipalCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPrincipalCheckBox1.Location = new System.Drawing.Point(837, 195);
            this.fPrincipalCheckBox1.Name = "fPrincipalCheckBox1";
            this.fPrincipalCheckBox1.Size = new System.Drawing.Size(120, 24);
            this.fPrincipalCheckBox1.TabIndex = 9;
            this.fPrincipalCheckBox1.Text = "...";
            this.fPrincipalCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fPrincipalCheckBox1.UseVisualStyleBackColor = false;
            this.fPrincipalCheckBox1.CheckedChanged += new System.EventHandler(this.FPincipalCheckBox1_CheckedChanged);
            this.fPrincipalCheckBox1.Validated += new System.EventHandler(this.FPrincipalCheckBox1_Validated);
            // 
            // fPrincipalCheckBox2
            // 
            this.fPrincipalCheckBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fPrincipalCheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPrincipalCheckBox2.Location = new System.Drawing.Point(837, 225);
            this.fPrincipalCheckBox2.Name = "fPrincipalCheckBox2";
            this.fPrincipalCheckBox2.Size = new System.Drawing.Size(120, 24);
            this.fPrincipalCheckBox2.TabIndex = 10;
            this.fPrincipalCheckBox2.Text = "...";
            this.fPrincipalCheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fPrincipalCheckBox2.UseVisualStyleBackColor = true;
            this.fPrincipalCheckBox2.CheckedChanged += new System.EventHandler(this.FPincipalCheckBox2_CheckedChanged);
            this.fPrincipalCheckBox2.Validated += new System.EventHandler(this.FPrincipalCheckBox2_Validated);
            // 
            // fPrincipalCheckBox3
            // 
            this.fPrincipalCheckBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fPrincipalCheckBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPrincipalCheckBox3.Location = new System.Drawing.Point(837, 255);
            this.fPrincipalCheckBox3.Name = "fPrincipalCheckBox3";
            this.fPrincipalCheckBox3.Size = new System.Drawing.Size(120, 24);
            this.fPrincipalCheckBox3.TabIndex = 11;
            this.fPrincipalCheckBox3.Text = "...";
            this.fPrincipalCheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fPrincipalCheckBox3.UseVisualStyleBackColor = true;
            this.fPrincipalCheckBox3.CheckedChanged += new System.EventHandler(this.FPincipalCheckBox3_CheckedChanged);
            this.fPrincipalCheckBox3.Validated += new System.EventHandler(this.FPrincipalCheckBox3_Validated);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(857, 315);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 35;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextChanged += new System.EventHandler(this.TxtTotal_TextChanged);
            // 
            // lblSimboloPesos2
            // 
            this.lblSimboloPesos2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimboloPesos2.AutoSize = true;
            this.lblSimboloPesos2.BackColor = System.Drawing.Color.DarkGreen;
            this.lblSimboloPesos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimboloPesos2.ForeColor = System.Drawing.Color.White;
            this.lblSimboloPesos2.Location = new System.Drawing.Point(833, 318);
            this.lblSimboloPesos2.Name = "lblSimboloPesos2";
            this.lblSimboloPesos2.Size = new System.Drawing.Size(18, 20);
            this.lblSimboloPesos2.TabIndex = 36;
            this.lblSimboloPesos2.Text = "$";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.DarkGreen;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(878, 292);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 20);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "TOTAL";
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 531);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSimboloPesos2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.fPrincipalCheckBox3);
            this.Controls.Add(this.fPrincipalCheckBox2);
            this.Controls.Add(this.fPrincipalCheckBox1);
            this.Controls.Add(this.txtDolarOficial);
            this.Controls.Add(this.txtDolarImpuesto);
            this.Controls.Add(this.txtDolarBlue);
            this.Controls.Add(this.txtDolarLocal);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblSimboloPesos);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblLargo);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.lblAnchoLargo);
            this.Controls.Add(this.lblOficial);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblSolidario);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.cPestañas);
            this.Controls.Add(this.pictureBoxTitulo);
            this.Controls.Add(this.lblTotalFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 400);
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de precios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FPrincipal_Activated);
            this.Resize += new System.EventHandler(this.FPrincipal_Resize);
            this.cPestañas.ResumeLayout(false);
            this.pPoliester.ResumeLayout(false);
            this.pCuerinas.ResumeLayout(false);
            this.pArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl cPestañas;
        private System.Windows.Forms.TabPage pPoliester;
        private System.Windows.Forms.TabPage pCuerinas;
        private System.Windows.Forms.TabPage pArticulos;
        private System.Windows.Forms.TextBox txtDolarBlue;
        public System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        public System.Windows.Forms.Label lblOficial;
        private System.Windows.Forms.TextBox txtDolarOficial;
        public System.Windows.Forms.Label lblSolidario;
        private System.Windows.Forms.TextBox txtDolarImpuesto;
        public System.Windows.Forms.Label lblLocal;
        public System.Windows.Forms.TextBox txtDolarLocal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Label lblX;
        public System.Windows.Forms.Label lblLargo;
        public System.Windows.Forms.Label lblAncho;
        public System.Windows.Forms.TextBox txtLargo;
        public System.Windows.Forms.TextBox txtAncho;
        public System.Windows.Forms.Label lblAnchoLargo;
        public System.Windows.Forms.ListView listViewCuerinas;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colAncho;
        private System.Windows.Forms.ColumnHeader colPrecioDolar;
        private System.Windows.Forms.ColumnHeader colPorcentaje;
        private System.Windows.Forms.ColumnHeader colPrecioMLineal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        public System.Windows.Forms.Label lblTotalFondo;
        public System.Windows.Forms.ListView listViewArticulos;
        private System.Windows.Forms.Label lblSimboloPesos;
        public System.Windows.Forms.ListView listViewPoliester;
        private System.Windows.Forms.ColumnHeader colPoliesterID;
        private System.Windows.Forms.ColumnHeader colPoliesterNombre;
        private System.Windows.Forms.ColumnHeader colPoliesterPrecioDolar;
        private System.Windows.Forms.ColumnHeader colPoliesterPorcentaje;
        private System.Windows.Forms.ColumnHeader colPoliesterPrecioM2;
        private System.Windows.Forms.ColumnHeader colArticulosID;
        private System.Windows.Forms.ColumnHeader colArticulosDescripcion;
        private System.Windows.Forms.ColumnHeader colArticulosPrecio;
        private System.Windows.Forms.ColumnHeader colArticulosPorcentaje;
        private System.Windows.Forms.ColumnHeader colArticulosPrecioFinal;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.CheckBox fPrincipalCheckBox1;
        private System.Windows.Forms.CheckBox fPrincipalCheckBox2;
        private System.Windows.Forms.CheckBox fPrincipalCheckBox3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblSimboloPesos2;
        private System.Windows.Forms.Label lblTotal;
    }
}

