﻿using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoDeCobranca;

namespace LocadoraDeVeiculos.WinApp.ModuloPlanoDeCobranca
{
    public partial class TelaPlanoDeCobrancaForm : Form
    {
        public event GravarRegistroDelegate<PlanoDeCobranca> onGravarRegistro;
        private PlanoDeCobranca plano;
        private IRepositorioGrupoAutomovel repGpAuto;

        public TelaPlanoDeCobrancaForm(IRepositorioGrupoAutomovel repGpAuto)
        {
            InitializeComponent();

            txb_kmDisponivel.Enabled = false;
            txb_precoD.Enabled = false;
            txb_precoKm.Enabled = false;
            this.repGpAuto = repGpAuto;

            cbox_gpAutomoveis.DropDownStyle = ComboBoxStyle.DropDownList;

            txb_kmDisponivel.Text = Convert.ToString(0);
            txb_precoD.Text = Convert.ToString(0);
            txb_precoKm.Text = Convert.ToString(0);

            this.ConfigurarDialog();

            AlimentarCBOXGpAuto(repGpAuto);

            AlimentarCBOXTipoPlano();
        }

        private void AlimentarCBOXGpAuto(IRepositorioGrupoAutomovel repGpAuto)
        {
            foreach (GrupoAutomovel grupo in repGpAuto.SelecionarTodos())
            {
                cbox_gpAutomoveis.Items.Add(grupo);
            }
        }

        private void AlimentarCBOXTipoPlano()
        {
            foreach (TipoPlanoEnum tipo in Enum.GetValues(typeof(TipoPlanoEnum)))
            {
                cbox_tipoPlano.Items.Add(tipo);
            }
        }

        private void cbox_tipoPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbox_tipoPlano.SelectedItem)
            {
                case TipoPlanoEnum.Diario:
                    txb_kmDisponivel.Enabled = false;
                    txb_kmDisponivel.Text = Convert.ToString(0);

                    txb_precoD.Enabled = true;

                    txb_precoKm.Enabled = true;
                    break;

                case TipoPlanoEnum.Livre:
                    txb_precoD.Enabled = true;

                    txb_kmDisponivel.Enabled = false;
                    txb_kmDisponivel.Text = Convert.ToString(0);

                    txb_precoKm.Enabled = false;
                    txb_precoKm.Text = Convert.ToString(0);
                    break;

                case TipoPlanoEnum.Controlado:
                    txb_kmDisponivel.Enabled = true;
                    txb_precoD.Enabled = true;
                    txb_precoKm.Enabled = true;
                    break;
            }
        }

        public void ConfigurarPlano(PlanoDeCobranca plano)
        {
            txb_precoKm.Text = plano.PrecoKm.ToString();
            txb_precoD.Text = plano.PrecoDiaria.ToString();
            txb_kmDisponivel.Text = plano.KmDisponivel.ToString();

            foreach (GrupoAutomovel grupo in repGpAuto.SelecionarTodos())
            {
                if (plano.GrupoAutomovel != null)
                {
                    if (grupo.Id == plano.GrupoAutomovel.Id)
                    {
                        cbox_gpAutomoveis.SelectedItem = grupo;
                    }
                }
            }

            foreach (TipoPlanoEnum tipo in cbox_tipoPlano.Items)
            {
                if (tipo == plano.TipoPlano)
                {
                    cbox_tipoPlano.SelectedItem = tipo;
                }
            }

            this.plano = plano;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.plano.PrecoKm = Convert.ToDecimal(txb_precoKm.Text);
            this.plano.PrecoDiaria = Convert.ToDecimal(txb_precoD.Text);
            this.plano.KmDisponivel = Convert.ToInt32(txb_kmDisponivel.Text);
            this.plano.GrupoAutomovel = (GrupoAutomovel)cbox_gpAutomoveis.SelectedItem;
            this.plano.TipoPlano = (TipoPlanoEnum)cbox_tipoPlano.SelectedItem;

            Result resultado = onGravarRegistro(plano);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
