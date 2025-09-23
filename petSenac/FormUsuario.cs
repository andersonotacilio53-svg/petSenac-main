using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petSenac
{
    public partial class FormUsuario : Form
    {

        // Objetos Globais:
        Model.Usuario usuario;

        int idSelecionado = 0; // armazenar o id do usuário selecionado p/ apagar ou edidar.

        public FormUsuario(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            // Mostrar as infromações do bd no datagrigview:
            dgvLista.DataSource = usuario.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validar campos:
            if (txbEmail.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmail.Text.Length < 7) //a@a.com 
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Fazer Cadastro...
                Model.Usuario usuarioCadastro = new Model.Usuario();


                // Salvar os valores dos campos nos atributos do obj:
                usuarioCadastro.NomeCompleto = txbNome.Text;
                usuarioCadastro.Email = txbEmail.Text;
                usuarioCadastro.Senha = txbSenha.Text;

                // Executar o INSERT:
                if (usuarioCadastro.Cadastrar())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    AtualizarDgv();


                    // Apagar os campos de cadastro:
                    txbNome.Clear();
                    txbEmail.Clear();
                    txbSenha.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o usuário!",
                        "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void dgvlista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a linha selecionada
            int ls = dgvLista.SelectedCells[0].RowIndex;

            // Colocar os valores das células no txbx de edição:
            txbNomeEditar.Text = dgvLista.Rows[ls].Cells[1].Value.ToString();
            txbEmailEditar.Text = dgvLista.Rows[ls].Cells[1].Value.ToString();

            // Armazenar o ID de quem foi selecionado:
            idSelecionado = (int)dgvLista.Rows[ls].Cells[0].Value;

            // Ativar o grvEditar:
            grbEditar.Enabled = true;

            // Ajustes no grbApagar:
            grbApagar.Text = $"Apagar: {dgvLista.Rows[ls].Cells[1].Value}";

            // Ativar o grbApagar:
            grbApagar.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar esse usuário?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //  Prosseguir com a exclusão...
                Model.Usuario usuarioApagar = new Model.Usuario();

                usuarioApagar.Id = idSelecionado;
                if (usuarioApagar.Apagar())
                {
                    MessageBox.Show("Usuário apagado com sucesso!", "Show",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao apagar o usuário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void ResetarCampos()
        {

            // Atualizar o dgv:
            AtualizarDgv();

            // Limpar campos de edição:
            txbEmailEditar.Clear();
            txbNomeEditar.Clear();
            txbSenhaEditar.Clear();

            // Retornar o idSelecionado para 0
            idSelecionado = 0;

            //Retornar o texto padrão do "apagar"
            grbApagar.Text = "Selecione o usuário que deseja apagar.";

            //Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validar campos:
            if (txbNomeEditar.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailEditar.Text.Length < 7) //a@a.com 
            {
                MessageBox.Show("A semail deve ter no mínimo 6 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaEditar.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres.",
                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Prosseguir com a edição:
                Model.Usuario usuarioEditar = new Model.Usuario();
                usuarioEditar.Id = idSelecionado;
                usuarioEditar.NomeCompleto = txbNomeEditar.Text;
                usuarioEditar.Email = txbEmailEditar.Text;
                usuarioEditar.Senha = txbSenhaEditar.Text;

                if (usuarioEditar.Modificar())
                {
                    MessageBox.Show("Usuário modificado com sucesso!",
                        "Show", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao modificar o usuário!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

    }
}

