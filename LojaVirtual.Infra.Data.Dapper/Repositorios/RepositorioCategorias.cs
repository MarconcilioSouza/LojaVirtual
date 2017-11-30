using System.Collections.Generic;
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
                string sqlQuery = "INSERT INTO[dbo].[Categorias]([NomeCategoria],[Descricao],[Imagem]) " +
                    "VALUES(@NomeCategoria, @Descricao, @Imagem)";

                conn.Execute(sqlQuery,
                    new
                    {
                        NomeCategoria = categoria.NomeCategoria,
                        Descricao = categoria.Descricao,
                        Imagem = categoria.Imagem,
                    });
            }
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
            using (var conn = CreateConnection)
            {
                return conn.QueryFirstOrDefault<Categorias>("Select * from Categorias where IdCategoria = @IdCategoria", new { IdCategoria = id });
            }
        }

        public void Remove(int id)
        {
            var categoria = GetById(id);
            Remove(categoria);
        }

        public void Remove(Categorias obj)
        {
            using (var conn = CreateConnection)
            {
                conn.Execute("Delete from Categorias where IdCategoria = @IdCategoria", new { IdCategoria = obj.IdCategoria });
            }
        }

        public void Update(Categorias obj)
        {
            using (var conn = CreateConnection)
            {
                conn.Execute("Update Categorias set NomeCategoria = @NomeCategoria, " +
                    " Descricao = @Descricao, Imagem = @Imagem where IdCategoria = @IdCategoria",
                            new
                            {
                                IdCategoria = obj.IdCategoria,
                                NomeCategoria = obj.NomeCategoria,
                                Descricao = obj.Descricao,
                                Imagem = obj.Imagem,
                            });
            }
        }
    }
}
