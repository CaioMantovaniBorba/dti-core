
namespace fabrica_de_automoveis
{
    partial class Form0001
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.miExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSobreOPrograma = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.tbAnoAutomovel = new System.Windows.Forms.TextBox();
            this.laAnoAutomovel = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnIncluir = new DevExpress.XtraEditors.SimpleButton();
            this.gridViewPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cModeloAutomovel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cAnoAutomovel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnExcluir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryExcluir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cIdAutomovel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvPrincipal = new DevExpress.XtraGrid.GridControl();
            this.tbModeloAutomovel = new System.Windows.Forms.TextBox();
            this.laModeloAutomovel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNovo,
            this.miEditar,
            this.miExcluir,
            this.toolStripMenuItem1,
            this.miSair});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // miNovo
            // 
            this.miNovo.Name = "miNovo";
            this.miNovo.Size = new System.Drawing.Size(109, 22);
            this.miNovo.Text = "&Novo";
            // 
            // miEditar
            // 
            this.miEditar.Name = "miEditar";
            this.miEditar.Size = new System.Drawing.Size(109, 22);
            this.miEditar.Text = "E&ditar";
            // 
            // miExcluir
            // 
            this.miExcluir.Name = "miExcluir";
            this.miExcluir.Size = new System.Drawing.Size(109, 22);
            this.miExcluir.Text = "&Excluir";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 6);
            // 
            // miSair
            // 
            this.miSair.Name = "miSair";
            this.miSair.Size = new System.Drawing.Size(109, 22);
            this.miSair.Text = "&Sair";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSobreOPrograma});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "A&juda";
            // 
            // miSobreOPrograma
            // 
            this.miSobreOPrograma.Name = "miSobreOPrograma";
            this.miSobreOPrograma.Size = new System.Drawing.Size(178, 22);
            this.miSobreOPrograma.Text = "&Sobre o programa...";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.tbModeloAutomovel);
            this.pnlFiltros.Controls.Add(this.laModeloAutomovel);
            this.pnlFiltros.Controls.Add(this.tbAnoAutomovel);
            this.pnlFiltros.Controls.Add(this.laAnoAutomovel);
            this.pnlFiltros.Controls.Add(this.btnPesquisar);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 24);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(800, 63);
            this.pnlFiltros.TabIndex = 8;
            // 
            // tbAnoAutomovel
            // 
            this.tbAnoAutomovel.Location = new System.Drawing.Point(207, 29);
            this.tbAnoAutomovel.Name = "tbAnoAutomovel";
            this.tbAnoAutomovel.Size = new System.Drawing.Size(185, 20);
            this.tbAnoAutomovel.TabIndex = 3;
            // 
            // laAnoAutomovel
            // 
            this.laAnoAutomovel.AutoSize = true;
            this.laAnoAutomovel.Location = new System.Drawing.Point(204, 13);
            this.laAnoAutomovel.Name = "laAnoAutomovel";
            this.laAnoAutomovel.Size = new System.Drawing.Size(93, 13);
            this.laAnoAutomovel.TabIndex = 2;
            this.laAnoAutomovel.Text = "Ano do automóvel";
            this.laAnoAutomovel.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::fabrica_de_automoveis.Properties.Resources.ic_search_black_18dp;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(409, 29);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(81, 22);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluir.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIncluir.Appearance.Image = global::fabrica_de_automoveis.Properties.Resources.ic_add_black_24dp;
            this.btnIncluir.Appearance.Options.UseBackColor = true;
            this.btnIncluir.Appearance.Options.UseImage = true;
            this.btnIncluir.BackgroundImage = global::fabrica_de_automoveis.Properties.Resources.ic_add_black_18dp;
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIncluir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnIncluir.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnIncluir.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnIncluir.Location = new System.Drawing.Point(753, 503);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(35, 36);
            this.btnIncluir.TabIndex = 10;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // gridViewPrincipal
            // 
            this.gridViewPrincipal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cIdAutomovel,
            this.cModeloAutomovel,
            this.cAnoAutomovel,
            this.btnEditar,
            this.btnExcluir});
            this.gridViewPrincipal.GridControl = this.dgvPrincipal;
            this.gridViewPrincipal.Name = "gridViewPrincipal";
            // 
            // cModeloAutomovel
            // 
            this.cModeloAutomovel.Caption = "Modelo do automóvel";
            this.cModeloAutomovel.FieldName = "modelo_automovel";
            this.cModeloAutomovel.Name = "cModeloAutomovel";
            this.cModeloAutomovel.OptionsColumn.AllowEdit = false;
            this.cModeloAutomovel.Visible = true;
            this.cModeloAutomovel.VisibleIndex = 0;
            this.cModeloAutomovel.Width = 195;
            // 
            // cAnoAutomovel
            // 
            this.cAnoAutomovel.Caption = "Ano do automóvel";
            this.cAnoAutomovel.FieldName = "ano_automovel";
            this.cAnoAutomovel.Name = "cAnoAutomovel";
            this.cAnoAutomovel.OptionsColumn.AllowEdit = false;
            this.cAnoAutomovel.Visible = true;
            this.cAnoAutomovel.VisibleIndex = 1;
            this.cAnoAutomovel.Width = 461;
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.ColumnEdit = this.repositoryEditar;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Visible = true;
            this.btnEditar.VisibleIndex = 2;
            this.btnEditar.Width = 59;
            // 
            // repositoryEditar
            // 
            this.repositoryEditar.AutoHeight = false;
            editorButtonImageOptions3.Image = global::fabrica_de_automoveis.Properties.Resources.ic_create_black_18dp;
            this.repositoryEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryEditar.Name = "repositoryEditar";
            this.repositoryEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryEditar.Click += new System.EventHandler(this.repositoryEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Caption = "Excluir";
            this.btnExcluir.ColumnEdit = this.repositoryExcluir;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Visible = true;
            this.btnExcluir.VisibleIndex = 3;
            this.btnExcluir.Width = 67;
            // 
            // repositoryExcluir
            // 
            this.repositoryExcluir.AutoHeight = false;
            editorButtonImageOptions4.Image = global::fabrica_de_automoveis.Properties.Resources.ic_remove_circle_outline_black_18dp;
            this.repositoryExcluir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryExcluir.Name = "repositoryExcluir";
            this.repositoryExcluir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryExcluir.Click += new System.EventHandler(this.repositoryExcluir_Click);
            // 
            // cIdAutomovel
            // 
            this.cIdAutomovel.Caption = "ID do Automóvel";
            this.cIdAutomovel.FieldName = "id_automovel";
            this.cIdAutomovel.Name = "cIdAutomovel";
            this.cIdAutomovel.Visible = true;
            this.cIdAutomovel.VisibleIndex = 4;
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrincipal.Location = new System.Drawing.Point(0, 87);
            this.dgvPrincipal.MainView = this.gridViewPrincipal;
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryEditar,
            this.repositoryExcluir});
            this.dgvPrincipal.Size = new System.Drawing.Size(800, 464);
            this.dgvPrincipal.TabIndex = 9;
            this.dgvPrincipal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPrincipal});
            this.dgvPrincipal.Click += new System.EventHandler(this.dgvPrincipal_Click);
            // 
            // tbModeloAutomovel
            // 
            this.tbModeloAutomovel.Location = new System.Drawing.Point(3, 29);
            this.tbModeloAutomovel.Name = "tbModeloAutomovel";
            this.tbModeloAutomovel.Size = new System.Drawing.Size(185, 20);
            this.tbModeloAutomovel.TabIndex = 5;
            // 
            // laModeloAutomovel
            // 
            this.laModeloAutomovel.AutoSize = true;
            this.laModeloAutomovel.Location = new System.Drawing.Point(0, 13);
            this.laModeloAutomovel.Name = "laModeloAutomovel";
            this.laModeloAutomovel.Size = new System.Drawing.Size(109, 13);
            this.laModeloAutomovel.TabIndex = 4;
            this.laModeloAutomovel.Text = "Modelo do automóvel";
            this.laModeloAutomovel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form0001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvPrincipal);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form0001";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DTIFormPadrao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNovo;
        private System.Windows.Forms.ToolStripMenuItem miEditar;
        private System.Windows.Forms.ToolStripMenuItem miExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miSair;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFiltros;
        private DevExpress.XtraEditors.SimpleButton btnIncluir;
        private System.Windows.Forms.Button btnPesquisar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPrincipal;
        private DevExpress.XtraGrid.GridControl dgvPrincipal;
        private System.Windows.Forms.TextBox tbAnoAutomovel;
        private System.Windows.Forms.Label laAnoAutomovel;
        private System.Windows.Forms.ToolStripMenuItem miSobreOPrograma;
        private DevExpress.XtraGrid.Columns.GridColumn cModeloAutomovel;
        private DevExpress.XtraGrid.Columns.GridColumn cAnoAutomovel;
        private DevExpress.XtraGrid.Columns.GridColumn btnEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryEditar;
        private DevExpress.XtraGrid.Columns.GridColumn btnExcluir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryExcluir;
        private DevExpress.XtraGrid.Columns.GridColumn cIdAutomovel;
        private System.Windows.Forms.TextBox tbModeloAutomovel;
        private System.Windows.Forms.Label laModeloAutomovel;
    }
}

