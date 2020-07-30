using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sistem_de_inventario
{
    public partial class FEntradaSimple : Form
    {
        Validaciones _Validaciones;
        Administrador _Administrador;
        public FEntradaSimple()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        { _Validaciones = new Validaciones(); _Administrador = new Administrador(); }
        private void FEntradaBtnCancelar_Click(object sender, EventArgs e) { this.Close(); }
        private void FEntradaBtnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            { _Administrador.ActualizarPorcentajeArticulos(Convert.ToInt32(this.fPorcentajeTxtbox.Text)); this.Close(); }
        }
        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!fEntradaBtnCancelar.Focused)
            {
                if (!_Validaciones.EsEntero(fPorcentajeTxtbox.Text)) { e.Cancel = true; }
            }
        }
        private void FPorcentajeTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Validaciones.SoloNumerosYResta(e);
            if (_Validaciones.EnterEsPresionado(e)) { GetNextControl(ActiveControl, true).Focus(); e.Handled = true; }
        }
    }
}
