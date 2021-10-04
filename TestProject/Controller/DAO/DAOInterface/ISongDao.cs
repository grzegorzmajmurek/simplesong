using System.Collections.Generic;
using SimpleSong.Model;

namespace SimpleSong.Controller.DAO.DAOInterface
{
    public interface ISongDao
    {
        public List<Song> GetAllSongs();
        public void AddSong(Song song);
        public void DeleteSong(string songTitle);
        public List<Song> GetSongByAlbumName(string albumName);
    }
}
