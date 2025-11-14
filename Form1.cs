using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora_Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Convierte texto del TextBox a decimal y valida
        private decimal ParseDecimal(TextBox txt, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
                throw new Exception($"{fieldName} cannot be empty.");

            if (!decimal.TryParse(txt.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal value) &&
                !decimal.TryParse(txt.Text, NumberStyles.Any, new CultureInfo("es-ES"), out value))
            {
                throw new Exception($"{fieldName} has an invalid format.");
            }

            if (value < 0)
                throw new Exception($"{fieldName} cannot be negative.");

            return value;
        }

        // Botón Calcular
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal price = ParseDecimal(txtPrice, "Price");
                decimal quantity = ParseDecimal(txtQuantity, "Quantity");

                if (quantity < 1) throw new Exception("Quantity must be at least 1.");

                decimal subtotal = price * quantity;

                // Descuento primero
                decimal discountPercent = 0m;

                if (chkPartner.Checked)
                {
                    discountPercent = 30m;
                }
                else
                {
                    if (rbD5.Checked) discountPercent = 5m;
                    if (rbD10.Checked) discountPercent = 10m;
                    if (rbD20.Checked) discountPercent = 20m;
                    // rbD0 deja discountPercent = 0
                }

                decimal noIva = subtotal * (1m - (discountPercent / 100m));

                // IVA después
                decimal ivaPercent = 0m;
                if (rbIva4.Checked) ivaPercent = 4m;
                if (rbIva10.Checked) ivaPercent = 10m;
                if (rbIva21.Checked) ivaPercent = 21m;
                // rbIva0 deja ivaPercent = 0

                decimal withIva = noIva * (1m + (ivaPercent / 100m));

                // Mostrar resultados en €
                var ci = new CultureInfo("es-ES");
                txtNoIva.Text = noIva.ToString("C2", ci);
                txtWithIva.Text = withIva.ToString("C2", ci);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Partner desactiva Discounts
        private void chkPartner_CheckedChanged(object sender, EventArgs e)
        {
            grpDiscount.Enabled = !chkPartner.Checked;
            if (chkPartner.Checked)
            {
                rbD0.Checked = true; // Evita confusión
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
