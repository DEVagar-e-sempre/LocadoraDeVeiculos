
using LocadoraDeVeiculos.WinApp.ModuloAluguel;

namespace LocadoraDeVeiculos.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        public static TelaPrincipalForm Instancia { get; private set; } = null!;

        private ControladorBase controlador = null!;

        public TelaPrincipalForm()
        {
            InitializeComponent();

            Ioc.Inicializar = true;

            Instancia = this;
        }

        #region "atualizarRodape"
        public void AtualizarRodape(string msg)
        {
            labelRodape.Text = msg;

        }

        public void AtualizarRodape()
        {
            string mensagemRodape = controlador.ObterMensagemRodape();

            AtualizarRodape(mensagemRodape);
        }
        #endregion

        #region "configuracoes"
        private void ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            this.controlador = controlador;

            ConfigurarToolbox();

            ConfigurarListagem();

            string mensagemRodape = controlador.ObterMensagemRodape();

            AtualizarRodape(mensagemRodape);
        }

        private void ConfigurarToolbox()
        {
            ConfiguracaoToolboxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                txtMenu.Enabled = true;

                labelTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            panelRegistros.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(listagemControl);
        }

        private void ConfigurarTooltips(ConfiguracaoToolboxBase configuracao)
        {
            BtnInserir.ToolTipText = configuracao.TooltipInserir;
            BtnEditar.ToolTipText = configuracao.TooltipEditar;
            BtnExcluir.ToolTipText = configuracao.TooltipExcluir;
            BtnFiltrar.ToolTipText = configuracao.TooltipFiltrar;
            BtnDetalhes.ToolTipText = configuracao.TooltipVisualizar;
            btnPrecoCombustivel.ToolTipText = configuracao.TooltipPrecoCombustivel;
        }

        private void ConfigurarBotoes(ConfiguracaoToolboxBase configuracao)
        {
            BtnInserir.Enabled = configuracao.InserirHabilitado;
            BtnEditar.Enabled = configuracao.EditarHabilitado;
            BtnExcluir.Enabled = configuracao.ExcluirHabilitado;
            BtnFiltrar.Enabled = configuracao.FiltrarHabilitado;
            BtnDetalhes.Enabled = configuracao.VisualizarHabilitado;
            btnPrecoCombustivel.Enabled = configuracao.PrecoCombustivelHabilitado;
        }
        #endregion

        #region click - op��es de opera��o
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            controlador.Filtrar();
        }

        private void BtnDetalhes_Click(object sender, EventArgs e)
        {
            controlador.Visualizar();
        }

        private void BtnPrecoCombustivel_Click(object sender, EventArgs e)
        {
            if (controlador is ControladorAluguel control)
                control.ConfigurarPrecoCombustivel();

        }

        #endregion

        #region click - escolha dos menus

        private void ParceiroMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(Ioc.ObterControlador(sender));
        }

        private void CategoriaMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(Ioc.ObterControlador(sender));
        }

        private void CupomMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(Ioc.ObterControlador(sender));
        }

        private void VeiculoMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(Ioc.ObterControlador(sender));
        }

        private void TaxaServicoMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(Ioc.ObterControlador(sender));
        }

        private void ClienteMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(Ioc.ObterControlador(sender));
        }
        private void FuncionarioMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(Ioc.ObterControlador(sender));
        }

        private void condutorMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(Ioc.ObterControlador(sender));
        }

        private void AluguelMenuItem_Click(object sender, EventArgs e)
        {
            var control = (ControladorAluguel)Ioc.ObterControlador(sender);

            controlador = control;

            control.ConfigurarPrecoCombustivel();

            // ConfigurarTelaPrincipal();
        }

        #endregion

        #region mudar cor click
        private void BtnMudarCor_Click(object sender, EventArgs e)
        {
            var cores = Enum.GetValues<KnownColor>().ToArray();

            var cor = cores[new Random().Next(1, 167)];

            toolStrip.BackColor = Color.FromKnownColor(cor);

        }

        #endregion

    }
}