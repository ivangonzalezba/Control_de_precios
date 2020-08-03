using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sistem_de_inventario
{
    public partial class FPoliester : Form
    {
        Validaciones _Validaciones;
        Administrador _Administrador;
        public FPoliester()
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
                this.fPolTxtNombre.Text = (FPrincipal.ItemSeleccionado.SubItems[1].Text).Trim();
                this.fPolTxtPrecio.Text = FPrincipal.ItemSeleccionado.SubItems[2].Text;
                this.fPolTxtPorcentajePlancha.Text = FPrincipal.ItemSeleccionado.SubItems[3].Text;
                this.fPolTxtPorcentaje.Text = FPrincipal.ItemSeleccionado.SubItems[5].Text;
            }
        }
        private void FPolBtnCancelar_Click(object sender, EventArgs e) { this.Close(); }

        private void FPolBtnAceptar_Click(object sender, EventArgs e)
        {
            if (!FPrincipal.ModoEditar && this.ValidateChildren())
            {
                Poliester poliester = new Poliester()
                {
                    Nombre = this.fPolTxtNombre.Text,
                    Precio = Convert.ToDecimal(this.fPolTxtPrecio.Text),
                    PorcDeGananciaPlancha = Convert.ToInt32(this.fPolTxtPorcentajePlancha.Text),
                    PorcDeGanancia = Convert.ToInt32(this.fPolTxtPorcentaje.Text),
                };
                _Administrador.GuardarNuevoPoliester(poliester);
                this.Close();
            }
            else if (FPrincipal.ModoEditar && this.ValidateChildren())
            {
                Poliester poliester = new Poliester()
                {
                    ID = Convert.ToInt32(FPrincipal.ItemSeleccionado.Text),
                    Nombre = this.fPolTxtNombre.Text,
                    Precio = Convert.ToDecimal(this.fPolTxtPrecio.Text),
                    PorcDeGananciaPlancha = Convert.ToInt32(this.fPolTxtPorcentajePlancha.Text),
                    PorcDeGanancia = Convert.ToInt32(this.fPolTxtPorcentaje.Text),
                };
                _Administrador.ActualizarPoliester(poliester);
                this.Close();
            }
        }
        private void FPolTxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_Validaciones.EnterEsPresionado(e)) { this.GetNextControl(ActiveControl, true).Focus(); e.Handled = true; }
        }
        private void FPolTxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Validaciones.SoloNumerosYComa(e);
            if (_Validaciones.EnterEsPresionado(e)) { this.GetNextControl(ActiveControl, true).Focus(); e.Handled = true; }
        }
        private void fPolTxtPorcentajePlancha_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Validaciones.SoloNumeros(e);
            if (_Validaciones.EnterEsPresionado(e)) { this.GetNextControl(ActiveControl, true).Focus(); e.Handled = true; }
        }
        private void FPolTxtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Validaciones.SoloNumeros(e);
            if (_Validaciones.EnterEsPresionado(e)) { this.GetNextControl(ActiveControl, true).Focus(); e.Handled = true; }
        }
        private void FPolTxtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (!fPolBtnCancelar.Focused)
            {
                if (_Validaciones.EsNullOTieneEspaciosEnBlanco(this.fPolTxtNombre.Text)) { e.Cancel = true; }
            }
        }
        private void FPolTxtPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (!fPolBtnCancelar.Focused)
            {
                if (!_Validaciones.EsDecimal(this.fPolTxtPrecio.Text)) { e.Cancel = true; }
                else { this.fPolLblPrecio.Text = "$" + ((Convert.ToDecimal(this.fPolTxtPrecio.Text)) * FPrincipal.Dolar).ToString(); }
            }
        }
        private void fPolTxtPorcentajePlancha_Validating(object sender, CancelEventArgs e)
        {
            if (!fPolBtnCancelar.Focused)
            {
                if (!_Validaciones.EsEntero(this.fPolTxtPorcentajePlancha.Text)) { e.Cancel = true; }
            }
        }
        private void FPolTxtPorcentaje_Validating(object sender, CancelEventArgs e)
        {
            if (!fPolBtnCancelar.Focused)
            {
                if (!_Validaciones.EsEntero(this.fPolTxtPorcentaje.Text)) { e.Cancel = true; }
            }
        }
    }
}
