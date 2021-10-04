using SimpleSong.Controller.DAO.DAOImpl;
using SimpleSong.Controller.DAO.DAOInterface;
using SimpleSong.View;
using static System.Console;

namespace SimpleSong.Controller.MenuManager
{
    public class DeleteSong
    {
        private ISongDao SongDao = new SongDao();
        MenuView menuView = new MenuView();
        public void GoBack()
        {
            ReadLine();
            Clear();
            menuView.Display();
        }
        public void DeleteOneSong()
        {
            WriteLine("Get song title to delete");
            var song = ReadLine();
            SongDao.DeleteSong(song);
            GoBack();
        }
    }
}
