﻿using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoDeCobranca;
using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;
using LocadoraDeVeiculos.Servico.ModuloAluguel;
using LocadoraDeVeiculos.Servico.ModuloAutomovel;
using LocadoraDeVeiculos.Servico.ModuloCondutor;
using LocadoraDeVeiculos.WinApp.ModuloConfiguracaoPreco;

namespace LocadoraDeVeiculos.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private readonly IRepositorioAluguel repositorioAluguel;

        private readonly ServicoAluguel servicoAluguel;

        private readonly ServicoAutomovel servicoAutomovel;

        private readonly ServicoCondutor servicoCondutor;

        private readonly IRepositorioFuncionario repositorioFuncionario;

        private readonly IRepositorioCliente repositorioCliente;

        private readonly IRepositorioCondutor repositorioCondutor;

        private readonly IRepositorioGrupoAutomovel repositorioGrupoAutomovel;

        private readonly IRepositorioAutomovel repositorioAutomovel;

        private readonly IRepositorioTaxaServico repositorioTaxaServico;

        private readonly IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca;

        private readonly IRepositorioCupom repositorioCupom;

        private TabelaAluguelUserControl tabelaAluguel;
        
        public ControladorAluguel(ServicoAluguel servicoAluguel,
                                  ServicoAutomovel servicoAutomovel,
                                  ServicoCondutor servicoCondutor,
                                  IRepositorioAluguel repositorioAluguel, 
                                  IRepositorioFuncionario repositorioFuncionario,
                                  IRepositorioCliente repositorioCliente,
                                  IRepositorioCondutor repositorioCondutor,
                                  IRepositorioGrupoAutomovel repositorioGrupoAutomovel,
                                  IRepositorioAutomovel repositorioAutomovel,
                                  IRepositorioTaxaServico repositorioTaxaServico,
                                  IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca,
                                  IRepositorioCupom repositorioCupom
                                    )
        {
            this.servicoAluguel = servicoAluguel;
            this.servicoAutomovel = servicoAutomovel;
            this.servicoCondutor = servicoCondutor;
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioFuncionario = repositorioFuncionario;
            this.repositorioCliente = repositorioCliente;
            this.repositorioCondutor = repositorioCondutor;
            this.repositorioGrupoAutomovel = repositorioGrupoAutomovel;
            this.repositorioAutomovel = repositorioAutomovel;
            this.repositorioTaxaServico = repositorioTaxaServico;
            this.repositorioPlanoDeCobranca = repositorioPlanoDeCobranca;
            this.repositorioCupom = repositorioCupom;
         
        }

        private void EnviarMensagemEmailEnviado(string msg, bool finalizar)
        {
            MessageBox.Show(msg,
                                $"{(finalizar ? "Finalizar":"Cadastro")} Aluguel",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
        }

        public override void Editar()
        {       
            Guid guidAluguel = tabelaAluguel.ObterIdSelecionado();

            if (guidAluguel == default(Guid))
            {
                MessageBox.Show($"Selecione um Aluguel para poder editar!",
                                 "Edição de Aluguel",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation);
                return;
            }

            Aluguel aluguelSelecionado = repositorioAluguel.SelecionarPorId(guidAluguel);

            if (aluguelSelecionado.DataLocacao.Date <= DateTime.Now.Date)
            {
                MessageBox.Show($"Não é possível editar um aluguel em andamento",
                                 "Edição de Aluguel",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation);
                return;
            }

            TelaAluguelForm telaAluguel = new TelaAluguelForm()
            {
                Text = "Editar Aluguel",
            };

            telaAluguel.onGravarRegistro += servicoAluguel.Editar;

            telaAluguel.onCalcularValorTotal += servicoAluguel.CalcularValor;

            ConfigurarDelegates(telaAluguel);

            telaAluguel.ConfigurarRegistro(aluguelSelecionado);

            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                AtualizarListagem();
            }
        }

        public override void Excluir()
        {
            Guid guidAluguel = tabelaAluguel.ObterIdSelecionado();

            if (guidAluguel == default(Guid))
            {
                MessageBox.Show($"Selecione um Aluguel para poder excluir!",
                                 "Exclusão de Aluguel",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation);
                return;
            }


            Aluguel aluguelSelecionado = repositorioAluguel.SelecionarPorId(guidAluguel);

            if (aluguelSelecionado.DataLocacao.Date <= DateTime.Now.Date && aluguelSelecionado.DataDevolucao == default(DateTime))
            {
                MessageBox.Show($"Não é possível excluir um aluguel em andamento",
                                 "Exclusão de Aluguel",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Tem certeza que deseja excluir o Aluguel?",
                                                            "Exclusão de Aluguel",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Question);
            if (opcaoEscolhida == DialogResult.Yes)
            {
                Result resultado = servicoAluguel.Excluir(aluguelSelecionado);

                if (resultado.IsFailed)
                {
                    string[] erros = resultado.Errors.Select(e => e.Message).ToArray();

                    TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                    return;
                }

                AtualizarListagem();
            }
        }

        public override void Inserir()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm()
            {
                Text = "Inserir Aluguel",
            };
         
            telaAluguel.onGravarRegistro += servicoAluguel.Inserir;

            telaAluguel.onCalcularValorTotal += servicoAluguel.CalcularValor;

            ConfigurarDelegates(telaAluguel);

            telaAluguel.onSelecionarAutomovelPorGrupoAutomovel += servicoAutomovel.SelecionarAutomoveisDisponives;

            telaAluguel.onSelecionarCondutorPorCliente += servicoCondutor.SelecionarCondutoresDisponives;

            telaAluguel.ConfigurarRegistro(new Aluguel());

            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                EnviarMensagemEmailEnviado("Email enviado com sucesso", finalizar:false);

                AtualizarListagem();
            }
        }

        public void DevolverAutomovel()
        {
            Guid guidAluguel = tabelaAluguel.ObterIdSelecionado();

            if (guidAluguel == default(Guid))
            {
                MessageBox.Show($"Selecione um Aluguel para poder Devolver!",
                                 "Devolução de Aluguel",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation);
                return;
            }

            Aluguel aluguelSelecionado = repositorioAluguel.SelecionarPorId(guidAluguel);

            if (aluguelSelecionado.EstaAberto == false)
            {
                MessageBox.Show($"Não é possível devolver um aluguel concluído",
                                 "Devolução de Aluguel",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation);
                return;
            }

            if (aluguelSelecionado.DataLocacao.Date > DateTime.Now.Date)
            {
                MessageBox.Show($"Não é possível devolver um aluguel ainda não iniciado",
                                 "Devolução de Aluguel",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation);
                return;
            }

            TelaAluguelForm telaAluguel = new TelaAluguelForm()
            {
                Text = "Devolução de Aluguel",
            };

            telaAluguel.onGravarRegistro += servicoAluguel.Editar;

            telaAluguel.onCalcularValorTotal += servicoAluguel.CalcularValor;

            ConfigurarDelegates(telaAluguel);

            telaAluguel.ConfigurarDevolucao(aluguelSelecionado);

            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                EnviarMensagemEmailEnviado("Email enviado com sucesso", finalizar : true);

                AtualizarListagem();
            }
        }

        public void ConfigurarPrecoCombustivel()
        {
            var configuracao = servicoAluguel.ObterConfiguracoesAtuais();

            var tela = new TelaPrecoCombustivelForm(configuracao);

            tela.onGravarConfiguracao += servicoAluguel.ConfigurarPrecoCombustiveis;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Atualização de preços de combustível efetuada com sucesso.", "Configurar Preço", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxAluguel();
        }

        public override UserControl ObtemListagem()
        {
            tabelaAluguel ??= new TabelaAluguelUserControl();

            AtualizarListagem();

            return tabelaAluguel;
        }
        private void AtualizarListagem()
        {
            var registros = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(registros);

            AtualizarRodape(registros);
        }

        private void ConfigurarDelegates(TelaAluguelForm telaAluguel)
        {
            telaAluguel.onSelecionarTodosFuncionarios += repositorioFuncionario.SelecionarTodos;

            telaAluguel.onSelecionarTodosClientes += repositorioCliente.SelecionarTodos;

            telaAluguel.onSelecionarCondutorPorCliente += repositorioCondutor.SelecionarPorCliente;

            telaAluguel.onSelecionarTodosGrupoAutomovel += repositorioGrupoAutomovel.SelecionarTodos;

            telaAluguel.onSelecionarAutomovelPorGrupoAutomovel += repositorioAutomovel.SelecionarPorGrupoAutomovel;
         
            telaAluguel.onSelecionarTodosPlanoDeCobrancaPorGrupoAutomovel += repositorioPlanoDeCobranca.SelecionarPlanoDeCobrancaPorGrupoAutomovel;

            telaAluguel.onSelecionarTodosClientes += repositorioCliente.SelecionarTodos; 

            telaAluguel.onSelecionarCondutorPorCliente += repositorioCondutor.SelecionarPorCliente; 

            telaAluguel.onSelecionarCupomPorNome += repositorioCupom.SelecionarPorNome;

            telaAluguel.onSelecionarTodosTaxaServico += repositorioTaxaServico.SelecionarTodos;

        }
     
        private void AtualizarRodape(List<Aluguel> registros)
        {
            mensagemRodape = $"Visualizando {registros.Count} Aluguéis";

            TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }
    }
}
