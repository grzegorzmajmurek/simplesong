using System;
using SimpleSong.Controller.DAO.DAOImpl;
using SimpleSong.Controller.DAO.DAOInterface;
using SimpleSong.View;
using static System.Console;

namespace SimpleSong.Controller.MenuManager
{
    public class GetSongByAlbum
    {
        private ISongDao SongDao = new SongDao();
        MenuView menuView = new MenuView();
        public void GoBack()
        {
            ReadLine();
            Clear();
            menuView.Display();
        }

        public void ShowSongsByAlbum()
        {
          WriteLine("Get album title to show songs");
          var albumName = Console.ReadLine();
          SongDao.GetSongByAlbumName(albumName).ForEach(song => {
          WriteLine(song.SongId + " " + song.Title + " " + song.Author + " " + song.AlbumName + " " + song.Length);
          });
          GoBack();
        }
    }
}
