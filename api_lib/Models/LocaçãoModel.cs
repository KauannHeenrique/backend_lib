namespace api_lib.Models
{
    public class LocaçãoModel
    {
        public int Id { get; set; }

        public required string NomeLocatario { get; set; }

        public int AnoNascimento { get; set; }
    }
}
