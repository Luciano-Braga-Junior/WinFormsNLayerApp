using Dapper;
using Database.Conexões;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    public class ProdutoRepository
    {
        public List<Produto> ObterRelatorioEstoque()
        {
            var sql = @"SELECT p.IDProduto AS Codigo, 
	                   p.NomeProduto AS Nome,
	                   p.PrecoUnitario AS Preco,
	                   p.UnidadesEmEstoque AS Estoque,
	                   c.NomeCategoria AS Categoria
                FROM Produtos p
                INNER JOIN Categorias c
                ON p.IDCategoria = c.IDCategoria
                WHERE p.UnidadesEmEstoque > 0";
            try
            {
                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    var resultado = connection.Query<Produto>(sql);
                    return resultado.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
