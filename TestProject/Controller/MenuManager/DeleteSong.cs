using System;
using SimpleSong.Controller.DAO.DAOImpl;
using SimpleSong.Controller.DAO.DAOInterface;
using SimpleSong.View;

namespace SimpleSong.Controller.MenuManager
{
    public class DeleteSong
    {
        private ISongDao SongDao = new SongDao();
        MenuView menuView = new MenuView();
        public void GoBack()
        {
            Console.ReadLine();
            Console.Clear();
            menuView.Display();
        }
        public void DeleteOneSong()
        {
            Console.WriteLine("Get song title to delete");
            var song = Console.ReadLine();
            SongDao.DeleteSong(song);
            GoBack();
        }
    }
}
