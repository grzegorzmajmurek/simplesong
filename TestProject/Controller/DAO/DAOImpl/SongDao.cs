using System;
using System.Collections.Generic;
using System.Linq;
using SimpleSong.Controller.DAO.DAOInterface;
using SimpleSong.Model;
using TestProject;

namespace SimpleSong.Controller.DAO.DAOImpl
{
    class SongDao : ISongDao
    {
        public void DeleteSong(string songTitle)
        {
            using (var context = new SimpleSongContext())
            {
                Song song = context.Songs.Where(song => song.Title == songTitle).FirstOrDefault<Song>();
                try
                {
                    context.Songs.Remove(song);
                    context.SaveChanges();
                }
                catch
                {
                    Console.WriteLine("Song title doesn't exist in DataBase");
                }
            }
        }

        public List<Song> GetAllSongs()
        {
            using (var context = new SimpleSongContext())
            {
                return context.Songs.ToList();
            }
        }

        public List<Song> GetSongByAlbumName(string albumName)
        {
            using (var context = new SimpleSongContext())
            {
                return context.Songs.Where(song => song.AlbumName == albumName).ToList();
            }
        }

        public void AddSong(Song song)
        {
            using (var context = new SimpleSongContext())
            {
                context.Songs.Add(song);
                context.SaveChanges();
            }
        }
    }
}
