using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LojaVirtual.Dominio.Entidades;
using LojaVirtual.Dominio.Interfaces.Repositorios;
using LojaVirtual.Infra.Data.Dapper.Common;
using Dapper;

namespace LojaVirtual.Infra.Data.Dapper.Repositorios
{
    public class RepositorioCategorias : SqlConnectionBase, IRepositorioCategorias
    {
        public void Add(Categorias categoria)
        {
            using (var conn = CreateConnection)
            {
                string sqlQuery = "INSERT INTO[dbo].[Categorias]([NomeCategoria],[Descricao],[Imagem]) VALUES(@NomeCategoria, @Descricao, @Imagem)";
                conn.Execute(sqlQuery,
                    new
                    {
                        NomeCategoria = categoria.NomeCategoria,
                        Descricao = categoria.Descricao,
                        Imagem = categoria.Imagem,
                    });
            }
        }

        public IEnumerable<Categorias> Find(Expression<Func<Categorias, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categorias> GetAll()
        {
            using (var conn = CreateConnection)
            {
                return conn.Query<Categorias>("Select * from Categorias");
            }
        }

        public Categorias GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Categorias obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Categorias obj)
        {
            throw new NotImplementedException();
        }
    }
}
