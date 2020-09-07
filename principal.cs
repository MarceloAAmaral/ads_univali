using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inscricaoEventodeCorrida
{
    public partial class CadastrarEvento : Form
    {
        public CadastrarEvento()
        {
            InitializeComponent();
        }
        // ação de chamada do formulário Cadastro de Evento
        private void btn_cadastrarEvento_Click(object sender, EventArgs e)
        {
            form_cadastrarEvento cadastrar_Evento = new form_cadastrarEvento();
            cadastrar_Evento.ShowDialog();
        }
        // ação de chamada do formulário Cadastro de Atletas
        private void btn_cadastrarAtleta_Click(object sender, EventArgs e)
        {
            form_cadastrarAtleta form_CadastrarAtleta = new form_cadastrarAtleta();
            form_CadastrarAtleta.ShowDialog();
        }
        // ação de chamada do formulário Realizar Inscrição
        private void btn_realizarInscricao_Click(object sender, EventArgs e)
        {
            form_realizarInscricao form_RealizarInscricao = new form_realizarInscricao();
            form_RealizarInscricao.ShowDialog();

         }
        // ação de chamada do formulário Excluir Evento
        private void btn_excluirEvento_Click(object sender, EventArgs e)
        {
            form_excluirEvento form_excluirEvento = new form_excluirEvento();
            form_excluirEvento.ShowDialog();
        }
       
       
        // ação de chamada do formulário Excluir Inscrição
       
        // ação de chamada do formulário Listar Inscritos
        private void btn_listarInscritos_Click(object sender, EventArgs e)
        {
            form_listarInscritos form_listarInscritos = new form_listarInscritos();
            form_listarInscritos.ShowDialog();
        }

        private void btn_listarAtletas_Click(object sender, EventArgs e)
        {
            form_listarAtleta form_listarAtletas = new form_listarAtleta();
            form_listarAtletas.ShowDialog();        
        }
        // ação de chamada do formulário Excluir Inscrição
        private void btn_excluirInscricao_Click(object sender, EventArgs e)
        {
            form_excluirInscricao form_excluirInscricao = new form_excluirInscricao();
            form_excluirInscricao.ShowDialog();

        }
        // ação de chamada do formulário Excluir Atleta
        private void btn_excluirAtleta_Click(object sender, EventArgs e)
        {
            form_excluirAtleta form_excluirAtleta = new form_excluirAtleta();
            form_excluirAtleta.ShowDialog();
        }
        // ação de chamada do formulário Listagem Eventos
        private void btn_listarEventos_Click(object sender, EventArgs e)
        {
            form_listarEventos form_listarEventos = new form_listarEventos();
            form_listarEventos.ShowDialog();
        }

    }
}
