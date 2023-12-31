﻿using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;


namespace LocadoraDeVeiculos.TestesUnitarios._2___Dominio.ModuloAutomovel
{

    [TestClass]
    public class AutomovelTestesUnitarios
    {
        Automovel automovel;
        public AutomovelTestesUnitarios()
        {
             automovel = new Automovel();
        }


        [TestMethod]
        public void Deve_calcular_total_de_litros_abastecidos()
        {
            automovel.CapacidadeDeCombustivel = 55;

            NivelCombustivelEnum nivel = NivelCombustivelEnum.Um_Quarto;

            var litrosAbastecidos = automovel.ObterLitrosAbastecidos(nivel);

            litrosAbastecidos.Should().Be(41.25M);

        }

        [TestMethod]
        public void Deve_retornar_13_75_se_o_tanque_chegar_com_tres_quartos()
        {
            automovel.CapacidadeDeCombustivel = 55;

            NivelCombustivelEnum nivel = NivelCombustivelEnum.Tres_Quartos;

            var litrosAbastecidos = automovel.ObterLitrosAbastecidos(nivel);

            litrosAbastecidos.Should().Be(13.75M);
        }

        [TestMethod]
        public void Deve_retornar_zero_se_tanque_estiver_cheio()
        {
            automovel.CapacidadeDeCombustivel = 55;

            NivelCombustivelEnum nivel = NivelCombustivelEnum.Cheio;

            var litrosAbastecidos = automovel.ObterLitrosAbastecidos(nivel);

            litrosAbastecidos.Should().Be(0);
        }

        [TestMethod]
        public void Deve_retornar_valor_igual_capacidade_do_tanque_se_tanque_estiver_vazio()
        {
            automovel.CapacidadeDeCombustivel = 55;

            NivelCombustivelEnum nivel = NivelCombustivelEnum.Vazio;

            var litrosAbastecidos = automovel.ObterLitrosAbastecidos(nivel);

            litrosAbastecidos.Should().Be(automovel.CapacidadeDeCombustivel);
        }


        [TestMethod]
        public void Deve_atualizar_quilometragem()
        {         
            automovel.Quilometragem = 15000;

            var kmPercorrido = 1800;

            automovel.AtualizarQuilometragem(kmPercorrido);

            automovel.Quilometragem.Should().Be(16800);
        }

        [TestMethod]
        public void Deve_enviar_excessao_se_km_informado_menor_que_zero()
        {
            automovel.Quilometragem = 15000;

            var kmPercorrido = -180;

           Action act = () => automovel.AtualizarQuilometragem(kmPercorrido);

            act.Should().Throw<Exception>()
                .WithMessage("A quilometragem percorrida não pode ser menor que zero.");
        }

      

    }
}
