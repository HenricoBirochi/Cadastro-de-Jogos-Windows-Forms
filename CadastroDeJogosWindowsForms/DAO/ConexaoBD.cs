using System.Data.SqlClient;

namespace CadastroDeJogosWindowsForms.DAO
{
    internal static class ConexaoBD
    {
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=LOCALHOST; Database=AulaDBFacul; user id=sa; password=123456";
            //"Data Source=LOCALHOST; Database=AULADB; integrated security=true"; se vc quiser fazer
            SqlConnection conexao = new SqlConnection(strCon);//a conexao pela autenticacao do windows
            conexao.Open();
            return conexao;
        }
    }
}
