namespace csharp_boolfix.Models
{
    public class Profilo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int PlayListId;
        public PlayList? LaMiaPlaylist { get; set; }

        public List<ContenutoVideo>? ContenutiVideo { get; set; }
    }
}
