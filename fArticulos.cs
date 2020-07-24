using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sistem_de_inventario
{
    public partial class fArticulos : Form
    {
        Validaciones _Validaciones;
        Administrador _Administrador;
        public fArticulos()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            _Validaciones = new Validaciones();
            _Administrador = new Administrador();
            if (FPrincipal.ModoEditar)
            {
                this.Text = "Editar";
                this.fArtTxtNombre.Text = (FPrincipal.ItemSeleccionado.SubItems[1].Text).Trim();
                this.fArtTxtPrecio.Text = FPrincipal.ItemSeleccionado.SubItems[2].Text;
                this.fArtTxtPorcentaje.Text = FPrincipal.ItemSeleccionado.SubItems[3].Text;
            }
        }
        private void FArtBtnCancelar_Click(object sender, EventArgs e) { this.Close(); }
        private void FArtBtnAceptar_Click(object sender, EventArgs e)
        {
            if (!FPrincipal.ModoEditar && this.ValidateChildren())
            {
                Articulos articulo = new Articulos()
                {
                    Nombre = this.fArtTxtNombre.Text,
                    Precio = Convert.ToDecimal(this.fArtTxtPrecio.Text),
                    PorcDeGanancia = Convert.ToInt32(this.fArtTxtPorcentaje.Text),
                };
                _Administrador.GuardarNuevoArticulo(articulo);
                this.Close();
            }
            else if (FPrincipal.ModoEditar && this.ValidateChildren())
            {
                Articulos articulo = new Articulos()
                {
                    ID = Convert.ToInt32(FPrincipal.ItemSeleccionado.Text),
                    Nombre = this.fArtTxtNombre.Text,
                    Precio = Convert.ToDecimal(this.fArtTxtPrecio.Text),
                    PorcDeGanancia = Convert.ToInt32(this.fArtTxtPorcentaje.Text),
                };
                _Administrador.ActualizarArticulo(articulo);
                this.Close();
            }
        }
        private void FArtTxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_Validaciones.EnterEsPresionado(e)) { this.GetNextControl(ActiveControl, true).Focus(); e.Handled = true; }
        }
        private void FArtTxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Validaciones.SoloNumerosYComa(e);
            if (_Validaciones.EnterEsPresionado(e)) { this.GetNextControl(ActiveControl, true).Focus(); e.Handled = true; }
        }
        private void FArtTxtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Validaciones.SoloNumerosYComa(e);
            if (_Validaciones.EnterEsPresionado(e)) { this.GetNextControl(ActiveControl, true).Focus(); e.Handled = true; }
        }
        private void FArtTxtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (!fArtBtnCancelar.Focused)
            {
                if (_Validaciones.EsNullOTieneEspaciosEnBlanco(this.fArtTxtNombre.Text)) { e.Cancel = true; }
            }
        }
        private void FArtTxtPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (!fArtBtnCancelar.Focused)
            {
                if (!_Validaciones.EsDecimal(this.fArtTxtPrecio.Text)) { e.Cancel = true; }
            }
        }
        private void FArtTxtPorcentaje_Validating(object sender, CancelEventArgs e)
        {
            if (!fArtBtnCancelar.Focused)
            {
                if (!_Validaciones.EsEntero(this.fArtTxtPorcentaje.Text)) { e.Cancel = true; }
            }
        }
    }
}
