using Microsoft.EntityFrameworkCore;
using SimpleSong.Model;

namespace SimpleSong
{
    public static class ModelCreatingExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    SongId = 1,
                    Title = "Jest jedna rzecz",
                    Author = "Rychu Peja",
                    AlbumName = "Na legalu",
                    Length = 3.20
                },
                new Song
                {
                    SongId = 2,
                    Title = "Kochana Polsko",
                    Author = "OSTR",
                    AlbumName = "Tabasko",
                    Length = 2.50
                },
                new Song
                {
                    SongId = 3,
                    Title = "Chcialem Byc",
                    Author = "Krzysztof Krawczyk",
                    AlbumName = "Najwieksze przeboje",
                    Length = 3.45
                }
                );
        }
    }
}
