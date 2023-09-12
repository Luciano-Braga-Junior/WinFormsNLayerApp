namespace Negocio.Entidades.Comum
{
    public abstract class Pessoa : EntidadeBase
    {        
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
