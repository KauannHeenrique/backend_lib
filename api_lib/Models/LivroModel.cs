namespace api_lib.Models
{
    public class LivroModel
    {
        public int Id { get; set; }

        public required string TituloLivro { get; set; }

        public required string AutorLivro { get; set; }

        public required string AnoLancamento { get; set; }

        public int QuantidadeDisponivel { get; set; }
    }
}
