namespace ProjetoBase.Models
{
    public class DespesaModel
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public int categoriaId { get; set; }
        public double valor { get; set; }
        public DateTime data { get; set; }
    }
}
