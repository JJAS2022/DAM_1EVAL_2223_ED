namespace GestionBancaria
{
    public partial class Form1 : Form
    {
        private double saldo_JAS_2223 = 1000;  // Saldo inicial de la cuenta, 1000�

        public Form1()
        {
            InitializeComponent();
            txtSaldo.Text = saldo_JAS_2223.ToString();
            txtCantidad.Text = "0";
        }

        private bool realizarReintegro(double cantidad)
        {
            if (cantidad > 0 && saldo_JAS_2223 >= cantidad)
            {
                saldo_JAS_2223 -= cantidad;
                return true;
            }
            return false;
        }

        private void realizarIngreso(double cantidad)
        {
            if (cantidad > 0)
                saldo_JAS_2223 += cantidad;
        }

        private void btOperar_Click(object sender, EventArgs e)
        {
            double cantidad_JAS_2223 = Convert.ToDouble(txtCantidad.Text); // Cogemos la cantidad del TextBox y la pasamos a n�mero
            if (cantidad_JAS_2223 < 0)
            {
                MessageBox.Show("Cantidad no v�lida, s�lo se admiten cantidades positivas.");
            }
            if (rbReintegro.Checked)
            {
                if (realizarReintegro(cantidad_JAS_2223) == false)  // No se ha podido completar la operaci�n, saldo insuficiente?
                    MessageBox.Show("No se ha podido realizar la operaci�n (�Saldo insuficiente?)");
            }
            else if (rbIngreso.Checked)
            {
                realizarIngreso(cantidad_JAS_2223);
            }
            else
                MessageBox.Show("Seleccionar una opci�n para operar.");
            txtSaldo.Text = saldo_JAS_2223.ToString();
        }
    }
}