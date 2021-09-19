using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Interface.Repositorio.Base
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Excluir(TEntity entity);
    }
}