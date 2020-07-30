using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_de_inventario
{
    public partial class FPrincipal : Form
    {
        public fCargando _fCargando;
        private Administrador _Administrador;
        private Validaciones _Validaciones;
        private WebBrowser Navegador;
        public static ListViewItem ItemSeleccionado;
        public static int PestañaActual;
        public static decimal Dolar;
        public static bool ModoEditar;
        private decimal Total;
        private decimal AnchoPlanchaPoliester;
        private string PoliesterASCoDESC;
        private string CuerinasASCoDESC;
        private string ArticulosASCoDESC;
        private string PoliesterOrdenarPorCol;
        private string CuerinasOrdenarPorCol;
        private string ArticulosOrdenarPorCol;
        public FPrincipal()
        {
            InitializeComponent();
            Init();                 //INICIALIZACIóN DE INSTANCIAS Y VARIABLES
            FormularioDeCarga();    //ESTA FUNCION SIMULA UNA PANTALLA DE LOADING
        }
        #region FUNCIONES
        //////////////////////////////////
        //////  FUNCIONES DE INICIO  /////
        async void FormularioDeCarga()
        {
            _fCargando.Show();
            Task tarea = new Task(TiempoDeCarga);
            tarea.Start();
            await tarea;
            _fCargando.Close();
        }
        void TiempoDeCarga()
        { Thread.Sleep(5000); }
        void Init()
        {
            _fCargando = new fCargando();
            _Administrador = new Administrador();
            _Validaciones = new Validaciones();
            PestañaActual = 1;
            ModoEditar = false;
            Total = 0;
            AnchoPlanchaPoliester = 1.9m;
            SetearColor(Properties.Settings.Default.Color);
            SetOrdenListView();
            SetDolarDefault();
            ListViewPoliesterRefresh();

            /////  Recursos WEB  /////
            Navegador = new WebBrowser { ScriptErrorsSuppressed = true };
            Navegador.Navigate("https://www.dolarhoy.com");
            Navegador.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(ObtenerDatosWebDolar);
        }
        void ObtenerDatosWebDolar(object sender, EventArgs e)
        {
            List<string> ListaDolar = new List<string>();
            foreach (HtmlElement elemento in Navegador.Document.All)
            {
                if (elemento.GetAttribute("classname").Contains("price"))
                {
                    ListaDolar.Add(elemento.InnerText.Replace("$", "").Trim());
                }
            }
            SetDolarWeb(ListaDolar);
        }
        ////////////////////////////////
        /////  FUNCIONES DE SETEO  /////
        void SetearColor(Color aux)
        {
            this.pictureBoxTitulo.BackColor = aux;
            this.lblOficial.BackColor = aux;
            this.txtDolarOficial.BackColor = aux;
            this.lblSolidario.BackColor = aux;
            this.txtDolarImpuesto.BackColor = aux;
            this.lblBlue.BackColor = aux;
            this.txtDolarBlue.BackColor = aux;
            this.lblLocal.BackColor = aux;
            this.btnNuevo.BackColor = aux;
            this.btnModificar.BackColor = aux;
            this.btnEliminar.BackColor = aux;
            this.lblAnchoLargo.BackColor = aux;
            this.lblAncho.BackColor = aux;
            this.lblLargo.BackColor = aux;
            this.lblX.BackColor = aux;
            this.btnCalcular.BackColor = aux;
            this.fPrincipalCheckBox1.BackColor = aux;
            this.fPrincipalCheckBox2.BackColor = aux;
            this.fPrincipalCheckBox3.BackColor = aux;
            this.lblTotalFondo.BackColor = aux;
            this.lblSubTotal.BackColor = aux;
            this.lblTotal.BackColor = aux;
            this.lblSimboloPesos.BackColor = aux;
            this.lblSimboloPesos2.BackColor = aux;
        }
        void SetOrdenListView()
        {
            PoliesterASCoDESC = Properties.Settings.Default.ArticulosASCoDESC;
            CuerinasASCoDESC = Properties.Settings.Default.CuerinasASCoDESC;
            ArticulosASCoDESC = Properties.Settings.Default.PoliesterASCoDESC;
            PoliesterOrdenarPorCol = Properties.Settings.Default.PoliesterOrderBy;
            CuerinasOrdenarPorCol = Properties.Settings.Default.CuerinasOrderBy;
            ArticulosOrdenarPorCol = Properties.Settings.Default.ArticulosOrderBy;
        }
        void SetDolarDefault() //Este seteo se realiza antes de intentar actualizar de internet
        {
            Dolar = Properties.Settings.Default.Dolar;
            this.txtDolarLocal.Text = Convert.ToString(Properties.Settings.Default.Dolar);
            this.txtDolarOficial.Text = Convert.ToString(Properties.Settings.Default.DolarOficial);
            this.txtDolarImpuesto.Text = Convert.ToString(Properties.Settings.Default.DolarImpuesto);
            this.txtDolarBlue.Text = Convert.ToString(Properties.Settings.Default.DolarBlue);
        }
        void SetDolarWeb(List<string> auxListaDolar)
        {
            try
            {
                this.txtDolarOficial.Text = auxListaDolar[1];
                this.txtDolarImpuesto.Text = auxListaDolar[8];
                this.txtDolarBlue.Text = auxListaDolar[3];
                Properties.Settings.Default.Dolar = Convert.ToDecimal(this.txtDolarLocal.Text);
                Properties.Settings.Default.DolarOficial = Convert.ToDecimal(this.txtDolarOficial.Text);
                Properties.Settings.Default.DolarImpuesto = Convert.ToDecimal(this.txtDolarImpuesto.Text);
                Properties.Settings.Default.DolarBlue = Convert.ToDecimal(this.txtDolarBlue.Text);
                Properties.Settings.Default.Save();
                Navegador.Dispose();
            }
            catch { MessageBox.Show("Error al actualizar valores del dólar, compruebe su conexión a internet y reinicie la aplicación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        void SetOnClosing()
        {
            Properties.Settings.Default.ArticulosASCoDESC = PoliesterASCoDESC;
            Properties.Settings.Default.CuerinasASCoDESC = CuerinasASCoDESC;
            Properties.Settings.Default.PoliesterASCoDESC = ArticulosASCoDESC;
            Properties.Settings.Default.PoliesterOrderBy = PoliesterOrdenarPorCol;
            Properties.Settings.Default.CuerinasOrderBy = CuerinasOrdenarPorCol;
            Properties.Settings.Default.ArticulosOrderBy = ArticulosOrdenarPorCol;
            Properties.Settings.Default.Save();
        }
        ///////////////////////////////////
        /////  FUNCIONES DE REFRESCO  /////
        void FPrincipalTxtClear()
        {
            this.txtAncho.Clear();
            this.txtLargo.Clear();
            this.txtSubTotal.Clear();
        }
        void ActualizarTamañoColumnas()
        {
            this.listViewPoliester.Columns[1].Width = this.Width - 564;
            this.listViewCuerinas.Columns[1].Width = this.Width - 604;
            this.listViewArticulos.Columns[1].Width = this.Width - 554;
        }
        void ListViewPoliesterRefresh()
        {
            this.listViewPoliester.Items.Clear();
            List<Poliester> listaPoliester = _Administrador.CargarListaPoliester(PoliesterOrdenarPorCol, PoliesterASCoDESC);
            listaPoliester.ForEach(poliester =>
            {
                ListViewItem item = new ListViewItem(Convert.ToString(poliester.ID));
                this.listViewPoliester.Items.Add(item);
                item.SubItems.Add(poliester.Nombre);
                item.SubItems.Add(Convert.ToString(poliester.Precio));
                item.SubItems.Add(Convert.ToString(poliester.PorcDeGanancia));
                item.SubItems.Add(Convert.ToString(Math.Round(((poliester.Precio / AnchoPlanchaPoliester + (((poliester.Precio / AnchoPlanchaPoliester) * poliester.PorcDeGanancia) / 100)) * Dolar), 2)));
            });
        }
        void ListViewCuerinasRefresh()
        {
            this.listViewCuerinas.Items.Clear();
            List<Cuerinas> listaCuerinas = _Administrador.CargarListaCuerinas(CuerinasOrdenarPorCol, CuerinasASCoDESC);
            listaCuerinas.ForEach(cuerina =>
            {
                ListViewItem item = this.listViewCuerinas.Items.Add(Convert.ToString(cuerina.ID));
                item.SubItems.Add(cuerina.Nombre);
                item.SubItems.Add(Convert.ToString(cuerina.Ancho));
                item.SubItems.Add(Convert.ToString(cuerina.Precio));
                item.SubItems.Add(Convert.ToString(cuerina.PorcDeGanancia));
                item.SubItems.Add(Convert.ToString(Math.Round(((cuerina.Precio + ((cuerina.Precio * cuerina.PorcDeGanancia) / 100)) * Dolar), 2)));
            });
        }
        void ListViewArticulosRefresh()
        {
            this.listViewArticulos.Items.Clear();
            List<Articulos> listaArticulos = _Administrador.CargarListaArticulos(ArticulosOrdenarPorCol, ArticulosASCoDESC);
            listaArticulos.ForEach(articulo =>
            {
                ListViewItem item = this.listViewArticulos.Items.Add(Convert.ToString(articulo.ID));
                item.SubItems.Add(articulo.Nombre);
                item.SubItems.Add(Convert.ToString(articulo.Precio));
                item.SubItems.Add(Convert.ToString(articulo.PorcDeGanancia));
                item.SubItems.Add(Convert.ToString(Math.Round((articulo.Precio + ((articulo.Precio * articulo.PorcDeGanancia) / 100)), 2)));
            });
        }
        void Ordenar(ColumnClickEventArgs e, string auxTipo)
        {
            if (auxTipo.Equals("poliester"))
            {
                switch (e.Column)
                {
                    case 0:
                        {
                            PoliesterOrdenarPorCol = "poliesterID";
                            if (PoliesterASCoDESC.Equals("ASC")) { PoliesterASCoDESC = "DESC"; ListViewPoliesterRefresh(); }
                            else { PoliesterASCoDESC = "ASC"; ListViewPoliesterRefresh(); }; break;
                        }
                    case 1:
                        {
                            PoliesterOrdenarPorCol = "Nombre";
                            if (PoliesterASCoDESC.Equals("ASC")) { PoliesterASCoDESC = "DESC"; ListViewPoliesterRefresh(); }
                            else { PoliesterASCoDESC = "ASC"; ListViewPoliesterRefresh(); }; break;
                        }
                }
            }
            if (auxTipo.Equals("cuerina"))
            {
                switch (e.Column)
                {
                    case 0:
                        {
                            CuerinasOrdenarPorCol = "cuerinasID";
                            if (CuerinasASCoDESC.Equals("ASC")) { CuerinasASCoDESC = "DESC"; ListViewCuerinasRefresh(); }
                            else { CuerinasASCoDESC = "ASC"; ListViewCuerinasRefresh(); }; break;
                        }
                    case 1:
                        {
                            CuerinasOrdenarPorCol = "Nombre";
                            if (CuerinasASCoDESC.Equals("ASC")) { CuerinasASCoDESC = "DESC"; ListViewCuerinasRefresh(); }
                            else { CuerinasASCoDESC = "ASC"; ListViewCuerinasRefresh(); }; break;
                        }
                }
            }
            if (auxTipo.Equals("articulo"))
            {
                switch (e.Column)
                {
                    case 0:
                        {
                            ArticulosOrdenarPorCol = "articulosID";
                            if (ArticulosASCoDESC.Equals("ASC")) { ArticulosASCoDESC = "DESC"; ListViewArticulosRefresh(); }
                            else { ArticulosASCoDESC = "ASC"; ListViewArticulosRefresh(); }; break;
                        }
                    case 1:
                        {
                            ArticulosOrdenarPorCol = "Descripcion";
                            if (ArticulosASCoDESC.Equals("ASC")) { ArticulosASCoDESC = "DESC"; ListViewArticulosRefresh(); }
                            else { ArticulosASCoDESC = "ASC"; ListViewArticulosRefresh(); }; break;
                        }
                    case 3: _Administrador.EjecutarFormEntradaSimple(); break;
                }
            }
        }
        void ActualizarPestañaActual()
        {
            FPrincipalTxtClear();
            if (cPestañas.SelectedTab == pPoliester)
            {
                PestañaActual = 1;
                ListViewPoliesterRefresh();
                ActualizarTamañoColumnas();
                this.txtAncho.Enabled = true;
            }
            if (cPestañas.SelectedTab == pCuerinas)
            {
                PestañaActual = 2;
                ListViewCuerinasRefresh();
                ActualizarTamañoColumnas();
                this.txtAncho.Enabled = false;
            }
            if (cPestañas.SelectedTab == pArticulos)
            {
                PestañaActual = 3;
                ListViewArticulosRefresh();
                ActualizarTamañoColumnas();
                this.txtAncho.Enabled = false;
            }
        }
        ////////////////////////////////////
        /////  FUNCIONES DE EJECUCION  /////
        void EjecutarFormularioNuevo()
        {
            ModoEditar = false;
            switch (PestañaActual)
            {
                case 1: _Administrador.EjecutarFormPoliester(); break;
                case 2: _Administrador.EjecutarFormCuerinas(); break;
                case 3: _Administrador.EjecutarFormArticulos(); break;
            }
        }
        void EjecutarFormularioEditar()
        {
            ModoEditar = true;
            switch (PestañaActual)
            {
                case 1:
                    {
                        if (listViewPoliester.FocusedItem != null)
                        { ItemSeleccionado = listViewPoliester.FocusedItem; _Administrador.EjecutarFormPoliester(); }
                    }; break;
                case 2:
                    {
                        if (listViewCuerinas.FocusedItem != null)
                        { ItemSeleccionado = listViewCuerinas.FocusedItem; _Administrador.EjecutarFormCuerinas(); }
                    }; break;
                case 3:
                    {
                        if (listViewArticulos.FocusedItem != null)
                        { ItemSeleccionado = listViewArticulos.FocusedItem; _Administrador.EjecutarFormArticulos(); }
                    }; break;
            }
        }
        void EjecutarEliminarItem()
        {
            switch (PestañaActual)
            {
                case 1:
                    {
                        if (listViewPoliester.FocusedItem != null)
                        {
                            ListViewItem item = listViewPoliester.FocusedItem;
                            if (_Validaciones.EliminarResult())
                            { _Administrador.EliminarItem(Convert.ToInt32(item.Text)); ListViewPoliesterRefresh(); }
                        }
                    }; break;
                case 2:
                    {
                        if (listViewCuerinas.FocusedItem != null)
                        {
                            ListViewItem item = listViewCuerinas.FocusedItem;
                            if (_Validaciones.EliminarResult())
                            { _Administrador.EliminarItem(Convert.ToInt32(item.Text)); ListViewCuerinasRefresh(); }
                        }
                    }; break;
                case 3:
                    {
                        if (listViewArticulos.FocusedItem != null)
                        {
                            ListViewItem item = listViewArticulos.FocusedItem;
                            if (_Validaciones.EliminarResult())
                            { _Administrador.EliminarItem(Convert.ToInt32(item.Text)); ListViewArticulosRefresh(); }
                        }
                    }; break;
            }
        }
        void EjecutarCalculo()
        {
            switch (PestañaActual)
            {
                case 1:
                    {
                        ListViewItem item = listViewPoliester.FocusedItem;
                        if (item != null && _Validaciones.EsDecimal(this.txtAncho.Text) && _Validaciones.EsDecimal(this.txtLargo.Text))
                        { this.txtSubTotal.Text = Convert.ToString(Math.Round(Convert.ToDecimal(item.SubItems[4].Text) * Convert.ToDecimal(this.txtAncho.Text) * Convert.ToDecimal(this.txtLargo.Text), 2)); };
                        break;
                    }
                case 2:
                    {
                        ListViewItem item = listViewCuerinas.FocusedItem;
                        if (item != null && _Validaciones.EsDecimal(this.txtLargo.Text))
                        { this.txtSubTotal.Text = Convert.ToString(Math.Round(Convert.ToDecimal(item.SubItems[5].Text) * Convert.ToDecimal(this.txtLargo.Text), 2)); };
                        break;
                    }
                case 3:
                    {
                        ListViewItem item = listViewArticulos.FocusedItem;
                        if (item != null && _Validaciones.EsDecimal(this.txtLargo.Text))
                        { this.txtSubTotal.Text = Convert.ToString(Math.Round(Convert.ToDecimal(item.SubItems[4].Text) * Convert.ToDecimal(this.txtLargo.Text), 2)); };
                        break;
                    };
            }
        }
        #endregion
        #region EVENTOS
        //////////////////////////////////
        /////  EVENTOS DE SELECCION  /////
        private void CPestañas_Selecting(object sender, TabControlCancelEventArgs e)
        {
            ActualizarPestañaActual();
        }
        private void ListViewCuerinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = listViewCuerinas.FocusedItem;
            if (item != null) { this.txtAncho.Text = item.SubItems[2].Text; }
        }
        ////////////////////////////////
        /////  EVENTOS DE BOTONES  /////
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            EjecutarFormularioNuevo();
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            EjecutarFormularioEditar();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EjecutarEliminarItem();
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            EjecutarCalculo();
        }
        private void BtnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                SetearColor(colorDialog.Color);
                Properties.Settings.Default.Color = colorDialog.Color;
                Properties.Settings.Default.Save();
            }
        }
        ////////////////////////////////
        /////  EVENTOS DE TEXTBOX  /////
        private void TxtAncho_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Validaciones.SoloNumerosYComa(e);
            if (_Validaciones.EnterEsPresionado(e)) { this.GetNextControl(ActiveControl, true).Focus(); e.Handled = true; }
        }
        private void TxtAncho_Validating(object sender, CancelEventArgs e)
        {
            if (!_Validaciones.EsDecimal(this.txtAncho.Text) && !_Validaciones.EsNullOTieneEspaciosEnBlanco(this.txtAncho.Text))
            { e.Cancel = true; }
        }
        private void TxtLargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Validaciones.SoloNumerosYComa(e);
            if (_Validaciones.EnterEsPresionado(e)) { this.GetNextControl(ActiveControl, true).Focus(); e.Handled = true; }
        }
        private void TxtLargo_Validating(object sender, CancelEventArgs e)
        {
            if (!_Validaciones.EsDecimal(this.txtLargo.Text) && !_Validaciones.EsNullOTieneEspaciosEnBlanco(this.txtLargo.Text))
            { e.Cancel = true; }
        }
        private void TxtDolarLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Validaciones.SoloNumerosYComa(e);
            if (_Validaciones.EnterEsPresionado(e)) { this.GetNextControl(ActiveControl, true).Focus(); e.Handled = true; }
        }
        private void TxtDolarLocal_Validating(object sender, CancelEventArgs e)
        {
            if (!_Validaciones.EsDecimal(this.txtDolarLocal.Text)) { e.Cancel = true; }
        }
        private void TxtDolarLocal_Validated(object sender, EventArgs e)
        {
            Dolar = Convert.ToDecimal(this.txtDolarLocal.Text);
            switch (PestañaActual)
            {
                case 1: ListViewPoliesterRefresh(); break;
                case 2: ListViewCuerinasRefresh(); break;
                case 3: ListViewArticulosRefresh(); break;
            }
        }
        private void TxtSubTotal_TextChanged(object sender, EventArgs e)
        {
            if (!fPrincipalCheckBox1.Checked && !fPrincipalCheckBox2.Checked && !fPrincipalCheckBox3.Checked)
            { this.txtTotal.Text = this.txtSubTotal.Text; }
        }
        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {
            if (_Validaciones.EsDecimal(this.txtTotal.Text))
            {
                if (Convert.ToDecimal(this.txtTotal.Text) == 0 && !_Validaciones.EsNullOTieneEspaciosEnBlanco(this.txtSubTotal.Text))
                { this.txtTotal.Text = this.txtSubTotal.Text; }
            }
        }
        /////////////////////////////////
        /////  EVENTOS DE KEYPRESS  /////
        private void listViewPoliester_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_Validaciones.EnterEsPresionado(e)) { this.txtAncho.Focus(); }
        }

        private void listViewCuerinas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_Validaciones.EnterEsPresionado(e)) { this.txtLargo.Focus(); }
        }

        private void listViewArticulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_Validaciones.EnterEsPresionado(e)) { this.txtLargo.Focus(); }
        }
        /////////////////////////////////
        /////  EVENTOS DE CHECKBOX  /////
        private void FPrincipalCheckBox1_Validated(object sender, EventArgs e)
        {
            if (!_Validaciones.EsDecimal(fPrincipalCheckBox1.Text)) { fPrincipalCheckBox1.Checked = false; }
        }
        private void FPincipalCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (fPrincipalCheckBox1.Checked && !_Validaciones.EsNullOTieneEspaciosEnBlanco(this.txtSubTotal.Text))
            {
                this.fPrincipalCheckBox1.Text = this.txtSubTotal.Text;
                Total += Convert.ToDecimal(fPrincipalCheckBox1.Text);
                this.txtTotal.Text = Total.ToString();
            }
            else if (!fPrincipalCheckBox1.Checked && _Validaciones.EsDecimal(fPrincipalCheckBox1.Text))
            {
                Total -= Convert.ToDecimal(fPrincipalCheckBox1.Text);
                this.txtTotal.Text = Total.ToString();
                fPrincipalCheckBox1.Text = "...";
            }
        }
        private void FPrincipalCheckBox2_Validated(object sender, EventArgs e)
        {
            if (!_Validaciones.EsDecimal(fPrincipalCheckBox2.Text)) { fPrincipalCheckBox2.Checked = false; }
        }
        private void FPincipalCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (fPrincipalCheckBox2.Checked && !_Validaciones.EsNullOTieneEspaciosEnBlanco(this.txtSubTotal.Text))
            {
                this.fPrincipalCheckBox2.Text = this.txtSubTotal.Text;
                Total += Convert.ToDecimal(fPrincipalCheckBox2.Text);
                this.txtTotal.Text = Total.ToString();
            }
            else if (!fPrincipalCheckBox2.Checked && _Validaciones.EsDecimal(fPrincipalCheckBox2.Text))
            {
                Total -= Convert.ToDecimal(fPrincipalCheckBox2.Text);
                this.txtTotal.Text = Total.ToString();
                fPrincipalCheckBox2.Text = "...";
            }
        }
        private void FPrincipalCheckBox3_Validated(object sender, EventArgs e)
        {
            if (!_Validaciones.EsDecimal(fPrincipalCheckBox3.Text)) { fPrincipalCheckBox3.Checked = false; }
        }
        private void FPincipalCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (fPrincipalCheckBox3.Checked && !_Validaciones.EsNullOTieneEspaciosEnBlanco(this.txtSubTotal.Text))
            {
                this.fPrincipalCheckBox3.Text = this.txtSubTotal.Text;
                Total += Convert.ToDecimal(fPrincipalCheckBox3.Text);
                this.txtTotal.Text = Total.ToString();
            }
            else if (!fPrincipalCheckBox3.Checked && _Validaciones.EsDecimal(fPrincipalCheckBox3.Text))
            {
                Total -= Convert.ToDecimal(fPrincipalCheckBox3.Text);
                this.txtTotal.Text = Total.ToString();
                fPrincipalCheckBox3.Text = "...";
            }
        }
        /////////////////////////////////
        /////  EVENTOS COLUMNCLICK  /////
        private void listViewPoliester_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Ordenar(e, "poliester");
        }
        private void listViewCuerinas_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Ordenar(e, "cuerinas");
        }
        private void listViewArticulos_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Ordenar(e, "articulo");
        }
        ////////////////////////////
        /////  OTROS EVENTOS  //////
        private void FPrincipal_Activated(object sender, EventArgs e)
        {
            ListViewPoliesterRefresh();
            ListViewCuerinasRefresh();
            ListViewArticulosRefresh();
        }
        private void FPrincipal_Resize(object sender, EventArgs e)
        {
            ActualizarTamañoColumnas();
        }
        private void FPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetOnClosing();
        }
        #endregion
    }
}
