﻿using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.Dominio.ModuloAutomovel
{
    public class Automovel : EntidadeBase<Automovel>
    {
        public int Quilometragem { get; set; }

        public string Placa { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        public string Cor { get; set; }

        public TipoCombustivelEnum Combustivel { get; set; }

        public GrupoAutomovel GrupoAutomovel { get; set; }

        public ImagemVeiculo Foto { get; set; }

        public int CapacidadeDeCombustivel { get; set; }

        public Automovel() { }
       

        public int Abastecer(int quantidadeAtual)
        {
            return CapacidadeDeCombustivel - quantidadeAtual;
        }

        public void AtualizarQuilometragem(int quilometragemPercorrida)
        {       
            Quilometragem += quilometragemPercorrida;
        }

        public void IncluirFoto(byte[] imagemBytes)
        {
            Foto = new ImagemVeiculo(imagemBytes);
        }

        public void EditarFoto(byte[] imagemBytes)
        {
            Foto.ImagemBytes = imagemBytes;
        }

        public override void AlterarInformacoes(Automovel entidade)
        {

            Quilometragem = entidade.Quilometragem;
            Placa = entidade.Placa;
            Marca = entidade.Marca;
            Modelo = entidade.Modelo;
            Ano = entidade.Ano;
            Combustivel = entidade.Combustivel;
            CapacidadeDeCombustivel = entidade.CapacidadeDeCombustivel;
            Foto = entidade.Foto;
        }

        public override bool Equals(object? obj)
        {
            return obj is Automovel automovel &&
                   Id.Equals(automovel.Id) &&
                   Quilometragem == automovel.Quilometragem &&
                   Placa == automovel.Placa &&
                   Marca == automovel.Marca &&
                   Modelo == automovel.Modelo &&
                   Ano == automovel.Ano &&
                   Combustivel == automovel.Combustivel &&
                   CapacidadeDeCombustivel == automovel.CapacidadeDeCombustivel &&
                   Foto == automovel.Foto;
        }
    }
}