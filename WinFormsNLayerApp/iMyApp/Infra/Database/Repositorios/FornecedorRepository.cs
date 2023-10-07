using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    internal class FornecedorRepository : IFornecedorRepository
    {
        public List<Fornecedor> ObterTodos()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            // Preencha a lista de fornecedores com dados fictícios
            for (int i = 1; i <= 50; i++)
            {
                fornecedores.Add(new Fornecedor
                {
                    Id = i,
                    Nome = $"Fornecedor {i}",
                    Telefone = $"(00) 1234-567{i:00}",
                    Uf = "SP", // Unidade Federativa fictícia
                    Cidade = $"Cidade {i}"
                });
            }

            return fornecedores;
        }

        static void Main()
        {
            FornecedorRepository repository = new FornecedorRepository();
            List<Fornecedor> fornecedores = repository.ObterTodos();

            // Exemplo de como acessar e imprimir as informações dos fornecedores
            foreach (var fornecedor in fornecedores)
            {
                Console.WriteLine($"ID: {fornecedor.Id}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"Telefone: {fornecedor.Telefone}");
                Console.WriteLine($"UF: {fornecedor.Uf}");
                Console.WriteLine($"Cidade: {fornecedor.Cidade}");
                Console.WriteLine();
            }
        }
    }
}
