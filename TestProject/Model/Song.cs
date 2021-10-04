using System.ComponentModel.DataAnnotations.Schema;
namespace SimpleSong.Model
{
    
    public class Song
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SongId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string AlbumName { get; set; }
        public double Length { get; set; }
    }
}
