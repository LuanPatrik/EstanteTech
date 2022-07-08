using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using estanteTech.Modelo;
using estanteTech.SQL;

namespace estanteTech.Forms.Formleitor
{
    public partial class FormAddEditLeitor : Form
    {
        Leitor leitor = new Leitor();
        LeitorSQL leitorSQL = new LeitorSQL();
        private int id;
        private DataGridView dgvLeitor;

        public FormAddEditLeitor(DataGridView dgv)
        {
            InitializeComponent();
            dgvLeitor = dgv;
        }

        public FormAddEditLeitor(Leitor leitor, DataGridView dgv)
        {
            InitializeComponent();
            dgvLeitor = dgv;
            id = leitor.getId_leitor();
            tbNome.Text = leitor.getNome();
            tbEmail.Text = leitor.getEmail();
            tbNumRA.Text = Convert.ToString(leitor.getNumero_ra());
            mtbTelefone.Text = Convert.ToString(leitor.getTelefone());
            dtpData_nasc.Text = Convert.ToString(leitor.getData_nasc());
        }

        public bool valida()
        {
            if (String.IsNullOrWhiteSpace(tbNome.Text) || String.IsNullOrWhiteSpace(dtpData_nasc.Text) ||
                String.IsNullOrWhiteSpace(tbEmail.Text) || String.IsNullOrWhiteSpace(tbNumRA.Text) ||
                String.IsNullOrWhiteSpace(mtbTelefone.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public void limparCampos(Control crtl)
        {
            foreach (Control c in crtl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Text = "";
                }
                if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = "";
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool resultado = valida();

            if (resultado == true)
            {
                leitor.setId_leitor(id);
                leitor.setNome(tbNome.Text);
                leitor.setData_nasc(Convert.ToDateTime(dtpData_nasc.Text));
                leitor.setEmail(tbEmail.Text);
                leitor.setNumero_ra(Convert.ToDouble(tbNumRA.Text));
                leitor.setTelefone(Convert.ToDouble(mtbTelefone.Text));

                if (leitor.getId_leitor() == 0)
                {
                    leitorSQL.incluir(leitor);
                    MessageBox.Show("Leitor Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos(this);
                }
                else
                {
                    leitorSQL.atualizar(leitor);
                    MessageBox.Show("Leitor Atualizar com Sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FormAddEditLeitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            leitorSQL.getLeitor(dgvLeitor);
        }
    }
}
