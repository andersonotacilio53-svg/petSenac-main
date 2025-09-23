using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petSenac
{
    public partial class FormCaixa : Form
    {
        Model.Usuario usuario;
        public FormCaixa(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
       


        private void btnListar_Click(object sender, EventArgs e)
        {
            // Verificar se o campo está vazio:
            if (txbComanda.Text.Length == 0)
            {
                MessageBox.Show("Imforme o número da comanda!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbComanda.Text);

                //Tabela para receber o resutado da consulta SELECT
                DataTable resultado = ordemComanda.BuscarPorFicha();

                // verificar se exitem linhas em, "resultado":
                if (resultado.Rows.Count > 0)
                {
                    //Mostrar no dgv:
                    dgvDescricao.DataSource = resultado;
                    // Calcular o total e mostrar no lblTotal:
                    lblTotal.Text = "R$" + resultado.Compute("Sum(Total_Item)", "True").ToString();
                }
                else
                {
                    //Limpar o dgv:
                    dgvDescricao.DataSource = null;
                    // Mostrar mensagem de erro:
                    MessageBox.Show("Não existem lançamentos nessa comanda!", "Atenção",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void chbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            btnFinalizar.Enabled = chbPagamento.Checked;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar essa comanda?",
                "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Encerrar a comanda:
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbComanda.Text);

                //Executar o update parea encerrar a comanda:
                if (ordemComanda.EncerrarComanda())
                {
                    MessageBox.Show("Comanda encerrada!", "Show",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    // Resetar os campos:
                    txbComanda.Clear();
                    dgvDescricao.DataSource = null;
                    chbPagamento.Checked = false;
                    btnFinalizar.Enabled = false;
                    lblTotal.Text = "R$   -  ";
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a comanda", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDescricao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a linha selecionada
            int ls = dgvDescricao.SelectedCells[0].RowIndex;

            // Colocar os ID do produto no  campo de código:
            txbComanda.Text = dgvDescricao.Rows[ls].Cells[0].Value.ToString();
            // Colocar nome do produto no campo de informãções:
            txbComanda.Text = dgvDescricao.Rows[ls].Cells[1].Value.ToString();
        }
    }
}
