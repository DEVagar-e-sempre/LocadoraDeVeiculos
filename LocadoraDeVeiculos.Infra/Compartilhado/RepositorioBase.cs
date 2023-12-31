﻿using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Infra.Compartilhado
{
    public abstract class RepositorioBase<T>: IRepositorioBase<T> where T : EntidadeBase<T>
    {
        protected readonly LocadoraDeVeiculosDbContext dbContext;

        protected DbSet<T> registros;

        public RepositorioBase(LocadoraDeVeiculosDbContext dbContext)
        {
            this.dbContext = dbContext;

            registros = dbContext.Set<T>();
        }

        public void Inserir(T novoRegistro)
        {
            registros.Add(novoRegistro);         
        }

        public void Editar(T registro)
        {
            registros.Update(registro);         
        }

        public void Excluir(T registro)
        {
            registros.Remove(registro);          
        }

        public bool Existe(T registro)
        {
            return registros.Contains(registro);
        }

        public virtual T SelecionarPorId(Guid id)
        {
            return registros.SingleOrDefault(t=>t.Id == id);
        }

        public virtual List<T> SelecionarTodos()
        {
            return registros.ToList();
        }
            
    }
}
