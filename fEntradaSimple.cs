using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_de_inventario
{
    public partial class fEntradaSimple : Form
    {
        Validaciones _Validaciones;
        Administrador _Administrador;
        public fEntradaSimple()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        { _Validaciones = new Validaciones(); _Administrador = new Administrador(); }
        private void fEntradaBtnCancelar_Click(object sender, EventArgs e){ this.Close(); }
        private void fEntradaBtnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            { _Administrador.ActualizarPorcentajeArticulos(Convert.ToInt32(this.fPorcentajeTxtbox.Text)); this.Close(); }
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!fEntradaBtnCancelar.Focused)
            {
                if (!_Validaciones.EsEntero(fPorcentajeTxtbox.Text)) { e.Cancel = true; }
            }
        }
        private void fPorcentajeTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Validaciones.SoloNumerosYResta(e);
            if (_Validaciones.EnterEsPresionado(e)) { GetNextControl(ActiveControl, true).Focus(); e.Handled = true; }
        }
    }
}
