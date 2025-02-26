using System;

namespace CadastroDeJogosWindowsForms.Models
{
    internal class JogosViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double ValorLocacao { get; set; }
        public DateTime DataAquisicao { get; set; }
        public int CategoriaId { get; set; }

        public JogosViewModel(int id, string descricao, double valorLocacao, DateTime dataAquisicao, int categoriaId)
        {
            Id = id;
            Descricao = descricao;
            ValorLocacao = valorLocacao;
            DataAquisicao = dataAquisicao;
            CategoriaId = categoriaId;
        }
        public JogosViewModel()
        {
            
        }
    }
}
