using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petSenac.Model
{
   
    
   public class Usuario
   {

            public int Id { get; set; }
            public string NomeCompleto { get; set; }
            public string Email { get; set; }
            public string Senha { get; set; }






            public DataTable Listar()

            {
                string comando = "SELECT * FROM donos";
                Banco conexaoBD = new Banco();
                MySqlConnection con = conexaoBD.ObterConexao();
                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Prepare();
                DataTable tabela = new DataTable();
                tabela.Load(cmd.ExecuteReader());
                conexaoBD.Desconectar(con);
                return tabela;
            }

            public bool Apagar()
            {
                string comando = "DELETE FROM donos WHERE id = @id";
                Banco conexaoBD = new Banco();
                MySqlConnection con = conexaoBD.ObterConexao();
                MySqlCommand cmd = new MySqlCommand(comando, con);

                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Prepare();

                try
                {
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        conexaoBD.Desconectar(con);
                        return false;
                    }
                    else
                    {
                        conexaoBD.Desconectar(con);
                        return true;
                    }
                }
                catch
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
            }
            public bool Cadastrar()
            {
                string comando = "INSERT INTO produtos (nome_completo,id,email,senha) VALUES " +
                   "(@nome_completo,@id, @email, @senha)";
                Banco conexaoBD = new Banco();
                MySqlConnection con = conexaoBD.ObterConexao();
                MySqlCommand cmd = new MySqlCommand(comando, con);

                cmd.Parameters.AddWithValue("@nome_completo", NomeCompleto);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@nome", Id);
                cmd.Parameters.AddWithValue("@senha", Senha);




                cmd.Prepare();

                try
                {
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        conexaoBD.Desconectar(con);
                        return false;
                    }
                    else
                    {
                        conexaoBD.Desconectar(con);
                        return true;
                    }
                }
                catch
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
            }
            public bool Modificar()
            {
                string comando = "UPDATE produtos SET nome = @nome,preco = @preco,id_respcadastro = @id_respcadastro," +
                    "id_categoria = @id_categoria WHERE id = @id";
                Banco conexaoBD = new Banco();
                MySqlConnection con = conexaoBD.ObterConexao();
                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@nome_completo", NomeCompleto);

                string hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);

                cmd.Parameters.AddWithValue("@senha", Senha);


                cmd.Prepare();

                try
                {
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        conexaoBD.Desconectar(con);
                        return false;
                    }
                    else
                    {
                        conexaoBD.Desconectar(con);
                        return true;
                    }
                }
                catch
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
            }
   }
    
}

