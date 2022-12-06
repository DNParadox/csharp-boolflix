namespace csharp_boolfix.Models
{
    public class Genere
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public List<ContenutoVideo> ContenutiVideo { get; set; }
    }
}
