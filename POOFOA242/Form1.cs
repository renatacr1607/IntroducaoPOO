namespace POOFOA242
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void btnCliqueMe_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            MessageBox.Show($"Seja bem-vindo(a) {nome}");
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
                btnCliqueMe.Enabled = false;
            else
                btnCliqueMe.Enabled = true;
        }
    }
}
