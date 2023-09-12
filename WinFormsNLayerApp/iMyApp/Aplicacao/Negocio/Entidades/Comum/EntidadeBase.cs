namespace Negocio.Entidades.Comum
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }

        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
        public string AlteradoPor { get; set; }
    }
}
