using DeskUtilDLL;
using DTIForms.Util;
using fabrica_de_automoveis.DAO;
using fabrica_de_automoveis.Domain;
using NTIComponentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilDLL;

namespace fabrica_de_automoveis
{
    public partial class Form0001 : NTIForm
    {
        #region INICIALIZACAO
        public Form0001()
        {
            InitializeComponent();
            configuraForm();
        }
        private void DTIFormPadrao_Load(object sender, EventArgs e)
        {
            Consultar();
        }
        #endregion

        #region METODOS
        private void Consultar()
        {
            var filtros = new NTIFiltro();

            if (!String.IsNullOrEmpty(tbModeloAutomovel.Text))
                filtros.adiciona("MODELO_AUTOMOVEL", 
                                 tbModeloAutomovel.Text,
                                 typeof(string),
                                 NTIFiltro._permuta);

            if (!String.IsNullOrEmpty(tbAnoAutomovel.Text))
                filtros.adiciona("ANO_AUTOMOVEL",
                                 Convert.ToInt32(tbAnoAutomovel.Text),
                                 typeof(int),
                                 NTIFiltro._igual);

            dgvPrincipal.DataSource = new FabricaAutomoveisDAO().Listar(filtros);
            dgvPrincipal.Refresh();
        }

        private void Incluir()
        {
            var Manutencao = new Form0001mn(null, "i");
            Manutencao.ShowDialog();
            Consultar();
        }

        private void Editar()
        {
            var lista = dgvPrincipal.DataSource as List<FabricaAutomoveisDTO>;

            int indiceSelecionado = gridViewPrincipal.GetDataSourceRowIndex(gridViewPrincipal.FocusedRowHandle);

            var automovelselecionado = lista[indiceSelecionado];

            var automovel = new FabricaAutomoveisDAO().Get(automovelselecionado.id_automovel);

            var form = new Form0001mn(automovel, "a");
            form.ShowDialog();

            Consultar();
        }

        private void Excluir()
        {
            if (!DeskUtil.getResposta("Deseja realmente excluir?"))
                return;

            var lista = dgvPrincipal.DataSource as List<FabricaAutomoveisDTO>;

            int indiceSelecionado = gridViewPrincipal.GetDataSourceRowIndex(gridViewPrincipal.FocusedRowHandle);

            var automovelselecionado = lista[indiceSelecionado];

            var automovel = new FabricaAutomoveisDAO().Get(automovelselecionado.id_automovel);

            if (DTIFormsUtil.TratarRetornoPersistencia(new FabricaAutomoveisDAO().delete(automovel)))
                Consultar();
        }

        private void SobreOPrograma()
        {
            DeskUtil.mostrarMensagemInformativa("Este programa tem por objetivo o cadastro de automóveis", "Informação");
        }

        private void MenuClick(object sender, EventArgs e)
        {
            if (sender == miEditar)
                Editar();
            else if (sender == miNovo)
                Incluir();
            else if (sender == miExcluir)
                Excluir();
            else if (sender == miSobreOPrograma)
                SobreOPrograma();
            else if (sender == miSair)
                Close();
        }

        #endregion

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void repositoryEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void repositoryExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPrincipal_Click(object sender, EventArgs e)
        {
            
        }
    }
}
