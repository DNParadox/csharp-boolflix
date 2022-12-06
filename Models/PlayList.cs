namespace csharp_boolfix.Models
{
    public class PlayList
    {
        public int Id { get; set; }

        public string Titolo { get; set; }

        public List<ContenutoVideo> ContenutiVideo { get; set; }

        public int ProfiloId { get; set; }

        public Profilo Profilo;
    }
}
