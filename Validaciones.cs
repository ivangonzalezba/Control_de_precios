using System;
using System.Windows.Forms;

namespace Sistem_de_inventario
{
    public class Validaciones
    {
        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }  
        }
        public void SoloNumerosYComa(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
        public void SoloNumerosYResta(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        public bool EnterEsPresionado(KeyPressEventArgs e)
        {
            return e.KeyChar == (char)13;
        }
        public bool EsDecimal(string aux)
        {
            return decimal.TryParse(aux, out decimal result);
        }
        public bool EsEntero(string aux)
        {
            return int.TryParse(aux, out int retuls);
        }
        public bool EsNullOTieneEspaciosEnBlanco(string aux)
        {
            return string.IsNullOrWhiteSpace(aux);
        }
        public bool EliminarResult()
        {
            DialogResult deleteDialog;
            deleteDialog = MessageBox.Show("Eliminar el registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (deleteDialog == DialogResult.OK) { return true; } else { return false; }
        }
    }
}
