using Negocio.Entidades;

namespace Database.Repositorios
{
    public interface IFornecedorRepository
    {
        List<Fornecedor> ObterTodos();
    }
}