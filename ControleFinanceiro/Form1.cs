 using ControleFinanceiro.Model;

namespace ControleFinanceiro
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            VerificarCaixasPreenchidas();
        }

        private void VerificarCaixasPreenchidas()
        {
            if (txtNome.Text != "" && txtCpf.Text != "")
                btnInserir.Enabled = true;
            else
                btnInserir.Enabled = false;
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            VerificarCaixasPreenchidas();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            lstClientes.Items.Add(cliente.ToString());

            txtNome.Text = "";
            txtCpf.Text = "";

            btnExcluir.Enabled = false;
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex >= 0)
            {
                btnExcluir.Enabled = true;

                string[] dados = lstClientes.SelectedItem.ToString().Split(" - ");
                txtNome.Text = dados[0];
                txtCpf.Text = dados[1];

                txtNome.Clear();
                txtCpf.Clear();
            }
            else
            {
                btnExcluir.Enabled = false;

                txtNome.ReadOnly = false;
                txtCpf.ReadOnly = false;
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex >= 0)
            {

                lstClientes.Items.RemoveAt(lstClientes.SelectedIndex);

                txtNome.Clear();
                txtCpf.Clear();

                txtNome.ReadOnly = false;
                txtCpf.ReadOnly = false;


                btnExcluir.Enabled = false;
            }
        }
    }
}
