using CadastroDeJogosWindowsForms.DAO;
using CadastroDeJogosWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeJogosWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                JogosViewModel jogo = new JogosViewModel(int.Parse(txtId.Text), txtDescricao.Text, double.Parse(txtValorLocacao.Text),
                    DateTime.Parse(txtDataAquisicao.Text), int.Parse(txtCategoriaId.Text));
                JogosDAO jDAO = new JogosDAO();
                jDAO.Post(jogo);
                MessageBox.Show("O jogo foi inserido com sucesso!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                JogosViewModel jogo = new JogosViewModel(int.Parse(txtId.Text), txtDescricao.Text, double.Parse(txtValorLocacao.Text),
                    DateTime.Parse(txtDataAquisicao.Text), int.Parse(txtCategoriaId.Text));
                JogosDAO jDAO = new JogosDAO();
                jDAO.Put(jogo);
                MessageBox.Show("O jogo foi alterado com sucesso!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                {
                    JogosDAO jDAO = new JogosDAO();
                    jDAO.Delete(int.Parse(txtId.Text));
                    MessageBox.Show("Excluido com sucesso");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)//consulta
        {
            try
            {
                JogosDAO jDAO = new JogosDAO();
                JogosViewModel jogos = jDAO.Consultar(int.Parse(txtId.Text));
                if (jogos == null)
                {
                    MessageBox.Show("O jogo não foi encontrado");
                }
                else
                {
                    txtId.Text = jogos.Id.ToString();
                    txtDescricao.Text = jogos.Descricao.ToString();
                    txtValorLocacao.Text = jogos.ValorLocacao.ToString();
                    txtDataAquisicao.Text = jogos.DataAquisicao.ToShortDateString();
                    txtCategoriaId.Text = jogos.CategoriaId.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)//listar
        {
            try
            {
                JogosDAO jDAO = new JogosDAO();
                List<JogosViewModel> jogos = jDAO.Listar();
                foreach (JogosViewModel jogo in jogos)
                {
                    txtLista.Text += "Id: " + jogo.Id.ToString() +
                        "; Descrição: " + jogo.Descricao.ToString() +
                        "; Valor Da Locação: " + jogo.ValorLocacao.ToString() +
                        "; Data Da Aquisição: " + jogo.DataAquisicao.ToShortDateString() +
                        "; Categoria Id: " + jogo.CategoriaId.ToString() + "\r\n";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtLista.Text = "";
        }
    }
}