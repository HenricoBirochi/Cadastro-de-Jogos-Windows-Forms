using System.Data.SqlClient;
using CadastroDeJogosWindowsForms.Models;

namespace CadastroDeJogosWindowsForms.DAO
{
    class JogosDAO
    {
        private SqlParameter[] CriaParametros(JogosViewModel jogo)
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("@id", jogo.Id);
            p[1] = new SqlParameter("@descricao", jogo.Descricao);
            p[2] = new SqlParameter("@valorLocacao", jogo.ValorLocacao);
            p[3] = new SqlParameter("@dataAquisicao", jogo.DataAquisicao);
            p[4] = new SqlParameter("@categoriaId", jogo.CategoriaId);
            return p;
        }
        public void Post(JogosViewModel jogo)
        {
            string sql = "INSERT INTO jogos (id, descricao, valorLocacao, dataAquisicao, categoriaId) " +
                "values(@id, @descricao, @valorLocacao, @dataAquisicao, @categoriaId)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(jogo));
        }
        public void Put(JogosViewModel jogo)
        {
            string sql = "UPDATE jogos SET id = @id, descricao = @descricao, valorLocacao = @valorLocacao, " +
                "dataAquisicao = @dataAquisicao, categoriaId = @categoriaId";
            HelperDAO.ExecutaSQL(sql, CriaParametros(jogo));
        }
        public void Delete(int id)
        {
            string sql = $"DELETE FROM jogos WHERE id = {id}";
            HelperDAO.ExecutaSQL(sql);
        }
    }
}
