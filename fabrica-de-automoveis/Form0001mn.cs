using DTIForms.Util;
using NTIComponentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using fabrica_de_automoveis.DAO;
using fabrica_de_automoveis.Domain;

namespace fabrica_de_automoveis
{
    public partial class Form0001mn : NTIForm
    {
        private string _OPERACAO;
        private FabricaAutomoveis _Dominio;

        public Form0001mn(FabricaAutomoveis dominio, string operacao)
        {
            InitializeComponent();
            configuraForm();
            _OPERACAO = operacao;
            _Dominio = dominio;
        }

        private void AtualizaTela()
        {
            //esta rotina pega os dados do objeto e joga na tela para o usuario visualizar. Tem que ser chamada quando é alteração
            /***
             * Exemplo:
             * tbNome.Text = _Dominio.Nom_Convenio;
             * */

            tbModeloAutomovel.Text = _Dominio.modelo_automovel;
            tbAnoAutomovel.Text = _Dominio.ano_automovel.ToString();
        }

        private void AtualizarObjeto()
        {
            /*Esta rotina pega os dados da tela e alimenta o objeto.Tem que ser chamada antes da alteração e inclusao.
             * Exemplo:
             * _Dominio.Nom_Convenio = tbNome.Text;
             * */

            if (_Dominio == null)
            {
                _Dominio = new FabricaAutomoveis();
            }

            _Dominio.modelo_automovel = tbModeloAutomovel.Text;
            _Dominio.ano_automovel = Convert.ToInt32(tbAnoAutomovel.Text);

        }

        private void LimparTela()
        {
            /*Rotina deve ser chamado quando clicado no Gravar e continuar, para limpar a tela e inserir novo*/

            tbAnoAutomovel.Clear();
            tbModeloAutomovel.Clear();

        }

        private void DTIFormManutencao_Load(object sender, EventArgs e)
        {
            if (_OPERACAO == "a")
            {
                AtualizaTela();
            }

        }

        private string Gravar()
        {
            
            if (_OPERACAO == "a")
            {
                var dao = new FabricaAutomoveisDAO();
                return dao.update(_Dominio);
            }
            else if (_OPERACAO == "i") 
            {
                var dao = new FabricaAutomoveisDAO();
                return dao.insert(_Dominio);
            }
            
            return null;

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            
            AtualizarObjeto();

            if (!DTIFormsUtil.ValidarDominio(_Dominio))
                return;

            if (!DTIFormsUtil.TratarRetornoPersistencia(Gravar()))
                return;

            if (sender == btnGravar)
                Close();
            else if (sender == btnGravarContinuar) 
            {
                LimparTela();
                tbModeloAutomovel.Focus();
            }
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbNomConvnio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
