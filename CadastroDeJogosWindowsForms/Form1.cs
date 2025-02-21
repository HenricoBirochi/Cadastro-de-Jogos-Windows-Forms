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
                JogosViewModel jogo = new JogosViewModel(int.Parse(Id.Text), Descricao.Text, double.Parse(ValorLocacao.Text),
                    DateTimeOffset.Parse(DataAquisicao.Text), int.Parse(CategoriaId.Text));
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
                JogosViewModel jogo = new JogosViewModel(int.Parse(Id.Text), Descricao.Text, double.Parse(ValorLocacao.Text),
                    DateTimeOffset.Parse(DataAquisicao.Text), int.Parse(CategoriaId.Text));
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
                    jDAO.Delete(int.Parse(Id.Text));
                    MessageBox.Show("Excluido com sucesso");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}