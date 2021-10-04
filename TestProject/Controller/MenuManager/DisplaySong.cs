using System;
using System.Collections.Generic;

using SimpleSong.Controller.DAO.DAOImpl;
using SimpleSong.Controller.DAO.DAOInterface;
using SimpleSong.Model;

namespace SimpleSong.Controller.MenuManager
{
    public class DisplaySong
    {
        private ISongDao SongDao = new SongDao();

        public void GetAllSongsList()
        {
            SongDao.GetAllSongs().ForEach(song => {
            Console.WriteLine(song.SongId + " " + song.Title + " " + song.Author + " " + song.AlbumName + " " + song.Length);
            });
            // Console.ReadLine();
        }
    }
}
