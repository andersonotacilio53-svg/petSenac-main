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

    }
}

