﻿namespace LocadoraDeVeiculos.Dominio.Compartilhado
{
    public interface IRepositorioBase<T> where T: EntidadeBase<T>
    {
        void Inserir(T novoRegistro);

        void Editar(T registro);

        void Excluir(T registro);

        bool  Existe(T registro);

        List<T> SelecionarTodos();

        T SelecionarPorId(Guid id);
           
    }
}
