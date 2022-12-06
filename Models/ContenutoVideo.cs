namespace csharp_boolfix.Models
{
    public class ContenutoVideo
    {
        public int Id { get; set; }
        public string Titolo { get; set; }

        public int Durata { get; set; }

        public List<Genere>? Generi { get; set; }

        public List<PlayList>? PlayLists { get; set; }

        public List<Profilo>? Profili { get; set; }
    }
}
