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
    public partial class MenuPrincipal : Form
    {
        Model.Usuario usuario = new Model.Usuario();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario(usuario);
            FormUsuario.ShowDialog();

        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            btnCaixa formCaixa = new btnCaixa(usuario);
            formCaixa.ShowDialog();

        }
    }
}
