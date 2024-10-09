namespace ControleFinanceiro
{
    partial class frmCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            lblCpf = new Label();
            btnInserir = new Button();
            btnExcluir = new Button();
            lstClientes = new ListBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(69, 60);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(139, 60);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(139, 102);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 3;
            txtCpf.TextChanged += txtCpf_TextChanged;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(69, 105);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(31, 15);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF:";
            // 
            // btnInserir
            // 
            btnInserir.Enabled = false;
            btnInserir.Location = new Point(69, 152);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 4;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(164, 152);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(69, 201);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(170, 94);
            lstClientes.TabIndex = 6;
            lstClientes.SelectedIndexChanged += lstClientes_SelectedIndexChanged;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 333);
            Controls.Add(lstClientes);
            Controls.Add(btnExcluir);
            Controls.Add(btnInserir);
            Controls.Add(txtCpf);
            Controls.Add(lblCpf);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "frmCliente";
            Text = "Controle de Clientes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtCpf;
        private Label lblCpf;
        private Button btnInserir;
        private ListBox lstClientes;
        private Button btnExcluir;
    }
}
