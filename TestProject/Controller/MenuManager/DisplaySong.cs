using System;
using SimpleSong.Controller.DAO.DAOImpl;
using SimpleSong.Controller.DAO.DAOInterface;
using SimpleSong.View;

namespace SimpleSong.Controller.MenuManager
{
    public class DisplaySong
    {
        private ISongDao SongDao = new SongDao();
        MenuView menuView = new MenuView();
        public void GoBack()
        {
            Console.ReadLine();
            Console.Clear();
            menuView.Display();
        }
        public void GetAllSongsList()
        {
            SongDao.GetAllSongs().ForEach(song => {
            Console.WriteLine(song.SongId + " " + song.Title + " " + song.Author + " " + song.AlbumName + " " + song.Length);
            });
            GoBack();
        }
    }
}
