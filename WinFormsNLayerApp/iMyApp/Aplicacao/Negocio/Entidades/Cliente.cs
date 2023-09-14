using Negocio.Entidades.Comum;

namespace Negocio.Entidades
{
    //Cliente herda os dados de Pessoa
    public class Cliente : Pessoa
    {
        public DateTime Nascimento { get; set; }
    }
}
